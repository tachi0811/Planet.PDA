using System;

namespace Planet.PDA.Portable
{
    public class purchase
    {
        public DateTime purchase_date { get; set; }
        public string purchase_slipnbr { get; set; }
        public string store_id { get; set; }
        public string tradekbn_cd { get; set; }
        public Nullable<DateTime> root_purchase_date { get; set; }
        public string root_purchase_slipnbr { get; set; }
        public string root_store_id { get; set; }
        public Nullable<DateTime> src_purchase_date { get; set; }
        public string src_purchase_slipnbr { get; set; }
        public string src_store_id { get; set; }
        public string staff_id { get; set; }
        public string purchase_slipkbn { get; set; }
        public Nullable<decimal> total_qty { get; set; }
        public Nullable<decimal> purchase_costtotal_amt { get; set; }
        public Nullable<decimal> purchase_pricetotal_amt { get; set; }
        public string purchase_sheet_nbr { get; set; }
        public string supplier_id { get; set; }
        public string cancel_flg { get; set; }
        public string invalid_flg { get; set; }
        public string notes { get; set; }
        public Nullable<DateTime> create_date { get; set; }
        public Nullable<DateTime> update_date { get; set; }
        public string update_staff { get; set; }
        public Nullable<DateTime> delivery_date { get; set; }
        public Nullable<DateTime> commission_close_account_date { get; set; }
        public Nullable<decimal> purchase_intax_costtotal_amt { get; set; }
        public Nullable<decimal> purchase_extax_costtotal_amt { get; set; }
        public Nullable<decimal> purchase_extax_cost_tax_amt { get; set; }
    }
}
