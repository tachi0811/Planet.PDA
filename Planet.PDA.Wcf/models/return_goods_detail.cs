using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class return_goods_detail
    {
        [DataMember]
        public string store_cd { get; set; }
        [DataMember]
        public int terminal_id { get; set; }
        [DataMember]
        public DateTime return_dtetim { get; set; }
        [DataMember]
        public short seq_no { get; set; }
        [DataMember]
        public string goods_cd { get; set; }
        [DataMember]
        public int return_qty { get; set; }
        [DataMember]
        public DateTime create_dte { get; set; }
        [DataMember]
        public DateTime update_dte { get; set; }
    }
}
