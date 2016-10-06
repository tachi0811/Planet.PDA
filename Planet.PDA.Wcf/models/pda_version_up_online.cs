using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class pda_version_up_online
    {
        [DataMember]
        public short com_kbn { get; set; }
        [DataMember]
        public Nullable<DateTime> success_com_dtetim { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
    }
}
