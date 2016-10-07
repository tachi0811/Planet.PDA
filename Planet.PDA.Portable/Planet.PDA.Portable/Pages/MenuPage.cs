using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Planet.PDA.Portable
{
    /// <summary>
    /// メニュー
    /// </summary>
    public class MenuPage : ContentPage
    {
        public MenuPage()
        {
            Title = "メニューページ";

            Grid grid = new Grid
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                }
            };

            

            // Build the page.
            this.Content = grid;
            grid.Children.Add(new Button { Text = "売上登録", Command = new Command(() => Navigation.PushAsync(new UriageMenuPage())) }, 0, 0);
            grid.Children.Add(new Button { Text = "送受信", Command = new Command(() => Navigation.PushAsync(new SojushinMenuPage())) }, 1, 0);
            grid.Children.Add(new Button { Text = "ボタン3", }, 2, 0);
            grid.Children.Add(new Button { Text = "ボタン1", }, 0, 1);
            grid.Children.Add(new Button { Text = "ボタン2", }, 1, 1);
            grid.Children.Add(new Button { Text = "ボタン3", }, 2, 1);
            grid.Children.Add(new Button { Text = "ボタン1", }, 0, 2);
            grid.Children.Add(new Button { Text = "ボタン2", }, 1, 2);
            grid.Children.Add(new Button { Text = "ボタン3", }, 2, 2);

            // Accomodate iPhone status bar.
            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);
            NavigationPage.SetHasNavigationBar(this, false);

            this.Content = grid;

        }
    }
}
