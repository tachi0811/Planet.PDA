using System;

namespace Planet.PDA.Portable
{
    public class delivery_trader
    {
        public string trader_cd { get; set; }
        public string trader_nm { get; set; }
        public string trader_kana_nm { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
