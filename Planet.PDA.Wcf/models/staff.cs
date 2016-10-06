using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class staff
    {
        [DataMember]
        public string staff_cd { get; set; }
        [DataMember]
        public string staff_nm { get; set; }
        [DataMember]
        public string staff_kana_nm { get; set; }
        [DataMember]
        public string staff_password { get; set; }
        [DataMember]
        public Nullable<short> authority_kbn { get; set; }
        [DataMember]
        public short all_store_flg { get; set; }
        [DataMember]
        public Nullable<short> delete_flg { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
    }
}
