using System;

namespace Planet.PDA.Portable
{
    public class inspection_detail
    {
        public string store_cd { get; set; }
        public int terminal_id { get; set; }
        public DateTime inspection_dtetim { get; set; }
        public short seq_no { get; set; }
        public string goods_cd { get; set; }
        public int inspection_qty { get; set; }
        public DateTime create_dte { get; set; }
        public DateTime update_dte { get; set; }
    }
}
