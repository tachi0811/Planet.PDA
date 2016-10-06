using System;

namespace Planet.PDA
{
    public class pda_online
    {
        public int com_id { get; set; }
        public string com_info { get; set; }
        public Nullable<short> com_kbn { get; set; }
        public Nullable<DateTime> last_time_dtetim { get; set; }
        public Nullable<short> last_time_status_kbn { get; set; }
        public Nullable<DateTime> success_com_dtetim { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
