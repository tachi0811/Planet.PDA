using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class pda_pos_payment
    {
        [DataMember]
        public string store_cd { get; set; }
        [DataMember]
        public int terminal_id { get; set; }
        [DataMember]
        public string sales_dte { get; set; }
        [DataMember]
        public int receipt_id { get; set; }
        [DataMember]
        public int detail_no { get; set; }
        [DataMember]
        public string bits_pos_payment_cd { get; set; }
        [DataMember]
        public string bits_pos_coupon_cd { get; set; }
        [DataMember]
        public string pda_l_name { get; set; }
        [DataMember]
        public Nullable<decimal> deposit_amt { get; set; }
        [DataMember]
        public Nullable<decimal> payment_amt { get; set; }
        [DataMember]
        public Nullable<decimal> ticket_no_change_amt { get; set; }
        [DataMember]
        public Nullable<decimal> ticket_change_amt { get; set; }
    }
}
