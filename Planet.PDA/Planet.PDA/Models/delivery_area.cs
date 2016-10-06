using System;

namespace Planet.PDA
{
    public class delivery_area
    {
        public string store_cd { get; set; }
        public string trader_cd { get; set; }
        public string area_cd { get; set; }
        public string area_parent_cd { get; set; }
        public string area_layer { get; set; }
        public string area_nm { get; set; }
        public string area_kana_nm { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
