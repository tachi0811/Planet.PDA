using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class preset_button
    {
        [DataMember]
        public string store_cd { get; set; }
        [DataMember]
        public string apply_business_cd { get; set; }
        [DataMember]
        public DateTime preset_apply_dte { get; set; }
        [DataMember]
        public int preset_page_id { get; set; }
        [DataMember]
        public int preset_button_column_id { get; set; }
        [DataMember]
        public int preset_button_row_id { get; set; }
        [DataMember]
        public string goods_cd { get; set; }
        [DataMember]
        public string item_display_nm { get; set; }
        [DataMember]
        public Nullable<int> item_display_line_bytes { get; set; }
        [DataMember]
        public Nullable<int> item_display_line_cnt { get; set; }
        [DataMember]
        public string button_back_color { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
    }
}
