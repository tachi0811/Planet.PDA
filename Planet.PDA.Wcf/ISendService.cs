using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PDAWcfService
{
    // メモ: [リファクター] メニューの [名前の変更] コマンドを使用すると、コードと config ファイルの両方で同時にインターフェイス名 "IService1" を変更できます。
    [ServiceContract(Namespace = "http://Planet.Wcf")]
    public interface ISendService
    {

        [OperationContract]
        [WebInvoke(UriTemplate = "/getdata/{tableName}", ResponseFormat = WebMessageFormat.Json, Method = "GET", RequestFormat = WebMessageFormat.Json)]
        string GetData(string tableName);

    }



}
