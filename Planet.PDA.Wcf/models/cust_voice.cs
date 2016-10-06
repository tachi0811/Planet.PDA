using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class cust_voice
    {
        [DataMember]
        public string store_cd { get; set; }
        [DataMember]
        public string staff_cd { get; set; }
        [DataMember]
        public string cust_voice_class_cd { get; set; }
        [DataMember]
        public DateTime send_dte { get; set; }
        [DataMember]
        public string goods_cd { get; set; }
        [DataMember]
        public string itemfeatur_notes { get; set; }
        [DataMember]
        public string request_notes { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
    }
}
