using System;

namespace Planet.PDA
{
    public class pda_receipt_cm
    {
        public string store_cd { get; set; }
        public string receipt_cm_message_1 { get; set; }
        public string receipt_cm_message_2 { get; set; }
        public string receipt_cm_message_3 { get; set; }
        public string receipt_cm_message_4 { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
