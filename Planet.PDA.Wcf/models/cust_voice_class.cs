using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class cust_voice_class
    {
        [DataMember]
        public string cust_voice_class_cd { get; set; }
        [DataMember]
        public string cust_voice_class_nm { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
    }
}
