using System;

namespace Planet.PDA
{
    public class stock_condition
    {
        public string stock_status { get; set; }
        public string stock_status_nm { get; set; }
        public Nullable<short> delivery_day { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
