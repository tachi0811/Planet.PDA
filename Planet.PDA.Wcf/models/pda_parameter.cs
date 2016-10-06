using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class pda_parameter
    {
        [DataMember]
        public string store_cd { get; set; }
        [DataMember]
        public string store_nm { get; set; }
        [DataMember]
        public string store_address1 { get; set; }
        [DataMember]
        public string store_address2 { get; set; }
        [DataMember]
        public string store_tel { get; set; }
        [DataMember]
        public Nullable<int> terminal_id { get; set; }
        [DataMember]
        public string license_key { get; set; }
        [DataMember]
        public Nullable<short> staff_request_flg { get; set; }
        [DataMember]
        public Nullable<short> use_printer_flg { get; set; }
        [DataMember]
        public Nullable<short> receipt_hand_operate_flg { get; set; }
        [DataMember]
        public Nullable<short> receipt_staff_kbn { get; set; }
        [DataMember]
        public Nullable<short> receipt_tax_flg { get; set; }
        [DataMember]
        public Nullable<short> receipt_cm_printing_flg { get; set; }
        [DataMember]
        public Nullable<short> report_intax_flg { get; set; }
        [DataMember]
        public Nullable<short> return_goods_flg { get; set; }
        [DataMember]
        public Nullable<short> discount_flg { get; set; }
        [DataMember]
        public Nullable<short> cancel_flg { get; set; }
        [DataMember]
        public Nullable<short> opening_sync_flg { get; set; }
        [DataMember]
        public Nullable<short> closing_sync_flg { get; set; }
        [DataMember]
        public Nullable<short> customer_id_flg { get; set; }
        [DataMember]
        public Nullable<short> customer_base_cd_flg { get; set; }
        [DataMember]
        public Nullable<short> intax_flg { get; set; }
        [DataMember]
        public Nullable<decimal> tax_rate { get; set; }
        [DataMember]
        public Nullable<short> fraction_kbn { get; set; }
        [DataMember]
        public Nullable<int> system_version { get; set; }
        [DataMember]
        public Nullable<short> weather_info_display_flg { get; set; }
        [DataMember]
        public Nullable<short> creditsales_flg { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
    }
}
