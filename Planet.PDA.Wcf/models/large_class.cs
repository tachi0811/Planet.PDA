using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class large_class
    {
        [DataMember]
        public string large_class_cd { get; set; }
        [DataMember]
        public string large_class_nm { get; set; }
        [DataMember]
        public string large_class_kana_nm { get; set; }
        [DataMember]
        public Nullable<short> tax_kbn { get; set; }
        [DataMember]
        public Nullable<short> discount_flg { get; set; }
        [DataMember]
        public Nullable<short> return_flg { get; set; }
        [DataMember]
        public Nullable<short> delete_flg { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
    }
}
