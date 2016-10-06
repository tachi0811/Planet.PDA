using System;

namespace Planet.PDA
{
    public class kbn_manage_detail
    {
        public string kbn_manage_cd { get; set; }
        public string kbn_manage_detail_cd { get; set; }
        public string kbn_manage_detail_nm { get; set; }
        public Nullable<short> display_order { get; set; }
        public Nullable<short> delete_flg { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
