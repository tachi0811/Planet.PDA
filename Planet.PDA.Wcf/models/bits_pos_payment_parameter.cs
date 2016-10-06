using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class bits_pos_payment_parameter
    {
        [DataMember]
        public string bits_pos_payment_cd { get; set; }
        [DataMember]
        public string change_permit_flg { get; set; }
        [DataMember]
        public string deposit_forcingentry_flg { get; set; }
        [DataMember]
        public string trade_over_permit_flg { get; set; }
        [DataMember]
        public string fiscalstamp_target_flg { get; set; }
        [DataMember]
        public Nullable<decimal> duplicate_receipt_page { get; set; }
        [DataMember]
        public string use_flg { get; set; }
        [DataMember]
        public Nullable<DateTime> create_date { get; set; }
        [DataMember]
        public Nullable<DateTime> update_date { get; set; }
    }
}
