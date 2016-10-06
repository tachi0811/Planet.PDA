using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class pda_com_log
    {
        [DataMember]
        public string store_cd { get; set; }
        [DataMember]
        public Nullable<int> terminal_id { get; set; }
        [DataMember]
        public Nullable<DateTime> com_start_dtetim { get; set; }
        [DataMember]
        public Nullable<int> com_id { get; set; }
        [DataMember]
        public Nullable<int> cnt { get; set; }
        [DataMember]
        public Nullable<short> complete_flg { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
    }
}
