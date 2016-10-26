using System;

namespace Planet.PDA.Portable
{
    public class inspection_asn
    {
        public string slip_no { get; set; }
        public short seq_no { get; set; }
        public string goods_cd { get; set; }
        public Nullable<int> expected_qty { get; set; }
        public string store_cd { get; set; }
    }
}
