using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class kbn_manage
    {
        [DataMember]
        public string kbn_manage_cd { get; set; }
        [DataMember]
        public string kbn_manage_nm { get; set; }
        [DataMember]
        public Nullable<short> display_order { get; set; }
        [DataMember]
        public Nullable<short> delete_flg { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
    }
}
