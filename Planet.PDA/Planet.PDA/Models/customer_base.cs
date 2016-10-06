using System;

namespace Planet.PDA
{
    public class customer_base
    {
        public string customer_base_cd { get; set; }
        public string customer_base_nm { get; set; }
        public Nullable<short> delete_flg { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
        public Nullable<short> default_flg { get; set; }
    }
}
