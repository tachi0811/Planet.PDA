using System;

namespace Planet.PDA.Portable
{
    public class goods_attribute
    {
        public string goods_cd { get; set; }
        public string color_nm { get; set; }
        public string size_nm { get; set; }
        public string picture_file_nm { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
