using System;

namespace Planet.PDA
{
    public class delivery_service
    {
        public string store_cd { get; set; }
        public string trader_cd { get; set; }
        public string delivery_service_cd { get; set; }
        public string delivery_service_nm { get; set; }
        public Nullable<decimal> add_price { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
