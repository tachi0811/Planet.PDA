using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Planet.PDA.Portable
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new MenuPage());
        }
    }
}
