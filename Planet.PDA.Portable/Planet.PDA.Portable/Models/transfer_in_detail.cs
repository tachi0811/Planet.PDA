using System;

namespace Planet.PDA.Portable
{
    public class transfer_in_detail
    {
        public string store_cd { get; set; }
        public int terminal_id { get; set; }
        public DateTime transfer_dtetim { get; set; }
        public short seq_no { get; set; }
        public string goods_cd { get; set; }
        public int transfer_qty { get; set; }
        public DateTime create_dte { get; set; }
        public DateTime update_dte { get; set; }
    }
}
