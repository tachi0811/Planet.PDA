using System;

namespace Planet.PDA.Portable
{
    public class bits_pos_tax
    {
        public string bits_pos_tax_cd { get; set; }
        public string tax_kbn { get; set; }
        public Nullable<float> tax_rate { get; set; }
        public string tax_fraction_process_kbn { get; set; }
        public string tax_fraction_process_unit { get; set; }
        public Nullable<DateTime> create_date { get; set; }
        public Nullable<DateTime> update_date { get; set; }
    }
}
