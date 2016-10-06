using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class pda_online
    {
        [DataMember]
        public int com_id { get; set; }
        [DataMember]
        public string com_info { get; set; }
        [DataMember]
        public Nullable<short> com_kbn { get; set; }
        [DataMember]
        public Nullable<DateTime> last_time_dtetim { get; set; }
        [DataMember]
        public Nullable<short> last_time_status_kbn { get; set; }
        [DataMember]
        public Nullable<DateTime> success_com_dtetim { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
    }
}
