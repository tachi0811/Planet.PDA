using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class waste_detail
    {
        [DataMember]
        public string store_cd { get; set; }
        [DataMember]
        public int terminal_id { get; set; }
        [DataMember]
        public DateTime waste_dtetim { get; set; }
        [DataMember]
        public short seq_no { get; set; }
        [DataMember]
        public string goods_cd { get; set; }
        [DataMember]
        public int waste_qty { get; set; }
        [DataMember]
        public string kbn_manage_cd { get; set; }
        [DataMember]
        public string kbn_manage_detail_cd { get; set; }
        [DataMember]
        public DateTime create_dte { get; set; }
        [DataMember]
        public DateTime update_dte { get; set; }
    }
}
