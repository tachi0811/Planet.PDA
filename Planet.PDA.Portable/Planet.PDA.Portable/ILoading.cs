using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planet.PDA.Portable
{
    public interface ILoading
    {
        void Show(string message);

        void Hide();

        bool IsShow { get; }
    }
}
