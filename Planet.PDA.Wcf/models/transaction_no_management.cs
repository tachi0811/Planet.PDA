using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class transaction_no_management
    {
        [DataMember]
        public string store_code { get; set; }
        [DataMember]
        public short terminal_no { get; set; }
        [DataMember]
        public Nullable<long> transaction_no { get; set; }
        [DataMember]
        public Nullable<DateTime> create_date { get; set; }
        [DataMember]
        public Nullable<DateTime> update_date { get; set; }
    }
}
