using System;

namespace Planet.PDA.Portable
{
    public class transfer_detail
    {
        public string store_cd { get; set; }
        public int terminal_id { get; set; }
        public DateTime transfer_dte { get; set; }
        public string goods_cd { get; set; }
        public Nullable<int> transport_qty { get; set; }
    }
}
