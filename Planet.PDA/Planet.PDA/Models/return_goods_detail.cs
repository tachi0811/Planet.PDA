using System;

namespace Planet.PDA
{
    public class return_goods_detail
    {
        public string store_cd { get; set; }
        public int terminal_id { get; set; }
        public DateTime return_dtetim { get; set; }
        public short seq_no { get; set; }
        public string goods_cd { get; set; }
        public int return_qty { get; set; }
        public DateTime create_dte { get; set; }
        public DateTime update_dte { get; set; }
    }
}
