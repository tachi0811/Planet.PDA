using System;

namespace Planet.PDA
{
    public class transfer_request
    {
        public string store_cd { get; set; }
        public string transfer_ask_no { get; set; }
        public DateTime transfer_dte { get; set; }
        public string goods_cd { get; set; }
        public string store_from_cd { get; set; }
        public string store_to_cd { get; set; }
        public string staff_from_cd { get; set; }
        public string staff_to_cd { get; set; }
        public Nullable<int> transfer_qty { get; set; }
        public Nullable<int> fix_qty { get; set; }
        public string orders_cd { get; set; }
        public string transfer_status { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
