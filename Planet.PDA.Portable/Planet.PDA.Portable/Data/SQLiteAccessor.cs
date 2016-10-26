using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net;
using Xamarin.Forms;
using System.Reflection;

namespace Planet.PDA.Portable
{
    public class SQLiteAccessor
    {
        static readonly object Locker = new object();
        readonly SQLiteConnection DB;

        public void BeginTransaction()
        {
            lock (Locker)
            {
                DB.BeginTransaction();
            }
        }

        public void Rollback()
        {
            lock (Locker)
            {
                DB.Rollback();
            }
        }

        public void Commit()
        {
            lock (Locker)
            {
                DB.Commit();
            }
        }

        public SQLiteAccessor()
        {
            DB = DependencyService.Get<ISQLite>().GetConnection();
        }

        public void CreateTable<T>()
            where T : class
        {
            DB.CreateTable<T>();
        }

        public IEnumerable<T> GetTable<T>()
            where T : class
        {
            lock(Locker)
            {
                return DB.Query<T>("select * from " + typeof(T).Name);
            }
        }

        /// <summary>
        /// 直接SQLを実行してテーブルを取得する
        /// </summary>
        /// <typeparam name="T">クラス</typeparam>
        /// <param name="sql"></param>
        /// <returns></returns>
        public IEnumerable<T> GetData<T>(string sql)
            where T : class
        {
            lock (Locker)
            {
                return DB.Query<T>(sql);
            }
        }

        /// <summary>
        /// 更新処理
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public int Update<T>(T data)
            where T : class
        {
            lock(Locker)
            {
                return DB.Update(data, typeof(T));
            }
        }

        /// <summary>
        /// 登録処理
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public int Insert<T>(T data)
            where T : class
        {
            lock(Locker)
            {
                return DB.Insert(data, typeof(T));
            }
        }

        public int Trancate<T>()
            where T : class
        {
            lock (Locker)
            {
                return DB.DeleteAll<T>();
            }
        }

        /// <summary>
        /// テーブル登録
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataList"></param>
        /// <returns></returns>
        public int InsertAll<T>(IEnumerable<T> dataList)
            where T : class
        {
            lock (Locker)
            {
                int i = 0;

                try
                {
                    DB.BeginTransaction(); // SQLiteは、トランザクションを入れないと遅すぎるので注意

                    DB.DeleteAll<T>();
                    
                    foreach (var data in dataList)
                    {
                        i += Insert<T>(data);
                    }

                    DB.Commit();

                }
                catch
                {
                    DB.Rollback();
                }
                return i;
            }
        }

       
    }
}
