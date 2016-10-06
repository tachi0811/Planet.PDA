using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class store_goods
    {
        [DataMember]
        public string store_cd { get; set; }
        [DataMember]
        public string goods_cd { get; set; }
        [DataMember]
        public Nullable<decimal> sales_price { get; set; }
        [DataMember]
        public Nullable<decimal> sales_price2 { get; set; }
        [DataMember]
        public Nullable<decimal> sales_price3 { get; set; }
        [DataMember]
        public Nullable<decimal> sales_price4 { get; set; }
        [DataMember]
        public Nullable<decimal> sales_price5 { get; set; }
        [DataMember]
        public Nullable<int> inventory_reach_point { get; set; }
        [DataMember]
        public Nullable<short> delete_flg { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
    }
}
