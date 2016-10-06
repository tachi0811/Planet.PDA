using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class inventory
    {
        [DataMember]
        public string store_cd { get; set; }
        [DataMember]
        public string goods_cd { get; set; }
        [DataMember]
        public Nullable<int> inventory_qty { get; set; }
        [DataMember]
        public Nullable<int> inventory_Mortgage_qty { get; set; }
        [DataMember]
        public Nullable<short> orders_constant { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
    }
}
