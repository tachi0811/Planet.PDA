using System;

namespace Planet.PDA
{
    public class transfer
    {
        public string store_cd { get; set; }
        public int terminal_id { get; set; }
        public DateTime transfer_dte { get; set; }
        public Nullable<int> store_from_cd { get; set; }
        public Nullable<int> store_to_cd { get; set; }
        public string staff_cd { get; set; }
        public string kbn_manage_cd { get; set; }
        public string kbn_manage_detail_cd { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
