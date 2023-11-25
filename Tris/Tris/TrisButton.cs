using System;
using System.Windows.Forms;

namespace Tris
{
    internal class TrisButton : Button
    {
        public int Player { get; set; }

        public void Reset()
        {
            Player = 0;
            Text = String.Empty;
        }
    }
}
