using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Dapper;

namespace Planet.PDA.Tools.ModelCreator
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtOutput.Text = @"C:\temp\";
            txtNamespace.Text = "PDAWcfService";
        }

        private void OutputButton_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["pdaDB"].ToString();
            using (var con = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                con.Open();
                var databaseInfo = con.Query<DatabaseInfo>(GetSql());

                string sName = txtNamespace.Text;
                string sFilePath = txtOutput.Text;
                bool? iswdcf = radioWCF.IsChecked;

                Parallel.ForEach(databaseInfo.Select(x => x.table_name).Distinct(), tableName =>
                {
                    var fileData = new System.Text.StringBuilder();
                    fileData.AppendLine("using System;");
                    if (iswdcf == true)
                    {
                        fileData.AppendLine("using System.Runtime.Serialization;");
                    }
                    fileData.AppendLine("");
                    fileData.AppendLine("namespace " + sName);
                    fileData.AppendLine("{");

                    if (iswdcf == true)
                    {
                        fileData.AppendLine("    [DataContract]");
                    }

                    fileData.AppendLine("    public class " + tableName);
                    fileData.AppendLine("    {");

                    foreach (var data in databaseInfo.Where(x => x.table_name == tableName).OrderBy(x => x.column_id))
                    {
                        if (iswdcf == true)
                        {
                            fileData.AppendLine("        [DataMember]");
                        }

                        string column = "        public ";

                        if (data.nullable == "Y")
                        {
                            column += "Nullable<";
                        }

                        switch (data.data_type)
                        {
                            case "bigint" :
                                column += "long";
                                break;                            
                            case "char":
                                column += "string";
                                break;
                            case "datetime":
                                column += "DateTime";
                                break;
                            case "image":
                                column += "byte[]";
                                break;
                            case "int":
                                column += "int";
                                break;
                            case "money":
                                column += "decimal";
                                break;
                            case "nchar":
                                column += "string";
                                break;
                            case "numeric":
                                column += "decimal";
                                break;
                            case "nvarchar":
                                column += "string";
                                break;
                            case "real":
                                column += "float";
                                break;
                            case "smallint":
                                column += "short";
                                break;
                            case "tinyint":
                                column += "int";
                                break;
                            case "varchar":
                                column += "string";
                                break;
                            default:

                                break;
                        }

                        if (data.nullable == "Y")
                        {
                            column += ">";
                        }

                        if (column.IndexOf("string") >= 0)
                        {
                            column = "        public string";
                        }
                        else if (column.IndexOf("byte[]") >= 0)
                        {
                            column = "        public byte[]";
                        }

                        column += " " + data.column_name + " { get; set; }";

                        fileData.AppendLine(column);

                    }

                    fileData.AppendLine("    }");
                    fileData.AppendLine("}");

                    using (var fs = System.IO.File.Create(System.IO.Path.Combine(sFilePath, tableName + ".cs")))
                    {
                        var info = new UTF8Encoding(true).GetBytes(fileData.ToString());
                        fs.Write(info, 0, info.Length);
                    }
                });


            }
        }


        private string GetSql()
        {
            return @"select
	object_name(c.object_id) as table_name
,	c.name as column_name
,	type_name(c.user_type_id) as data_type
,   c.column_id
,	case when c.is_nullable = 0 then 'N' else 'Y' end nullable
,	case when p.parent_object_id is null then '' else 'PK' end as pk
from 
	sys.columns c
join
	sys.tables t
on	c.object_id = t.object_id
left join
	(
	select
		k.parent_object_id
	,	c2.name	
	from
		sys.key_constraints k
	join
		sys.index_columns ic
	on	k.parent_object_id = ic.object_id
	and k.type = 'PK'
	and	k.unique_index_id  = ic.index_id
	join
		sys.columns c2
	on	ic.object_id = c2.object_id
	and ic.column_id = c2.column_id
	) p
on	t.object_id = p.parent_object_id
and c.name = p.name
order by
	object_name(c.object_id)
,	c.column_id";
        }
    }



    public class DatabaseInfo
    {
        public string table_name { get; set; }

        public string column_name { get; set; }

        public string data_type { get; set; }

        public int column_id { get; set; }

        public string nullable { get;set;}

        public string pk { get; set; }
    }
}
