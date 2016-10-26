using System;

namespace Planet.PDA.Portable
{
    public class kbn_manage
    {
        public string kbn_manage_cd { get; set; }
        public string kbn_manage_nm { get; set; }
        public Nullable<short> display_order { get; set; }
        public Nullable<short> delete_flg { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
