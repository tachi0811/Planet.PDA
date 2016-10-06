using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class assign_number
    {
        [DataMember]
        public string store_cd { get; set; }
        [DataMember]
        public string assign_year { get; set; }
        [DataMember]
        public string assign_month { get; set; }
        [DataMember]
        public string transfer_ask_no { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
    }
}
