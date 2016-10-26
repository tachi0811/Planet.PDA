using System;

namespace Planet.PDA.Portable
{
    public class trade
    {
        public string trade_cd { get; set; }
        public string trade_nm { get; set; }
        public string trade_kana_nm { get; set; }
        public Nullable<short> delete_flg { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
