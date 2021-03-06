using System;
using System.IO;
using SQLite.Net;
using SQLite.Net.Platform.XamarinAndroid;
using Planet.PDA.Portable.Droid;
using Planet.PDA.Portable;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_Android))]
namespace Planet.PDA.Portable.Droid
{
    public class SQLite_Android : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(new SQLitePlatformAndroid(), FilePath);
        }

        public string FilePath
        {
            get
            {
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "SQLite.db3");
            }
        }
    }
}