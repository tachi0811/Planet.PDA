using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class shipping_rate
    {
        [DataMember]
        public string store_cd { get; set; }
        [DataMember]
        public string trader_cd { get; set; }
        [DataMember]
        public string area_cd { get; set; }
        [DataMember]
        public string pack_class_cd { get; set; }
        [DataMember]
        public Nullable<decimal> delivery_price { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
    }
}
