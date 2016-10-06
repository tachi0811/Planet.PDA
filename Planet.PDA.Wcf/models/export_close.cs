using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class export_close
    {
        [DataMember]
        public string store_code { get; set; }
        [DataMember]
        public short terminal_no { get; set; }
        [DataMember]
        public long transaction_no { get; set; }
        [DataMember]
        public Nullable<DateTime> system_date_time { get; set; }
        [DataMember]
        public Nullable<DateTime> business_date { get; set; }
        [DataMember]
        public Nullable<long> receipt_no { get; set; }
        [DataMember]
        public string operator_code { get; set; }
        [DataMember]
        public string operator_name { get; set; }
        [DataMember]
        public Nullable<DateTime> create_date { get; set; }
    }
}
