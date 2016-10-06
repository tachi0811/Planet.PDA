using System;

namespace Planet.PDA
{
    public class store_staff
    {
        public string store_cd { get; set; }
        public string staff_cd { get; set; }
        public Nullable<short> delete_flg { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
