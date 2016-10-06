using System;

namespace Planet.PDA
{
    public class cust_voice_detail
    {
        public string store_cd { get; set; }
        public string staff_cd { get; set; }
        public string cust_voice_class_cd { get; set; }
        public DateTime send_dte { get; set; }
        public string kbn_manage_cd { get; set; }
        public string kbn_manage_detail_cd { get; set; }
        public string cust_voice_class_nm { get; set; }
        public string kbn_manage_nm { get; set; }
        public string kbn_manage_detail_nm { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
