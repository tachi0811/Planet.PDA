using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class preset_page
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
        public string preset_page_nm { get; set; }
        [DataMember]
        public Nullable<int> preset_button_column_cnt { get; set; }
        [DataMember]
        public Nullable<int> preset_button_row_cnt { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
    }
}
