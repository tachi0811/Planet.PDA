using System;

namespace Planet.PDA
{
    public class bits_pos_payment_parameter
    {
        public string bits_pos_payment_cd { get; set; }
        public string change_permit_flg { get; set; }
        public string deposit_forcingentry_flg { get; set; }
        public string trade_over_permit_flg { get; set; }
        public string fiscalstamp_target_flg { get; set; }
        public Nullable<decimal> duplicate_receipt_page { get; set; }
        public string use_flg { get; set; }
        public Nullable<DateTime> create_date { get; set; }
        public Nullable<DateTime> update_date { get; set; }
    }
}
