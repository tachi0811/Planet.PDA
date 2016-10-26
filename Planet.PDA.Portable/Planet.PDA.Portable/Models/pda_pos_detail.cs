using System;

namespace Planet.PDA.Portable
{
    public class pda_pos_detail
    {
        public string store_cd { get; set; }
        public int terminal_id { get; set; }
        public string sales_dte { get; set; }
        public int receipt_id { get; set; }
        public int detail_no { get; set; }
        public Nullable<short> receipt_kbn { get; set; }
        public Nullable<short> intax_flg { get; set; }
        public string goods_cd { get; set; }
        public string goods_receipt_nm { get; set; }
        public Nullable<short> tax_flg { get; set; }
        public Nullable<decimal> before_discount_amt { get; set; }
        public string discount_flg { get; set; }
        public Nullable<decimal> discount_amt { get; set; }
        public Nullable<decimal> percent_discount_amt { get; set; }
        public Nullable<decimal> percent_discount_rate { get; set; }
        public Nullable<decimal> sales_amt { get; set; }
        public Nullable<int> sales_qty { get; set; }
        public Nullable<decimal> detail_sales_amt { get; set; }
        public string large_class_cd { get; set; }
        public string middle_class_cd { get; set; }
        public string small_class_cd { get; set; }
    }
}
