using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing.Net.Mobile.Forms;
using Xamarin.Forms;

namespace Planet.PDA.Portable
{
    /// <summary>
    /// Barcodeクラス （カメラを起動してバーコードを読み込む）
    /// </summary>
    class BarcodeScanPage : ZXingScannerPage
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public BarcodeScanPage()
        {
            Barcode = "";

            DefaultOverlayTopText = "バーコード読み込み";
            DefaultOverlayBottomText = "";

            OnScanResult += (result) =>
            {
                IsScanning = false;

                Barcode = result.Text; // スキャン終了後のデータを取得

                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Navigation.PopAsync();
                    await DisplayAlert("スキャンできました。", result.Text, "OK");

                });
            };
        }

        /// <summary>
        /// 読み込みデータ
        /// </summary>
        public string Barcode { get; private set; }

    }
}
