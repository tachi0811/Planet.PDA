using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class weather_info
    {
        [DataMember]
        public string store_cd { get; set; }
        [DataMember]
        public int terminal_id { get; set; }
        [DataMember]
        public DateTime open_dte { get; set; }
        [DataMember]
        public DateTime weather_dtetim { get; set; }
        [DataMember]
        public Nullable<short> weather_kbn { get; set; }
        [DataMember]
        public string open_kbn_manage_cd { get; set; }
        [DataMember]
        public string open_kbn_manage_detail_cd { get; set; }
        [DataMember]
        public string close_kbn_manage_cd { get; set; }
        [DataMember]
        public string close_kbn_manage_detail_cd { get; set; }
        [DataMember]
        public string staff_cd { get; set; }
        [DataMember]
        public Nullable<short> send_flg { get; set; }
        [DataMember]
        public Nullable<short> server_update_flg { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
        [DataMember]
        public Nullable<short> error_flg { get; set; }
    }
}
