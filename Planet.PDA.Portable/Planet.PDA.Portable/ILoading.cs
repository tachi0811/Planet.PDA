using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planet.PDA.Portable
{
    public interface ILoading
    {
        /// <summary>
        /// 画面を表示します
        /// </summary>
        /// <param name="message">メッセージ</param>
        void Show(string message);

        /// <summary>
        /// 画面を非表示にする
        /// </summary>
        void Hide();

        /// <summary>
        /// true : 表示中, false : 非表示
        /// </summary>
        bool IsShow { get; }

        /// <summary>
        /// メッセージ変更
        /// </summary>
        /// <param name="message">メッセージ</param>
        void SetMessage(string message);
    }
}
