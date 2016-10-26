using System;

namespace Planet.PDA.Portable
{
    public class store
    {
        public string store_cd { get; set; }
        public string store_nm { get; set; }
        public Nullable<short> intax_flg { get; set; }
        public Nullable<short> delete_flg { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
        public string store_message1 { get; set; }
        public string store_message2 { get; set; }
        public string store_message3 { get; set; }
        public string store_message4 { get; set; }
        public string store_message5 { get; set; }
    }
}
