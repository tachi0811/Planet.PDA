using System;

namespace Planet.PDA.Portable
{
    public class instore_management
    {
        public string instore_cd_prefix { get; set; }
        public Nullable<int> prefix_digit_nbr { get; set; }
        public string instore_management_kbn { get; set; }
        public string use_flg { get; set; }
        public string auto_nbr_flg { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
        public string update_staff { get; set; }
    }
}
