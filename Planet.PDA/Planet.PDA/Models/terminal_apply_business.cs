using System;

namespace Planet.PDA
{
    public class terminal_apply_business
    {
        public string store_cd { get; set; }
        public int terminal_id { get; set; }
        public string apply_business_cd { get; set; }
        public Nullable<DateTime> start_dte { get; set; }
        public Nullable<short> delete_flg { get; set; }
    }
}
