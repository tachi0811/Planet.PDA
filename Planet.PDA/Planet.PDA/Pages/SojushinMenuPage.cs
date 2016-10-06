using System.Threading.Tasks;
using Xamarin.Forms;


namespace Planet.PDA
{
    class SojushinMenuPage : ContentPage
    {
        /// <summary>
        /// 送受信メニュー
        /// </summary>
        public SojushinMenuPage()
        {

            Title = "送受信メニュー";

            var grid = new Grid()
            {
                ColumnDefinitions =
                {
                    new ColumnDefinition() { Width = 50 },
                    new ColumnDefinition() { Width = GridLength.Auto },
                },
                RowDefinitions =
                {
                    new RowDefinition() { Height = 20 },
                    new RowDefinition() { Height = 20 },
                },
            };

            grid.Children.Add(new Label() {Text = "状態" } , 0, 0);
            grid.Children.Add(new Label() { Text = "ZZZZ" }, 1, 0);
            grid.Children.Add(new Label() { Text = "売上日" }, 0, 1);
            grid.Children.Add(new Label() { Text = "yyyy/MM/dd" }, 1, 1);

            var layout = new StackLayout()
            {
                Children =
                {
                    grid,
                    //new StackLayout()
                    //{
                    //    Orientation = StackOrientation.Horizontal,
                    //    Children =
                    //    {
                    //        new Label() { Text ="状態",  },
                    //        new Label() { Text = "ZZZZ", }
                    //    }
                    //},
                    //new StackLayout()
                    //{
                    //    Orientation = StackOrientation.Horizontal,
                    //    Children =
                    //    {
                    //        new Label() { Text ="売上日",  },
                    //        new Label() { Text = "ZZZZ", }
                    //    }
                    //},
                    new Label() { Text="" },
                    new Label() { Text = "最終更新日：{0}" },
                    new Button() { Text = "マスタデータ受信" ,
                    Command = new Command(async() => 
                    {
                        var x = await GetApSystemParameter();


                    })},
                    new Label() { Text = "最終送信日：{0}" },
                    new Button() { Text = "データ送信",
                    Command = new Command(() =>
                    {



                    })},
                new Button() { Text = "メニューへ", Command = new Command(() => Navigation.RemovePage(Navigation.NavigationStack[1])) }
                }
            };

            // Accomodate iPhone status bar.
            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);
            NavigationPage.SetHasNavigationBar(this, false);

            this.Content = layout;

        }

        private async Task<ap_system_parameter> GetApSystemParameter()
        {
            var request = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create("http://weather.livedoor.com/forecast/webservice/json/v1?city=400040");
            request.ContentType = "application/json";
            request.Method = "GET";

            using (var response = await request.GetResponseAsync() as System.Net.HttpWebResponse)
            {
                string data = null;


            }

            return new ap_system_parameter();
        }

    }
}
