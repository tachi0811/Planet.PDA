using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class transfer_request
    {
        [DataMember]
        public string store_cd { get; set; }
        [DataMember]
        public string transfer_ask_no { get; set; }
        [DataMember]
        public DateTime transfer_dte { get; set; }
        [DataMember]
        public string goods_cd { get; set; }
        [DataMember]
        public string store_from_cd { get; set; }
        [DataMember]
        public string store_to_cd { get; set; }
        [DataMember]
        public string staff_from_cd { get; set; }
        [DataMember]
        public string staff_to_cd { get; set; }
        [DataMember]
        public Nullable<int> transfer_qty { get; set; }
        [DataMember]
        public Nullable<int> fix_qty { get; set; }
        [DataMember]
        public string orders_cd { get; set; }
        [DataMember]
        public string transfer_status { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
    }
}
