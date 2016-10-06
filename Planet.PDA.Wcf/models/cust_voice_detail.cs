using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class cust_voice_detail
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
        public string kbn_manage_cd { get; set; }
        [DataMember]
        public string kbn_manage_detail_cd { get; set; }
        [DataMember]
        public string cust_voice_class_nm { get; set; }
        [DataMember]
        public string kbn_manage_nm { get; set; }
        [DataMember]
        public string kbn_manage_detail_nm { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
    }
}
