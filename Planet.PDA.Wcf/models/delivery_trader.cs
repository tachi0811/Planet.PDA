using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class delivery_trader
    {
        [DataMember]
        public string trader_cd { get; set; }
        [DataMember]
        public string trader_nm { get; set; }
        [DataMember]
        public string trader_kana_nm { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
    }
}
