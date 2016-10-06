using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class Service_Chk
    {
        [DataMember]
        public string company_cd { get; set; }
        [DataMember]
        public string store_cd { get; set; }
        [DataMember]
        public string terminal_id { get; set; }
        [DataMember]
        public Nullable<short> confirm_interval { get; set; }
        [DataMember]
        public Nullable<DateTime> confirm_dte { get; set; }
        [DataMember]
        public Nullable<short> service_kbn { get; set; }
        [DataMember]
        public Nullable<short> service_1 { get; set; }
        [DataMember]
        public Nullable<short> service_2 { get; set; }
        [DataMember]
        public Nullable<short> service_3 { get; set; }
        [DataMember]
        public Nullable<short> service_4 { get; set; }
        [DataMember]
        public Nullable<short> service_5 { get; set; }
        [DataMember]
        public Nullable<short> service_6 { get; set; }
        [DataMember]
        public Nullable<short> service_7 { get; set; }
        [DataMember]
        public Nullable<short> service_8 { get; set; }
        [DataMember]
        public Nullable<short> service_9 { get; set; }
        [DataMember]
        public Nullable<short> service_10 { get; set; }
        [DataMember]
        public Nullable<short> service_11 { get; set; }
        [DataMember]
        public Nullable<short> service_12 { get; set; }
        [DataMember]
        public Nullable<short> service_13 { get; set; }
        [DataMember]
        public Nullable<short> service_14 { get; set; }
        [DataMember]
        public Nullable<short> service_15 { get; set; }
        [DataMember]
        public Nullable<short> service_16 { get; set; }
        [DataMember]
        public Nullable<short> service_17 { get; set; }
        [DataMember]
        public Nullable<short> service_18 { get; set; }
        [DataMember]
        public Nullable<short> service_19 { get; set; }
        [DataMember]
        public Nullable<short> service_20 { get; set; }
        [DataMember]
        public Nullable<short> delete_flg { get; set; }
        [DataMember]
        public Nullable<DateTime> Create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> Update_dte { get; set; }
    }
}
