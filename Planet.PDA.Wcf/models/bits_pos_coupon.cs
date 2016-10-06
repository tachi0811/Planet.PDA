using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class bits_pos_coupon
    {
        [DataMember]
        public string bits_pos_payment_cd { get; set; }
        [DataMember]
        public string bits_pos_coupon_cd { get; set; }
        [DataMember]
        public string l_name { get; set; }
        [DataMember]
        public string fiscalstamp_target_flg { get; set; }
        [DataMember]
        public Nullable<DateTime> create_date { get; set; }
        [DataMember]
        public Nullable<DateTime> update_date { get; set; }
    }
}
