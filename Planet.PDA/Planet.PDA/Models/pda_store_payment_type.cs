using System;

namespace Planet.PDA
{
    public class pda_store_payment_type
    {
        public string store_cd { get; set; }
        public string bits_pos_payment_cd { get; set; }
        public string bits_pos_coupon_cd { get; set; }
        public string pda_l_name { get; set; }
        public Nullable<int> sort_order { get; set; }
        public Nullable<DateTime> create_date { get; set; }
        public Nullable<DateTime> update_date { get; set; }
    }
}
