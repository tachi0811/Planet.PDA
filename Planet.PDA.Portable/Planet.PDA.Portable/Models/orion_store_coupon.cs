using System;

namespace Planet.PDA.Portable
{
    public class orion_store_coupon
    {
        public string store_cd { get; set; }
        public string bits_pos_payment_cd { get; set; }
        public string bits_pos_coupon_cd { get; set; }
        public Nullable<decimal> use_unit_amt { get; set; }
        public Nullable<decimal> use_min_amt { get; set; }
        public string change_permit_flg { get; set; }
        public string deposit_forcingentry_flg { get; set; }
        public string trade_over_permit_flg { get; set; }
        public string use_flg { get; set; }
        public Nullable<DateTime> create_date { get; set; }
        public Nullable<DateTime> update_date { get; set; }
    }
}
