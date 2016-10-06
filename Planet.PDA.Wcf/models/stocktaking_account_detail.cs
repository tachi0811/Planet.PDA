using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class stocktaking_account_detail
    {
        [DataMember]
        public string store_cd { get; set; }
        [DataMember]
        public int terminal_id { get; set; }
        [DataMember]
        public DateTime tana_account_dtetim { get; set; }
        [DataMember]
        public short seq_no { get; set; }
        [DataMember]
        public string small_class_cd { get; set; }
        [DataMember]
        public Nullable<decimal> sales_price { get; set; }
        [DataMember]
        public Nullable<int> tana_qty { get; set; }
        [DataMember]
        public string goods_cd { get; set; }
    }
}
