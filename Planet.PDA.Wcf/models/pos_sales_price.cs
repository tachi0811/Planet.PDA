using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class pos_sales_price
    {
        [DataMember]
        public short pos_sales_price_cd { get; set; }
        [DataMember]
        public string user_l_name { get; set; }
        [DataMember]
        public Nullable<DateTime> create_date { get; set; }
        [DataMember]
        public Nullable<DateTime> update_date { get; set; }
    }
}
