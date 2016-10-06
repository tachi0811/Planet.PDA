using System;

namespace Planet.PDA
{
    public class supplier
    {
        public string supplier_cd { get; set; }
        public string supplier_nm { get; set; }
        public string supplier_kana_nm { get; set; }
        public Nullable<short> delete_flg { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
