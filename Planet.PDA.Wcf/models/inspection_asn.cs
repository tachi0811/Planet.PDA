using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class inspection_asn
    {
        [DataMember]
        public string slip_no { get; set; }
        [DataMember]
        public short seq_no { get; set; }
        [DataMember]
        public string goods_cd { get; set; }
        [DataMember]
        public Nullable<int> expected_qty { get; set; }
        [DataMember]
        public string store_cd { get; set; }
    }
}
