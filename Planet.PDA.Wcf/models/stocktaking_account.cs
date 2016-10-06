using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class stocktaking_account
    {
        [DataMember]
        public string store_cd { get; set; }
        [DataMember]
        public int terminal_id { get; set; }
        [DataMember]
        public DateTime tana_account_dtetim { get; set; }
        [DataMember]
        public string staff_cd { get; set; }
    }
}
