using System;

namespace Planet.PDA
{
    public class transaction_send_management
    {
        public string store_code { get; set; }
        public short terminal_no { get; set; }
        public long transaction_no { get; set; }
        public Nullable<short> transaction_type { get; set; }
        public Nullable<short> send_flg { get; set; }
        public Nullable<short> error_flg { get; set; }
        public Nullable<DateTime> create_date { get; set; }
        public Nullable<DateTime> update_date { get; set; }
        public string src_store_code { get; set; }
    }
}
