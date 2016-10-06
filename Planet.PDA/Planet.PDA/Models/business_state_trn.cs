using System;

namespace Planet.PDA
{
    public class business_state_trn
    {
        public string store_cd { get; set; }
        public int terminal_id { get; set; }
        public DateTime open_dte { get; set; }
        public short transaction_type { get; set; }
        public DateTime business_dtetim { get; set; }
        public string staff_cd { get; set; }
        public Nullable<short> send_flg { get; set; }
        public Nullable<short> error_flg { get; set; }
    }
}
