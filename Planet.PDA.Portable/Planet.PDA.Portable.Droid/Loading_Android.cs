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
        /// <summary>���[�f�B���O���J�n����</summary>
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

        /// <summary>���[�f�B���O���I������</summary>
        public void Hide()
        {
            progress?.Dismiss();
            ishow = false;
        }

        /// <summary>���</summary>
        public bool IsShow => ishow;

        private bool ishow = false;

    }
}