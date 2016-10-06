using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class terminal_apply_business
    {
        [DataMember]
        public string store_cd { get; set; }
        [DataMember]
        public int terminal_id { get; set; }
        [DataMember]
        public string apply_business_cd { get; set; }
        [DataMember]
        public Nullable<DateTime> start_dte { get; set; }
        [DataMember]
        public Nullable<short> delete_flg { get; set; }
    }
}
