using System;

namespace Planet.PDA
{
    public class shipping_rate
    {
        public string store_cd { get; set; }
        public string trader_cd { get; set; }
        public string area_cd { get; set; }
        public string pack_class_cd { get; set; }
        public Nullable<decimal> delivery_price { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
