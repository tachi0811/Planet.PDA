using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using ZXing.Net.Mobile.Forms;
using System;
using System.Reflection;

namespace Planet.PDA.Portable
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


            Label lbl = new Label()
            {
                Text = ""
            };

            var layout = new StackLayout()
            {
                Children =
                {
                    grid,
                    lbl,
                    new Label() { Text="" },
                    new Label() { Text = "最終更新日：{0}" },
                    new Button() { Text = "マスタデータ受信" ,
                    // ------------------------------
                    // マスタデータ受信
                    // ------------------------------
                    Command = new Command(async () =>
                    {
                        // マスタ受信ページへ
                        await Common.InsertMasterDataAll();
                    })},
                    new Label() { Text = "最終送信日：{0}" },
                    new Button() { Text = "データ送信",
                    // ------------------------------
                    // データ送信
                    // ------------------------------
                    Command = new Command(async() =>
                    {
                        // スキャナページの設定
                        var scanPage = new ZXingScannerPage()
                        {
                            DefaultOverlayTopText = "バーコードを読み取ります",
                            DefaultOverlayBottomText = "",
                        };
                        // スキャナページを表示
                        await Navigation.PushAsync(scanPage);

                        // データが取れると発火
                        scanPage.OnScanResult += (result) =>
                        {
                            // スキャン停止
                            scanPage.IsScanning = false;

                            // PopAsyncで元のページに戻り、結果をダイアログで表示
                            Device.BeginInvokeOnMainThread(async () =>
                            {
                                await Navigation.PopAsync();
                                await DisplayAlert("スキャン完了", result.Text, "OK");
                            });
                        };

                    })},
                new Button() { Text = "メニューへ", Command = new Command(() => Navigation.RemovePage(Navigation.NavigationStack[1])) }
                }
            };

            // Accomodate iPhone status bar.
            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);
            NavigationPage.SetHasNavigationBar(this, false);

            this.Content = layout;

        }


    }
}
