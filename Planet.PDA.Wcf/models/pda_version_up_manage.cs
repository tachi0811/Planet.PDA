using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class pda_version_up_manage
    {
        [DataMember]
        public string file_nm { get; set; }
        [DataMember]
        public string file_version { get; set; }
        [DataMember]
        public string product_version { get; set; }
        [DataMember]
        public string format_file_version { get; set; }
        [DataMember]
        public string format_product_version { get; set; }
        [DataMember]
        public Nullable<int> file_size { get; set; }
        [DataMember]
        public Nullable<DateTime> file_last_write_dtetim { get; set; }
        [DataMember]
        public byte[] file_image { get; set; }
        [DataMember]
        public string sub_folder_path { get; set; }
        [DataMember]
        public Nullable<short> pda_execute_flg { get; set; }
        [DataMember]
        public Nullable<short> delete_flg { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
    }
}
