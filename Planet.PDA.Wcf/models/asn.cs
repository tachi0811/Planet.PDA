using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class asn
    {
        [DataMember]
        public string store_cd { get; set; }
        [DataMember]
        public string goods_cd { get; set; }
        [DataMember]
        public DateTime asn_dte { get; set; }
        [DataMember]
        public short asn_kbn { get; set; }
        [DataMember]
        public Nullable<int> asn_qty { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
    }
}
