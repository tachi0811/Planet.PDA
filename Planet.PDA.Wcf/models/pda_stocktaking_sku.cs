using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class pda_stocktaking_sku
    {
        [DataMember]
        public string store_cd { get; set; }
        [DataMember]
        public int terminal_id { get; set; }
        [DataMember]
        public DateTime tana_item_timstamp { get; set; }
        [DataMember]
        public string staff_cd { get; set; }
        [DataMember]
        public Nullable<short> send_flg { get; set; }
        [DataMember]
        public Nullable<short> csv_output_flg { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
    }
}
