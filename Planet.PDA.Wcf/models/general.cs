using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class general
    {
        [DataMember]
        public string general_cd { get; set; }
        [DataMember]
        public string store_cd { get; set; }
        [DataMember]
        public string general_nm { get; set; }
        [DataMember]
        public string display_content { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
    }
}
