using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class pack_class
    {
        [DataMember]
        public string pack_class_cd { get; set; }
        [DataMember]
        public string pack_weight_cd { get; set; }
        [DataMember]
        public string pack_size_cd { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
    }
}
