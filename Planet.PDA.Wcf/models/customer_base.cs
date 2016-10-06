using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class customer_base
    {
        [DataMember]
        public string customer_base_cd { get; set; }
        [DataMember]
        public string customer_base_nm { get; set; }
        [DataMember]
        public Nullable<short> delete_flg { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
        [DataMember]
        public Nullable<short> default_flg { get; set; }
    }
}
