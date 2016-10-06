using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class goods
    {
        [DataMember]
        public string goods_cd { get; set; }
        [DataMember]
        public string large_class_cd { get; set; }
        [DataMember]
        public string middle_class_cd { get; set; }
        [DataMember]
        public string small_class_cd { get; set; }
        [DataMember]
        public string maker_cd { get; set; }
        [DataMember]
        public string brand_cd { get; set; }
        [DataMember]
        public string supplier_cd { get; set; }
        [DataMember]
        public string goods_nm { get; set; }
        [DataMember]
        public string goods_kana_nm { get; set; }
        [DataMember]
        public string goods_receipt_nm { get; set; }
        [DataMember]
        public string pn_cd { get; set; }
        [DataMember]
        public Nullable<short> tax_kbn { get; set; }
        [DataMember]
        public Nullable<short> tax_include_kbn { get; set; }
        [DataMember]
        public Nullable<short> discount_flg { get; set; }
        [DataMember]
        public Nullable<decimal> cost_price { get; set; }
        [DataMember]
        public Nullable<decimal> sales_price { get; set; }
        [DataMember]
        public Nullable<int> inventory_reach_point { get; set; }
        [DataMember]
        public string unit { get; set; }
        [DataMember]
        public Nullable<short> inventory_manage_flg { get; set; }
        [DataMember]
        public string goods_info { get; set; }
        [DataMember]
        public Nullable<short> return_flg { get; set; }
        [DataMember]
        public Nullable<short> delete_flg { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
    }
}
