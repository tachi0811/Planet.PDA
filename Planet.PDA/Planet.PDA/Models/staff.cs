using System;

namespace Planet.PDA
{
    public class staff
    {
        public string staff_cd { get; set; }
        public string staff_nm { get; set; }
        public string staff_kana_nm { get; set; }
        public string staff_password { get; set; }
        public Nullable<short> authority_kbn { get; set; }
        public short all_store_flg { get; set; }
        public Nullable<short> delete_flg { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
