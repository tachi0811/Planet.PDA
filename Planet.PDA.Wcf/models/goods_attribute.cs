using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class goods_attribute
    {
        [DataMember]
        public string goods_cd { get; set; }
        [DataMember]
        public string color_nm { get; set; }
        [DataMember]
        public string size_nm { get; set; }
        [DataMember]
        public string picture_file_nm { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
    }
}
