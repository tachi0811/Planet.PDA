using System;

namespace Planet.PDA
{
    public class maker
    {
        public string maker_cd { get; set; }
        public string maker_nm { get; set; }
        public string maker_kana_nm { get; set; }
        public Nullable<short> delete_flg { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
