using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace Planet.PDA.Portable
{
    /// <summary>
    ///
    /// </summary>
    public class App : Application
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public App()
        {
            // メニューページを表示
            MainPage = new NavigationPage(new MenuPage());
        }
    }
}
