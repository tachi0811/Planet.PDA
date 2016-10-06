using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class kbn_manage_convert
    {
        [DataMember]
        public string kbn_control_cd { get; set; }
        [DataMember]
        public string l_name { get; set; }
        [DataMember]
        public string kbn_manage_cd { get; set; }
        [DataMember]
        public Nullable<short> delete_flg { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
    }
}
