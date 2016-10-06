using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class supplier
    {
        [DataMember]
        public string supplier_cd { get; set; }
        [DataMember]
        public string supplier_nm { get; set; }
        [DataMember]
        public string supplier_kana_nm { get; set; }
        [DataMember]
        public Nullable<short> delete_flg { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
    }
}
