using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class transfer
    {
        [DataMember]
        public string store_cd { get; set; }
        [DataMember]
        public int terminal_id { get; set; }
        [DataMember]
        public DateTime transfer_dte { get; set; }
        [DataMember]
        public Nullable<int> store_from_cd { get; set; }
        [DataMember]
        public Nullable<int> store_to_cd { get; set; }
        [DataMember]
        public string staff_cd { get; set; }
        [DataMember]
        public string kbn_manage_cd { get; set; }
        [DataMember]
        public string kbn_manage_detail_cd { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
    }
}
