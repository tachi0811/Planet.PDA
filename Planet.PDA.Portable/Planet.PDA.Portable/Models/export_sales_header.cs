using System;

namespace Planet.PDA.Portable
{
    public class export_sales_header
    {
        public string store_code { get; set; }
        public short terminal_no { get; set; }
        public long transaction_no { get; set; }
        public Nullable<DateTime> system_date_time { get; set; }
        public Nullable<DateTime> business_date { get; set; }
        public Nullable<long> receipt_no { get; set; }
        public string operator_code { get; set; }
        public string operator_name { get; set; }
        public Nullable<short> transaction_type { get; set; }
        public Nullable<short> total_line_item_count { get; set; }
        public Nullable<short> total_payment_count { get; set; }
        public Nullable<short> voided_transaction_type { get; set; }
        public Nullable<DateTime> voided_system_date_time { get; set; }
        public Nullable<short> voided_terminal_no { get; set; }
        public Nullable<long> voided_receipt_no { get; set; }
        public string voided_operator_code { get; set; }
        public string voided_operator_name { get; set; }
        public Nullable<short> non_exchange_ticket_count { get; set; }
        public string customer_type_code { get; set; }
        public string customer_type_name { get; set; }
        public Nullable<short> customer_count { get; set; }
        public string operator_receipt_name { get; set; }
        public string discount_code { get; set; }
        public Nullable<int> discount_value { get; set; }
        public Nullable<decimal> discount_amount { get; set; }
        public string discount_name { get; set; }
        public Nullable<DateTime> create_date { get; set; }
        public string customer_code { get; set; }
    }
}
