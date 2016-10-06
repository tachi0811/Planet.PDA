using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class pda_receipt_cm
    {
        [DataMember]
        public string store_cd { get; set; }
        [DataMember]
        public string receipt_cm_message_1 { get; set; }
        [DataMember]
        public string receipt_cm_message_2 { get; set; }
        [DataMember]
        public string receipt_cm_message_3 { get; set; }
        [DataMember]
        public string receipt_cm_message_4 { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
    }
}
