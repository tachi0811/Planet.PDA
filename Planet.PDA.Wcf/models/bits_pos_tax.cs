using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class bits_pos_tax
    {
        [DataMember]
        public string bits_pos_tax_cd { get; set; }
        [DataMember]
        public string tax_kbn { get; set; }
        [DataMember]
        public Nullable<float> tax_rate { get; set; }
        [DataMember]
        public string tax_fraction_process_kbn { get; set; }
        [DataMember]
        public string tax_fraction_process_unit { get; set; }
        [DataMember]
        public Nullable<DateTime> create_date { get; set; }
        [DataMember]
        public Nullable<DateTime> update_date { get; set; }
    }
}
