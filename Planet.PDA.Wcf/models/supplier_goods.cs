using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class supplier_goods
    {
        [DataMember]
        public string supplier_cd { get; set; }
        [DataMember]
        public string goods_cd { get; set; }
        [DataMember]
        public Nullable<decimal> cost_price { get; set; }
        [DataMember]
        public Nullable<short> lot { get; set; }
        [DataMember]
        public Nullable<int> lead_time { get; set; }
        [DataMember]
        public Nullable<short> advise_order_flg { get; set; }
        [DataMember]
        public Nullable<short> delete_flg { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
    }
}
