using System;

namespace Planet.PDA.Portable
{
    public class readings
    {
        public DateTime readingDate { get; set; }
        public string city { get; set; }
        public Nullable<float> HiTemp_Far { get; set; }
        public Nullable<float> HiTemp_Cen { get; set; }
    }
}
