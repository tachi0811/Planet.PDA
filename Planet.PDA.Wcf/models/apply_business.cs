using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class apply_business
    {
        [DataMember]
        public string apply_business_cd { get; set; }
        [DataMember]
        public string apply_business_nm { get; set; }
        [DataMember]
        public Nullable<short> delete_flg { get; set; }
    }
}
