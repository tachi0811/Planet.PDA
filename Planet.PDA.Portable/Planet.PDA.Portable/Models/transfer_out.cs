using System;

namespace Planet.PDA.Portable
{
    public class transfer_out
    {
        public string store_cd { get; set; }
        public int terminal_id { get; set; }
        public DateTime transfer_dtetim { get; set; }
        public string store_to_cd { get; set; }
        public string staff_cd { get; set; }
        public short send_flg { get; set; }
        public short server_update_flg { get; set; }
        public DateTime create_dte { get; set; }
        public DateTime update_dte { get; set; }
    }
}
