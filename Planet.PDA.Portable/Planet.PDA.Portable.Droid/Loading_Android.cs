using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Planet.PDA.Portable.Droid;

[assembly: Dependency(typeof(Loading_Android))]
namespace Planet.PDA.Portable.Droid
{
    public class Loading_Android : ILoading
    {
        private ProgressDialog progress;
        /// <summary>ローディングを開始する</summary>
        /// <param name="message"></param>
        public void Show(string message)
        {
            progress = new ProgressDialog(Forms.Context);
            progress.Indeterminate = true;
            progress.SetProgressStyle(ProgressDialogStyle.Spinner);
            progress.SetCancelable(false);
            progress.SetMessage(message);
            progress.Show();
            ishow = true;
        }

        /// <summary>ローディングを終了する</summary>
        public void Hide()
        {
            progress?.Dismiss();
            ishow = false;
        }

        /// <summary>状態</summary>
        public bool IsShow => ishow;

        private bool ishow = false;

    }
}