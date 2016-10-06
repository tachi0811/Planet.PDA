using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class pda_pos
    {
        [DataMember]
        public string store_cd { get; set; }
        [DataMember]
        public int terminal_id { get; set; }
        [DataMember]
        public string sales_dte { get; set; }
        [DataMember]
        public int receipt_id { get; set; }
        [DataMember]
        public Nullable<short> receipt_kbn { get; set; }
        [DataMember]
        public Nullable<DateTime> sales_dtetim { get; set; }
        [DataMember]
        public Nullable<short> intax_flg { get; set; }
        [DataMember]
        public Nullable<decimal> tax_rate { get; set; }
        [DataMember]
        public string tax_fraction_process_kbn { get; set; }
        [DataMember]
        public string bits_pos_tax_cd { get; set; }
        [DataMember]
        public Nullable<int> total_detail_record_cnt { get; set; }
        [DataMember]
        public Nullable<int> sales_qty { get; set; }
        [DataMember]
        public Nullable<decimal> total_sales_amt { get; set; }
        [DataMember]
        public Nullable<int> sales_for_tax_qty { get; set; }
        [DataMember]
        public Nullable<decimal> total_sales_for_tax_amt { get; set; }
        [DataMember]
        public Nullable<int> sales_tax_free_qty { get; set; }
        [DataMember]
        public Nullable<decimal> total_sales_tax_free_amt { get; set; }
        [DataMember]
        public Nullable<decimal> discount_amt { get; set; }
        [DataMember]
        public Nullable<decimal> percent_discount_amt { get; set; }
        [DataMember]
        public Nullable<decimal> percent_discount_rate { get; set; }
        [DataMember]
        public Nullable<decimal> total_discount_amt { get; set; }
        [DataMember]
        public Nullable<decimal> total_dealing_amt { get; set; }
        [DataMember]
        public Nullable<decimal> total_tax_amt { get; set; }
        [DataMember]
        public Nullable<decimal> detail_discount_amt { get; set; }
        [DataMember]
        public Nullable<int> detail_discount_qty { get; set; }
        [DataMember]
        public Nullable<decimal> detail_percent_discount_amt { get; set; }
        [DataMember]
        public Nullable<int> detail_percent_discount_qty { get; set; }
        [DataMember]
        public Nullable<short> settlement_flg { get; set; }
        [DataMember]
        public Nullable<decimal> total_deposit_amt { get; set; }
        [DataMember]
        public Nullable<decimal> change_amt { get; set; }
        [DataMember]
        public Nullable<int> total_payment_record_cnt { get; set; }
        [DataMember]
        public Nullable<int> cancel_receipt_id { get; set; }
        [DataMember]
        public string trade_cd { get; set; }
        [DataMember]
        public string customer_base_cd { get; set; }
        [DataMember]
        public string staff_cd { get; set; }
        [DataMember]
        public Nullable<short> send_flg { get; set; }
        [DataMember]
        public Nullable<short> server_update_flg { get; set; }
        [DataMember]
        public Nullable<short> journal_update_flg { get; set; }
        [DataMember]
        public Nullable<short> error_flg { get; set; }
        [DataMember]
        public string customer_cd { get; set; }
    }
}
