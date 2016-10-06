using System;

namespace Planet.PDA
{
    public class export_sales_line_item
    {
        public string store_code { get; set; }
        public short terminal_no { get; set; }
        public long transaction_no { get; set; }
        public short line_no { get; set; }
        public string entry_type { get; set; }
        public string item_code { get; set; }
        public string description { get; set; }
        public Nullable<decimal> unit_price_normal { get; set; }
        public Nullable<decimal> unit_price_overrided { get; set; }
        public Nullable<decimal> cost_price { get; set; }
        public Nullable<short> quantity { get; set; }
        public string price_type { get; set; }
        public string department_type_code { get; set; }
        public string stock_number { get; set; }
        public string color_name { get; set; }
        public string size_name { get; set; }
        public string is_sub_total_discount_prohibition { get; set; }
        public string mdhierarchy1_code { get; set; }
        public string mdhierarchy1_name { get; set; }
        public string mdhierarchy2_code { get; set; }
        public string mdhierarchy2_name { get; set; }
        public string mdhierarchy3_code { get; set; }
        public string mdhierarchy3_name { get; set; }
        public string tax_group_code { get; set; }
        public string tax_type { get; set; }
        public Nullable<decimal> tax_rate { get; set; }
        public Nullable<int> tax_round_digit { get; set; }
        public string tax_round_method { get; set; }
        public string discount_code { get; set; }
        public Nullable<int> discount_value { get; set; }
        public Nullable<decimal> discount_amount { get; set; }
        public string discount_name { get; set; }
        public Nullable<DateTime> create_date { get; set; }
    }
}
