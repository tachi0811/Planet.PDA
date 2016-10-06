using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class instore_management
    {
        [DataMember]
        public string instore_cd_prefix { get; set; }
        [DataMember]
        public Nullable<int> prefix_digit_nbr { get; set; }
        [DataMember]
        public string instore_management_kbn { get; set; }
        [DataMember]
        public string use_flg { get; set; }
        [DataMember]
        public string auto_nbr_flg { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
        [DataMember]
        public string update_staff { get; set; }
    }
}
