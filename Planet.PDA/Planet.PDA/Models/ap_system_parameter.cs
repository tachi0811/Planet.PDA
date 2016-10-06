using System;

namespace Planet.PDA
{
    public class ap_system_parameter
    {
        public Nullable<short> multi_sales_price_use_flg { get; set; }
        public Nullable<int> hierarchy0_class_digit_nbr { get; set; }
        public Nullable<int> hierarchy1_class_digit_nbr { get; set; }
        public Nullable<int> hierarchy2_class_digit_nbr { get; set; }
        public Nullable<short> equal_ratio_flg { get; set; }
        public Nullable<short> taxable_item_equal_ratio_priority_flg { get; set; }
        public Nullable<short> tax_include_kbn { get; set; }
        public string discount_fraction_process_kbn { get; set; }
        public string bits_pos_tax_cd { get; set; }
        public Nullable<DateTime> create_date { get; set; }
        public Nullable<DateTime> update_date { get; set; }
    }
}
