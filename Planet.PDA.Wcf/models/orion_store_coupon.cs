using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class orion_store_coupon
    {
        [DataMember]
        public string store_cd { get; set; }
        [DataMember]
        public string bits_pos_payment_cd { get; set; }
        [DataMember]
        public string bits_pos_coupon_cd { get; set; }
        [DataMember]
        public Nullable<decimal> use_unit_amt { get; set; }
        [DataMember]
        public Nullable<decimal> use_min_amt { get; set; }
        [DataMember]
        public string change_permit_flg { get; set; }
        [DataMember]
        public string deposit_forcingentry_flg { get; set; }
        [DataMember]
        public string trade_over_permit_flg { get; set; }
        [DataMember]
        public string use_flg { get; set; }
        [DataMember]
        public Nullable<DateTime> create_date { get; set; }
        [DataMember]
        public Nullable<DateTime> update_date { get; set; }
    }
}
