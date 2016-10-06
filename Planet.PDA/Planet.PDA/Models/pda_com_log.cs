using System;

namespace Planet.PDA
{
    public class pda_com_log
    {
        public string store_cd { get; set; }
        public Nullable<int> terminal_id { get; set; }
        public Nullable<DateTime> com_start_dtetim { get; set; }
        public Nullable<int> com_id { get; set; }
        public Nullable<int> cnt { get; set; }
        public Nullable<short> complete_flg { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
