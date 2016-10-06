using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class store
    {
        [DataMember]
        public string store_cd { get; set; }
        [DataMember]
        public string store_nm { get; set; }
        [DataMember]
        public Nullable<short> intax_flg { get; set; }
        [DataMember]
        public Nullable<short> delete_flg { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
        [DataMember]
        public string store_message1 { get; set; }
        [DataMember]
        public string store_message2 { get; set; }
        [DataMember]
        public string store_message3 { get; set; }
        [DataMember]
        public string store_message4 { get; set; }
        [DataMember]
        public string store_message5 { get; set; }
    }
}
