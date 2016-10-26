using System;

namespace Planet.PDA.Portable
{
    public class transaction_no_management
    {
        public string store_code { get; set; }
        public short terminal_no { get; set; }
        public Nullable<long> transaction_no { get; set; }
        public Nullable<DateTime> create_date { get; set; }
        public Nullable<DateTime> update_date { get; set; }
    }
}
