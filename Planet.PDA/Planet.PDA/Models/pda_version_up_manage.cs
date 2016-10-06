using System;

namespace Planet.PDA
{
    public class pda_version_up_manage
    {
        public string file_nm { get; set; }
        public string file_version { get; set; }
        public string product_version { get; set; }
        public string format_file_version { get; set; }
        public string format_product_version { get; set; }
        public Nullable<int> file_size { get; set; }
        public Nullable<DateTime> file_last_write_dtetim { get; set; }
        public byte[] file_image { get; set; }
        public string sub_folder_path { get; set; }
        public Nullable<short> pda_execute_flg { get; set; }
        public Nullable<short> delete_flg { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
