using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class stock_condition
    {
        [DataMember]
        public string stock_status { get; set; }
        [DataMember]
        public string stock_status_nm { get; set; }
        [DataMember]
        public Nullable<short> delivery_day { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
    }
}
