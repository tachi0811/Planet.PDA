using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class delivery_service
    {
        [DataMember]
        public string store_cd { get; set; }
        [DataMember]
        public string trader_cd { get; set; }
        [DataMember]
        public string delivery_service_cd { get; set; }
        [DataMember]
        public string delivery_service_nm { get; set; }
        [DataMember]
        public Nullable<decimal> add_price { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
    }
}
