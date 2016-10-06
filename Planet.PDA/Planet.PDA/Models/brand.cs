using System;

namespace Planet.PDA
{
    public class brand
    {
        public string brand_cd { get; set; }
        public string brand_nm { get; set; }
        public string brand_kana_nm { get; set; }
        public Nullable<short> delete_flg { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
