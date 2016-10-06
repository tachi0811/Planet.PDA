using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class orders
    {
        [DataMember]
        public string store_cd { get; set; }
        [DataMember]
        public int terminal_id { get; set; }
        [DataMember]
        public DateTime orders_dtetim { get; set; }
        [DataMember]
        public string slip_no { get; set; }
        [DataMember]
        public string staff_cd { get; set; }
        [DataMember]
        public string supplier_cd { get; set; }
        [DataMember]
        public Nullable<short> server_update_flg { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
    }
}
