using System;

namespace Planet.PDA
{
    public class pda_pos
    {
        public string store_cd { get; set; }
        public int terminal_id { get; set; }
        public string sales_dte { get; set; }
        public int receipt_id { get; set; }
        public Nullable<short> receipt_kbn { get; set; }
        public Nullable<DateTime> sales_dtetim { get; set; }
        public Nullable<short> intax_flg { get; set; }
        public Nullable<decimal> tax_rate { get; set; }
        public string tax_fraction_process_kbn { get; set; }
        public string bits_pos_tax_cd { get; set; }
        public Nullable<int> total_detail_record_cnt { get; set; }
        public Nullable<int> sales_qty { get; set; }
        public Nullable<decimal> total_sales_amt { get; set; }
        public Nullable<int> sales_for_tax_qty { get; set; }
        public Nullable<decimal> total_sales_for_tax_amt { get; set; }
        public Nullable<int> sales_tax_free_qty { get; set; }
        public Nullable<decimal> total_sales_tax_free_amt { get; set; }
        public Nullable<decimal> discount_amt { get; set; }
        public Nullable<decimal> percent_discount_amt { get; set; }
        public Nullable<decimal> percent_discount_rate { get; set; }
        public Nullable<decimal> total_discount_amt { get; set; }
        public Nullable<decimal> total_dealing_amt { get; set; }
        public Nullable<decimal> total_tax_amt { get; set; }
        public Nullable<decimal> detail_discount_amt { get; set; }
        public Nullable<int> detail_discount_qty { get; set; }
        public Nullable<decimal> detail_percent_discount_amt { get; set; }
        public Nullable<int> detail_percent_discount_qty { get; set; }
        public Nullable<short> settlement_flg { get; set; }
        public Nullable<decimal> total_deposit_amt { get; set; }
        public Nullable<decimal> change_amt { get; set; }
        public Nullable<int> total_payment_record_cnt { get; set; }
        public Nullable<int> cancel_receipt_id { get; set; }
        public string trade_cd { get; set; }
        public string customer_base_cd { get; set; }
        public string staff_cd { get; set; }
        public Nullable<short> send_flg { get; set; }
        public Nullable<short> server_update_flg { get; set; }
        public Nullable<short> journal_update_flg { get; set; }
        public Nullable<short> error_flg { get; set; }
        public string customer_cd { get; set; }
    }
}
