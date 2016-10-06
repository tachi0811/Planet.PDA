using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class delivery_area
    {
        [DataMember]
        public string store_cd { get; set; }
        [DataMember]
        public string trader_cd { get; set; }
        [DataMember]
        public string area_cd { get; set; }
        [DataMember]
        public string area_parent_cd { get; set; }
        [DataMember]
        public string area_layer { get; set; }
        [DataMember]
        public string area_nm { get; set; }
        [DataMember]
        public string area_kana_nm { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
    }
}
