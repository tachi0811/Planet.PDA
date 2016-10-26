using System;

namespace Planet.PDA.Portable
{
    public class export_close
    {
        public string store_code { get; set; }
        public short terminal_no { get; set; }
        public long transaction_no { get; set; }
        public Nullable<DateTime> system_date_time { get; set; }
        public Nullable<DateTime> business_date { get; set; }
        public Nullable<long> receipt_no { get; set; }
        public string operator_code { get; set; }
        public string operator_name { get; set; }
        public Nullable<DateTime> create_date { get; set; }
    }
}
