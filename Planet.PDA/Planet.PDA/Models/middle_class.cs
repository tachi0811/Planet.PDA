using System;

namespace Planet.PDA
{
    public class middle_class
    {
        public string middle_class_cd { get; set; }
        public string large_class_cd { get; set; }
        public string middle_class_nm { get; set; }
        public string middle_class_kana_nm { get; set; }
        public Nullable<short> tax_kbn { get; set; }
        public Nullable<short> discount_flg { get; set; }
        public Nullable<short> return_flg { get; set; }
        public Nullable<short> delete_flg { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
