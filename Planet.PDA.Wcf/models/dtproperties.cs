using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class dtproperties
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public Nullable<int> objectid { get; set; }
        [DataMember]
        public string property { get; set; }
        [DataMember]
        public string value { get; set; }
        [DataMember]
        public string uvalue { get; set; }
        [DataMember]
        public byte[] lvalue { get; set; }
        [DataMember]
        public int version { get; set; }
    }
}
