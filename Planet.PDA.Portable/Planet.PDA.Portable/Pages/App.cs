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
           
        }

        protected override async void OnStart()
        {
            base.OnStart();

            MainPage = new ContentPage()
            {
                Content = new ActivityIndicator()
                {
                    Color = Device.OnPlatform(Color.Black, Color.Default, Color.Default),
                    IsRunning = true,
                    VerticalOptions = LayoutOptions.CenterAndExpand
                }
            };

            // マスタデータの受信
            await Common.InsertMasterData<staff>();

            // MainPage = new InitPage();
            MainPage = new NavigationPage(new MenuPage());

        }
    }
}
