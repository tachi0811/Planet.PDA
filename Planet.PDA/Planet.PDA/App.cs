using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Planet.PDA
{
	public class App : Application
	{
		public App ()
		{
            var button = new Button();
            button.Text = "kousin";
            button.Clicked += buttonClick;

			// The root page of your application
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							HorizontalTextAlignment = TextAlignment.Center,
							Text = "Welcome to Xamarin Forms!"
						}
                        , button
					}
				}
			};
		}

        private async void buttonClick(object sender, EventArgs e)
        {
            try
            {
                var request = System.Net.HttpWebRequest.Create("http://192.168.15.54/PDAWcfService/SendService.svc/getdata/ap_system_parameter");
                using (var response = await request.GetResponseAsync())
                {
                    using (var stream = response.GetResponseStream())
                    {
                        using (var readStream = new System.IO.StreamReader(stream))
                        {
                            string data = readStream.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
 
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
