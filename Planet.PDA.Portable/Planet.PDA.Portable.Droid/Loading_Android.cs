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
        /// <summary>
        /// プログレスダイアログ
        /// </summary>
        ProgressDialog progress;

        /// <summary>
        /// 表示の有無
        /// </summary>
        bool isShow = false;

        /// <summary>ローディングを開始する</summary>
        /// <param name="message">メッセージ</param>
        public void Show(string message)
        {
            progress = new ProgressDialog(Forms.Context);
            progress.Indeterminate = true;
            progress.SetProgressStyle(ProgressDialogStyle.Spinner);
            progress.SetCancelable(false);
            progress.SetMessage(message);
            progress.Show();
            isShow = true;
        }

        /// <summary>
        /// メッセージを表示する
        /// </summary>
        /// <param name="message">メッセージ</param>
        public void SetMessage(string message)
        {
            if (isShow)
            {
                progress.SetMessage(message);
            }
        }

        /// <summary>
        /// ローディングを終了する
        /// </summary>
        public void Hide()
        {
            progress?.Dismiss();
            isShow = false;
        }

        /// <summary>
        /// 状態
        /// </summary>
        public bool IsShow => isShow;

    }
}