using System;

namespace Planet.PDA.Portable
{
    public class dtproperties
    {
        public int id { get; set; }
        public Nullable<int> objectid { get; set; }
        public string property { get; set; }
        public string value { get; set; }
        public string uvalue { get; set; }
        public byte[] lvalue { get; set; }
        public int version { get; set; }
    }
}
