using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class business_state_trn
    {
        [DataMember]
        public string store_cd { get; set; }
        [DataMember]
        public int terminal_id { get; set; }
        [DataMember]
        public DateTime open_dte { get; set; }
        [DataMember]
        public short transaction_type { get; set; }
        [DataMember]
        public DateTime business_dtetim { get; set; }
        [DataMember]
        public string staff_cd { get; set; }
        [DataMember]
        public Nullable<short> send_flg { get; set; }
        [DataMember]
        public Nullable<short> error_flg { get; set; }
    }
}
