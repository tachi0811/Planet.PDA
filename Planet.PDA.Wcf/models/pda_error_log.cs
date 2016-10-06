using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class pda_error_log
    {
        [DataMember]
        public DateTime create_dte { get; set; }
        [DataMember]
        public int terminal_id { get; set; }
        [DataMember]
        public int seq { get; set; }
        [DataMember]
        public Nullable<int> com_id { get; set; }
        [DataMember]
        public Nullable<int> sync_flg { get; set; }
        [DataMember]
        public string store_cd { get; set; }
        [DataMember]
        public Nullable<int> send_flg { get; set; }
        [DataMember]
        public string display_message { get; set; }
        [DataMember]
        public string display_message2 { get; set; }
    }
}
