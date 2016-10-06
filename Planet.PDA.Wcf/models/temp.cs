using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class temp
    {
        [DataMember]
        public string temp_cd { get; set; }
        [DataMember]
        public string temp_nm { get; set; }
        [DataMember]
        public Nullable<short> delete_flg { get; set; }
        [DataMember]
        public string staff_cd { get; set; }
    }
}
