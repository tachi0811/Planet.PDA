using SQLite.Net;
using System;
using System.IO;
using Xamarin.Forms;
using Planet.PDA.Portable.iOS;
using Planet.PDA.Portable;
using XamarinApp.iOS;
using UIKit;
using CoreGraphics;

[assembly: Dependency(typeof(Loading_iOS))]
namespace Planet.PDA.Portable.iOS
{
    public class Loading_iOS : ILoading
    {
        LoadingOverlay loadingOverlay;


        /// <summary>ローディングを開始する</summary>
        /// <param name="message"></param>
        public void Show(string message)
        {
            var window = UIApplication.SharedApplication.KeyWindow;
            var vc = window.RootViewController;
            while (vc.PresentedViewController != null)
            {
                vc = vc.PresentedViewController;
            }

            var bounds = UIScreen.MainScreen.Bounds;
            loadingOverlay = new LoadingOverlay(bounds, message);
            vc.Add(loadingOverlay);
            isShow = true;
        }

        public void SetMessage(string message)
        {
            if (isShow)
            {
                loadingOverlay.loadingLabel.Text = message;
            }
        }

        /// <summary>ローディングを終了する</summary>
        public void Hide()
        {
            loadingOverlay.Hide();
            isShow = false;
        }

        /// <summary>状態</summary>
        public bool IsShow => isShow;

        private bool isShow = false;
    }

    public class LoadingOverlay : UIView
    {
        // control declarations
        UIActivityIndicatorView activitySpinner;
        public UILabel loadingLabel;

        public LoadingOverlay(CGRect frame, string message) : base(frame)
        {
            // configurable bits
            BackgroundColor = UIColor.Black;
            Alpha = 0.75f;
            AutoresizingMask = UIViewAutoresizing.All;

            nfloat labelHeight = 22;
            nfloat labelWidth = Frame.Width - 20;

            // derive the center x and y
            nfloat centerX = Frame.Width / 2;
            nfloat centerY = Frame.Height / 2;

            // create the activity spinner, center it horizontall and put it 5 points above center x
            activitySpinner = new UIActivityIndicatorView(UIActivityIndicatorViewStyle.WhiteLarge);
            activitySpinner.Frame = new CGRect(
                centerX - (activitySpinner.Frame.Width / 2),
                centerY - activitySpinner.Frame.Height - 20,
                activitySpinner.Frame.Width,
                activitySpinner.Frame.Height);
            activitySpinner.AutoresizingMask = UIViewAutoresizing.All;
            AddSubview(activitySpinner);
            activitySpinner.StartAnimating();

            // create and configure the "Loading Data" label
            loadingLabel = new UILabel(new CGRect(
                centerX - (labelWidth / 2),
                centerY + 20,
                labelWidth,
                labelHeight
                ));
            loadingLabel.Text = message;
            loadingLabel.BackgroundColor = UIColor.Clear;
            loadingLabel.TextColor = UIColor.White;
            loadingLabel.TextAlignment = UITextAlignment.Center;
            loadingLabel.AutoresizingMask = UIViewAutoresizing.All;
            AddSubview(loadingLabel);

        }

        /// <summary>
        /// Fades out the control and then removes it from the super view
        /// </summary>
        public void Hide()
        {
            UIView.Animate(
                0.5, // duration
                () => { Alpha = 0; },
                () => { RemoveFromSuperview(); }
            );
        }
    }
}