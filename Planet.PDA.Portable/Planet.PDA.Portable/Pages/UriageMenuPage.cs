using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Planet.PDA.Portable
{
    /// <summary>
    /// 売上メニューページ
    /// </summary>
    public class UriageMenuPage : ContentPage
    {
        public UriageMenuPage()
        {

            NavigationPage.SetHasNavigationBar(this, false);

            Title = "売上メニュー";

            var layout = new StackLayout();

            layout.Children.Add(new Button() { Text = "売上登録",  });

            layout.Children.Add(new Button() { Text = "メニューへ", Command = new Command(() => Navigation.RemovePage(Navigation.NavigationStack[1])) });

            // Accomodate iPhone status bar.
            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);
            NavigationPage.SetHasNavigationBar(this, false);

            this.Content = layout;
        }

    }
}
