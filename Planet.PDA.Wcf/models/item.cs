using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class item
    {
        [DataMember]
        public string item_cd { get; set; }
        [DataMember]
        public string goods_cd { get; set; }
        [DataMember]
        public int seq { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
    }
}
