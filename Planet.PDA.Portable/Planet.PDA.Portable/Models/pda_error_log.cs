using System;

namespace Planet.PDA.Portable
{
    public class pda_error_log
    {
        public DateTime create_dte { get; set; }
        public int terminal_id { get; set; }
        public int seq { get; set; }
        public Nullable<int> com_id { get; set; }
        public Nullable<int> sync_flg { get; set; }
        public string store_cd { get; set; }
        public Nullable<int> send_flg { get; set; }
        public string display_message { get; set; }
        public string display_message2 { get; set; }
    }
}
