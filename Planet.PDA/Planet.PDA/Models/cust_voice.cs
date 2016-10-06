using System;

namespace Planet.PDA
{
    public class cust_voice
    {
        public string store_cd { get; set; }
        public string staff_cd { get; set; }
        public string cust_voice_class_cd { get; set; }
        public DateTime send_dte { get; set; }
        public string goods_cd { get; set; }
        public string itemfeatur_notes { get; set; }
        public string request_notes { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
