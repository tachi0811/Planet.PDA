using System;

namespace Planet.PDA.Portable
{
    public class pda_parameter
    {
        public string store_cd { get; set; }
        public string store_nm { get; set; }
        public string store_address1 { get; set; }
        public string store_address2 { get; set; }
        public string store_tel { get; set; }
        public Nullable<int> terminal_id { get; set; }
        public string license_key { get; set; }
        public Nullable<short> staff_request_flg { get; set; }
        public Nullable<short> use_printer_flg { get; set; }
        public Nullable<short> receipt_hand_operate_flg { get; set; }
        public Nullable<short> receipt_staff_kbn { get; set; }
        public Nullable<short> receipt_tax_flg { get; set; }
        public Nullable<short> receipt_cm_printing_flg { get; set; }
        public Nullable<short> report_intax_flg { get; set; }
        public Nullable<short> return_goods_flg { get; set; }
        public Nullable<short> discount_flg { get; set; }
        public Nullable<short> cancel_flg { get; set; }
        public Nullable<short> opening_sync_flg { get; set; }
        public Nullable<short> closing_sync_flg { get; set; }
        public Nullable<short> customer_id_flg { get; set; }
        public Nullable<short> customer_base_cd_flg { get; set; }
        public Nullable<short> intax_flg { get; set; }
        public Nullable<decimal> tax_rate { get; set; }
        public Nullable<short> fraction_kbn { get; set; }
        public Nullable<int> system_version { get; set; }
        public Nullable<short> weather_info_display_flg { get; set; }
        public Nullable<short> creditsales_flg { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
