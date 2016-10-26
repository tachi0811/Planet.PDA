using System;

namespace Planet.PDA.Portable
{
    public class pda_pos_payment
    {
        public string store_cd { get; set; }
        public int terminal_id { get; set; }
        public string sales_dte { get; set; }
        public int receipt_id { get; set; }
        public int detail_no { get; set; }
        public string bits_pos_payment_cd { get; set; }
        public string bits_pos_coupon_cd { get; set; }
        public string pda_l_name { get; set; }
        public Nullable<decimal> deposit_amt { get; set; }
        public Nullable<decimal> payment_amt { get; set; }
        public Nullable<decimal> ticket_no_change_amt { get; set; }
        public Nullable<decimal> ticket_change_amt { get; set; }
    }
}
