using SQLite.Net;
using System;
using System.IO;
using Xamarin.Forms;
using AppPDA.iOS;
using AppPDA;
using XamarinApp.iOS;

[assembly: Dependency(typeof(SQLite_iOS))]
namespace XamarinApp.iOS
{
    public class SQLite_iOS : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS(), FilePath);
        }

        public string FilePath
        {
            get
            {
                return Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "..", "Library"), "SQLite.db3");
            }
        }
    }
}