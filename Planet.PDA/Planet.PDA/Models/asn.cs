using System;

namespace Planet.PDA
{
    public class asn
    {
        public string store_cd { get; set; }
        public string goods_cd { get; set; }
        public DateTime asn_dte { get; set; }
        public short asn_kbn { get; set; }
        public Nullable<int> asn_qty { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
