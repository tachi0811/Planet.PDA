using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class export_sales_payment
    {
        [DataMember]
        public string store_code { get; set; }
        [DataMember]
        public short terminal_no { get; set; }
        [DataMember]
        public long transaction_no { get; set; }
        [DataMember]
        public short line_no { get; set; }
        [DataMember]
        public string payment_code { get; set; }
        [DataMember]
        public string ticket_code { get; set; }
        [DataMember]
        public Nullable<decimal> deposit_amount { get; set; }
        [DataMember]
        public Nullable<decimal> amount { get; set; }
        [DataMember]
        public Nullable<decimal> ticket_no_change_amount { get; set; }
        [DataMember]
        public Nullable<decimal> ticket_change_amount { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public Nullable<DateTime> create_date { get; set; }
    }
}
