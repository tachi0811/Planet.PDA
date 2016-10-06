using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class export_sales_line_item
    {
        [DataMember]
        public string store_code { get; set; }
        [DataMember]
        public short terminal_no { get; set; }
        [DataMember]
        public long transaction_no { get; set; }
        [DataMember]
        public short line_no { get; set; }
        [DataMember]
        public string entry_type { get; set; }
        [DataMember]
        public string item_code { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public Nullable<decimal> unit_price_normal { get; set; }
        [DataMember]
        public Nullable<decimal> unit_price_overrided { get; set; }
        [DataMember]
        public Nullable<decimal> cost_price { get; set; }
        [DataMember]
        public Nullable<short> quantity { get; set; }
        [DataMember]
        public string price_type { get; set; }
        [DataMember]
        public string department_type_code { get; set; }
        [DataMember]
        public string stock_number { get; set; }
        [DataMember]
        public string color_name { get; set; }
        [DataMember]
        public string size_name { get; set; }
        [DataMember]
        public string is_sub_total_discount_prohibition { get; set; }
        [DataMember]
        public string mdhierarchy1_code { get; set; }
        [DataMember]
        public string mdhierarchy1_name { get; set; }
        [DataMember]
        public string mdhierarchy2_code { get; set; }
        [DataMember]
        public string mdhierarchy2_name { get; set; }
        [DataMember]
        public string mdhierarchy3_code { get; set; }
        [DataMember]
        public string mdhierarchy3_name { get; set; }
        [DataMember]
        public string tax_group_code { get; set; }
        [DataMember]
        public string tax_type { get; set; }
        [DataMember]
        public Nullable<decimal> tax_rate { get; set; }
        [DataMember]
        public Nullable<int> tax_round_digit { get; set; }
        [DataMember]
        public string tax_round_method { get; set; }
        [DataMember]
        public string discount_code { get; set; }
        [DataMember]
        public Nullable<int> discount_value { get; set; }
        [DataMember]
        public Nullable<decimal> discount_amount { get; set; }
        [DataMember]
        public string discount_name { get; set; }
        [DataMember]
        public Nullable<DateTime> create_date { get; set; }
    }
}
