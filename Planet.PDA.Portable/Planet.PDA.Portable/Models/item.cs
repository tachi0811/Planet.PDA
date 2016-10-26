using System;

namespace Planet.PDA.Portable
{
    public class item
    {
        public string item_cd { get; set; }
        public string goods_cd { get; set; }
        public int seq { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
