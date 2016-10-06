using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class purchase
    {
        [DataMember]
        public DateTime purchase_date { get; set; }
        [DataMember]
        public string purchase_slipnbr { get; set; }
        [DataMember]
        public string store_id { get; set; }
        [DataMember]
        public string tradekbn_cd { get; set; }
        [DataMember]
        public Nullable<DateTime> root_purchase_date { get; set; }
        [DataMember]
        public string root_purchase_slipnbr { get; set; }
        [DataMember]
        public string root_store_id { get; set; }
        [DataMember]
        public Nullable<DateTime> src_purchase_date { get; set; }
        [DataMember]
        public string src_purchase_slipnbr { get; set; }
        [DataMember]
        public string src_store_id { get; set; }
        [DataMember]
        public string staff_id { get; set; }
        [DataMember]
        public string purchase_slipkbn { get; set; }
        [DataMember]
        public Nullable<decimal> total_qty { get; set; }
        [DataMember]
        public Nullable<decimal> purchase_costtotal_amt { get; set; }
        [DataMember]
        public Nullable<decimal> purchase_pricetotal_amt { get; set; }
        [DataMember]
        public string purchase_sheet_nbr { get; set; }
        [DataMember]
        public string supplier_id { get; set; }
        [DataMember]
        public string cancel_flg { get; set; }
        [DataMember]
        public string invalid_flg { get; set; }
        [DataMember]
        public string notes { get; set; }
        [DataMember]
        public Nullable<DateTime> create_date { get; set; }
        [DataMember]
        public Nullable<DateTime> update_date { get; set; }
        [DataMember]
        public string update_staff { get; set; }
        [DataMember]
        public Nullable<DateTime> delivery_date { get; set; }
        [DataMember]
        public Nullable<DateTime> commission_close_account_date { get; set; }
        [DataMember]
        public Nullable<decimal> purchase_intax_costtotal_amt { get; set; }
        [DataMember]
        public Nullable<decimal> purchase_extax_costtotal_amt { get; set; }
        [DataMember]
        public Nullable<decimal> purchase_extax_cost_tax_amt { get; set; }
    }
}
