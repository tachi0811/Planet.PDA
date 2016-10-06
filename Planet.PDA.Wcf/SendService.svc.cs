using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Newtonsoft.Json;
using System.Data.Entity;
using Dapper;

namespace PDAWcfService
{
    /// <summary>
    /// 送信データService
    /// </summary>
    public class SendService : ISendService
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["pdaDB"].ToString();

        public string GetData(string tableName)
        {
            using (var con = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                var goods = con.Query<ap_system_parameter>("select * from " + tableName);
                return JsonConvert.SerializeObject(goods);
            }            
        }
    }
}
