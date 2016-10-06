using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class pda_pos_detail
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
        public int detail_no { get; set; }
        [DataMember]
        public Nullable<short> receipt_kbn { get; set; }
        [DataMember]
        public Nullable<short> intax_flg { get; set; }
        [DataMember]
        public string goods_cd { get; set; }
        [DataMember]
        public string goods_receipt_nm { get; set; }
        [DataMember]
        public Nullable<short> tax_flg { get; set; }
        [DataMember]
        public Nullable<decimal> before_discount_amt { get; set; }
        [DataMember]
        public string discount_flg { get; set; }
        [DataMember]
        public Nullable<decimal> discount_amt { get; set; }
        [DataMember]
        public Nullable<decimal> percent_discount_amt { get; set; }
        [DataMember]
        public Nullable<decimal> percent_discount_rate { get; set; }
        [DataMember]
        public Nullable<decimal> sales_amt { get; set; }
        [DataMember]
        public Nullable<int> sales_qty { get; set; }
        [DataMember]
        public Nullable<decimal> detail_sales_amt { get; set; }
        [DataMember]
        public string large_class_cd { get; set; }
        [DataMember]
        public string middle_class_cd { get; set; }
        [DataMember]
        public string small_class_cd { get; set; }
    }
}
