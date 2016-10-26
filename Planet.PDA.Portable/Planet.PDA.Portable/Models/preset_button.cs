using System;

namespace Planet.PDA.Portable
{
    public class preset_button
    {
        public string store_cd { get; set; }
        public string apply_business_cd { get; set; }
        public DateTime preset_apply_dte { get; set; }
        public int preset_page_id { get; set; }
        public int preset_button_column_id { get; set; }
        public int preset_button_row_id { get; set; }
        public string goods_cd { get; set; }
        public string item_display_nm { get; set; }
        public Nullable<int> item_display_line_bytes { get; set; }
        public Nullable<int> item_display_line_cnt { get; set; }
        public string button_back_color { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
