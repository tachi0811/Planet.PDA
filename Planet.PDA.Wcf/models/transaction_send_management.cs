using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class transaction_send_management
    {
        [DataMember]
        public string store_code { get; set; }
        [DataMember]
        public short terminal_no { get; set; }
        [DataMember]
        public long transaction_no { get; set; }
        [DataMember]
        public Nullable<short> transaction_type { get; set; }
        [DataMember]
        public Nullable<short> send_flg { get; set; }
        [DataMember]
        public Nullable<short> error_flg { get; set; }
        [DataMember]
        public Nullable<DateTime> create_date { get; set; }
        [DataMember]
        public Nullable<DateTime> update_date { get; set; }
        [DataMember]
        public string src_store_code { get; set; }
    }
}
