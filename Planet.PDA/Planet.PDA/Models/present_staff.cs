using System;

namespace Planet.PDA
{
    public class present_staff
    {
        public DateTime event_dte { get; set; }
        public string sales_staff_cd { get; set; }
        public string store_cd { get; set; }
        public int terminal_id { get; set; }
        public DateTime scan_dte { get; set; }
        public string staff_cd { get; set; }
        public short send_flg { get; set; }
        public short server_update_flg { get; set; }
        public DateTime create_dte { get; set; }
        public DateTime update_dte { get; set; }
    }
}
