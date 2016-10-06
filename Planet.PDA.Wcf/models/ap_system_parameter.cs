using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class ap_system_parameter
    {
        [DataMember]
        public Nullable<short> multi_sales_price_use_flg { get; set; }
        [DataMember]
        public Nullable<int> hierarchy0_class_digit_nbr { get; set; }
        [DataMember]
        public Nullable<int> hierarchy1_class_digit_nbr { get; set; }
        [DataMember]
        public Nullable<int> hierarchy2_class_digit_nbr { get; set; }
        [DataMember]
        public Nullable<short> equal_ratio_flg { get; set; }
        [DataMember]
        public Nullable<short> taxable_item_equal_ratio_priority_flg { get; set; }
        [DataMember]
        public Nullable<short> tax_include_kbn { get; set; }
        [DataMember]
        public string discount_fraction_process_kbn { get; set; }
        [DataMember]
        public string bits_pos_tax_cd { get; set; }
        [DataMember]
        public Nullable<DateTime> create_date { get; set; }
        [DataMember]
        public Nullable<DateTime> update_date { get; set; }
    }
}
