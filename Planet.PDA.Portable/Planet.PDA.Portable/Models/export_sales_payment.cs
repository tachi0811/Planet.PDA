using System;

namespace Planet.PDA.Portable
{
    public class export_sales_payment
    {
        public string store_code { get; set; }
        public short terminal_no { get; set; }
        public long transaction_no { get; set; }
        public short line_no { get; set; }
        public string payment_code { get; set; }
        public string ticket_code { get; set; }
        public Nullable<decimal> deposit_amount { get; set; }
        public Nullable<decimal> amount { get; set; }
        public Nullable<decimal> ticket_no_change_amount { get; set; }
        public Nullable<decimal> ticket_change_amount { get; set; }
        public string description { get; set; }
        public Nullable<DateTime> create_date { get; set; }
    }
}
