using System;
using System.IO;
using SQLite.Net;
using SQLite.Net.Platform.XamarinAndroid;
using XamarinApp.Droid;
using AppPDA;
using Xamarin.Forms;

[assembly : Dependency(typeof(SQLite_Android))]
namespace XamarinApp.Droid
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