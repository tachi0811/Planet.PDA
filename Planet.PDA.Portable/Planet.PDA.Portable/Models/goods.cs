using System;

namespace Planet.PDA.Portable
{
    public class goods
    {
        public string goods_cd { get; set; }
        public string large_class_cd { get; set; }
        public string middle_class_cd { get; set; }
        public string small_class_cd { get; set; }
        public string maker_cd { get; set; }
        public string brand_cd { get; set; }
        public string supplier_cd { get; set; }
        public string goods_nm { get; set; }
        public string goods_kana_nm { get; set; }
        public string goods_receipt_nm { get; set; }
        public string pn_cd { get; set; }
        public Nullable<short> tax_kbn { get; set; }
        public Nullable<short> tax_include_kbn { get; set; }
        public Nullable<short> discount_flg { get; set; }
        public Nullable<decimal> cost_price { get; set; }
        public Nullable<decimal> sales_price { get; set; }
        public Nullable<int> inventory_reach_point { get; set; }
        public string unit { get; set; }
        public Nullable<short> inventory_manage_flg { get; set; }
        public string goods_info { get; set; }
        public Nullable<short> return_flg { get; set; }
        public Nullable<short> delete_flg { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
