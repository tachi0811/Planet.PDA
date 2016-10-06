using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class pda_orders_detail
    {
        [DataMember]
        public string store_cd { get; set; }
        [DataMember]
        public int terminal_id { get; set; }
        [DataMember]
        public DateTime orders_dtetim { get; set; }
        [DataMember]
        public short seq_no { get; set; }
        [DataMember]
        public string goods_cd { get; set; }
        [DataMember]
        public Nullable<int> order_qty { get; set; }
        [DataMember]
        public string supplier_cd { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
    }
}
