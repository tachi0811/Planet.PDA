using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class readings0
    {
        [DataMember]
        public DateTime ReadingDate { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public Nullable<float> HiTemp_Far { get; set; }
    }
}
