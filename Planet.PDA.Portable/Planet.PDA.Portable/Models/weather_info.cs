using System;

namespace Planet.PDA.Portable
{
    public class weather_info
    {
        public string store_cd { get; set; }
        public int terminal_id { get; set; }
        public DateTime open_dte { get; set; }
        public DateTime weather_dtetim { get; set; }
        public Nullable<short> weather_kbn { get; set; }
        public string open_kbn_manage_cd { get; set; }
        public string open_kbn_manage_detail_cd { get; set; }
        public string close_kbn_manage_cd { get; set; }
        public string close_kbn_manage_detail_cd { get; set; }
        public string staff_cd { get; set; }
        public Nullable<short> send_flg { get; set; }
        public Nullable<short> server_update_flg { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
        public Nullable<short> error_flg { get; set; }
    }
}
