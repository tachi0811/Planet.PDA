using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Planet.PDA.Portable
{
    public class Common
    {
        public static async Task InsertMasterDataAll()
        {

            // MasterDataTaskを準備する
            var tasks = Task.WhenAll(
                InsertMasterData<large_class>(),
                //InsertData<middle_class>(),
                //InsertData<small_class>(),
                //InsertData<goods>(),
                //InsertData<store>(),
                // InsertData<store_goods>()
                //InsertData<staff>(),
                //InsertData<trade>(),
                //InsertData<customer_base>(),
                //InsertData<kbn_manage>(),
                //InsertData<kbn_manage_detail>(),
                //InsertData<supplier_goods>()
                // InsertData<receipt_cm>(),
                //InsertData<preset_page>(),
                //InsertData<preset_button>(),
                //InsertData<pos_sales_price>(),
                //InsertData<ap_system_parameter>(),
                //InsertData<terminal_manage>(),
                //InsertData<bits_pos_tax>(),
                //InsertData<bits_pos_payment_parameter>(),
                //InsertData<bits_pos_coupon>(),
                InsertMasterData<orion_store_coupon>(),
                InsertMasterData<pda_store_payment_type>()
                //// InsertData<pda_payment_point_attriute>()
                );
            await tasks;

        }

        /// <summary>
        /// SQLiteにデータ取得
        /// </summary>
        /// <typeparam name="T">クラス</typeparam>
        public async static Task InsertMasterData<T>()
            where T : class
        {
            var db = new SQLiteAccessor();

            // テーブルの作成
            db.CreateTable<T>();

            var x = await GetMasterData(typeof(T).Name);

            // Joson To Entity
            var dataList = JsonConvert.DeserializeObject<List<T>>(x);
            // 登録
            db.InsertAll<T>(dataList);
        }

        /// <summary>
        /// WebService呼び出し
        /// </summary>
        /// <param name="tableName">テーブル名</param>
        /// <returns></returns>
        async static Task<string> GetMasterData(string tableName)
        {
            var httpClient = new HttpClient();
            var xElement = default(System.Xml.Linq.XElement);

            // localhost は、モバイル端末を示すので厳密なIPを指定する
            using (System.IO.Stream stream = await httpClient.GetStreamAsync(string.Format("http://192.168.15.52/Planet.PDA.Wcf/SendService.svc/getdata/{0}", tableName)))
            {
                xElement = System.Xml.Linq.XElement.Load(stream);
            }

            return xElement.Value;

        }

    }
}
