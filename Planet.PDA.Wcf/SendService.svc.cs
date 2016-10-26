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
using System.Data;
using System.Data.SqlClient;

namespace Planet.PDA.Wcf
{
    /// <summary>
    /// 送信データService
    /// </summary>
    public class SendService : ISendService
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["pdaDB"].ToString();

        public string GetData(string tableName, DateTime lastUpdateDateTime)
        {
            using (var con = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                var data = con.Query("select * from " + tableName);
                // Dapper を使用して、SQLを発行します
                 return JsonConvert.SerializeObject(data);
            }
        }


       
    }
}
