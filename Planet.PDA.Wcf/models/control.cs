using System;
using System.Runtime.Serialization;

namespace Planet.PDA.Wcf
{
    [DataContract]
    public class control
    {
        [DataMember]
        public string control_key { get; set; }
        [DataMember]
        public Nullable<int> num_1 { get; set; }
        [DataMember]
        public Nullable<int> num_2 { get; set; }
        [DataMember]
        public Nullable<int> num_3 { get; set; }
        [DataMember]
        public Nullable<int> num_4 { get; set; }
        [DataMember]
        public Nullable<int> num_5 { get; set; }
        [DataMember]
        public Nullable<int> num_6 { get; set; }
        [DataMember]
        public Nullable<int> num_7 { get; set; }
        [DataMember]
        public string txt_1 { get; set; }
        [DataMember]
        public string txt_2 { get; set; }
        [DataMember]
        public string txt_3 { get; set; }
        [DataMember]
        public string txt_4 { get; set; }
        [DataMember]
        public Nullable<DateTime> create_dte { get; set; }
        [DataMember]
        public Nullable<DateTime> update_dte { get; set; }
    }
}
