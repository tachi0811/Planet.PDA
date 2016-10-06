using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class readings
    {
        [DataMember]
        public DateTime readingDate { get; set; }
        [DataMember]
        public string city { get; set; }
        [DataMember]
        public Nullable<float> HiTemp_Far { get; set; }
        [DataMember]
        public Nullable<float> HiTemp_Cen { get; set; }
    }
}
