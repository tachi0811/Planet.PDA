using System;

namespace Planet.PDA
{
    public class terminal_manage
    {
        public string store_cd { get; set; }
        public int terminal_id { get; set; }
        public string license_key { get; set; }
        public Nullable<short> delete_flg { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
