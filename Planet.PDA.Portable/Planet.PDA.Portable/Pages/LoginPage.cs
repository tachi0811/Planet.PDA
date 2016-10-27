using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Planet.PDA.Portable.Pages
{
    /// <summary>
    /// ログインページ
    /// </summary>
    public class LoginPage : ContentPage
    {
        Entry userID;
        Entry password;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public LoginPage()
        {
            Title = "ログイン";
            userID = new Entry()
            {
                Placeholder = "Username",
            };

            password = new Entry()
            {
                Placeholder = "Password",
                IsPassword = true
            };

            var stackLayout = new StackLayout
            {
                Spacing = 20,
                Padding = 50,
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    userID,
                    password,
                    new Button
                    {
                        Text = "Login",
                        TextColor = Color.White,
                        BackgroundColor = Color.FromHex("77D065"),
                        Command = new Command(async () => 
                        {
                            if (await IsSeccessLogin(userID.Text, password.Text))
                            {
                                // ログイン完了処理
	                        }
                            else
                            {
                                // ログイン失敗処理（メッセージダイアログ）
	                        }
                        })
                    }
                }
            };
        
            // Accomodate iPhone status bar.
            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);
            NavigationPage.SetHasNavigationBar(this, false);

            this.Content = stackLayout;

        }

        /// <summary>
        /// ログイン処理
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<bool> IsSeccessLogin(string userID, string password)
        {
            return Task.Run(() =>
            {



                return true;
            });
        }

    }
}
