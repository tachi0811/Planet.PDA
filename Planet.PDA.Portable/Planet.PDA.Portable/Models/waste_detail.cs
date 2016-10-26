using System;

namespace Planet.PDA.Portable
{
    public class waste_detail
    {
        public string store_cd { get; set; }
        public int terminal_id { get; set; }
        public DateTime waste_dtetim { get; set; }
        public short seq_no { get; set; }
        public string goods_cd { get; set; }
        public int waste_qty { get; set; }
        public string kbn_manage_cd { get; set; }
        public string kbn_manage_detail_cd { get; set; }
        public DateTime create_dte { get; set; }
        public DateTime update_dte { get; set; }
    }
}
