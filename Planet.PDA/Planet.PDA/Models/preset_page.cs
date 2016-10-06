using System;

namespace Planet.PDA
{
    public class preset_page
    {
        public string store_cd { get; set; }
        public string apply_business_cd { get; set; }
        public DateTime preset_apply_dte { get; set; }
        public int preset_page_id { get; set; }
        public string preset_page_nm { get; set; }
        public Nullable<int> preset_button_column_cnt { get; set; }
        public Nullable<int> preset_button_row_cnt { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
