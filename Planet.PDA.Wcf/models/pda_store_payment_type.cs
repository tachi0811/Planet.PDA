using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class pda_store_payment_type
    {
        [DataMember]
        public string store_cd { get; set; }
        [DataMember]
        public string bits_pos_payment_cd { get; set; }
        [DataMember]
        public string bits_pos_coupon_cd { get; set; }
        [DataMember]
        public string pda_l_name { get; set; }
        [DataMember]
        public Nullable<int> sort_order { get; set; }
        [DataMember]
        public Nullable<DateTime> create_date { get; set; }
        [DataMember]
        public Nullable<DateTime> update_date { get; set; }
    }
}
