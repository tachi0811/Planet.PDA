using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class inspection
    {
        [DataMember]
        public string store_cd { get; set; }
        [DataMember]
        public int terminal_id { get; set; }
        [DataMember]
        public DateTime inspection_dtetim { get; set; }
        [DataMember]
        public string staff_cd { get; set; }
        [DataMember]
        public short send_flg { get; set; }
        [DataMember]
        public short server_update_flg { get; set; }
        [DataMember]
        public DateTime create_dte { get; set; }
        [DataMember]
        public DateTime update_dte { get; set; }
    }
}
