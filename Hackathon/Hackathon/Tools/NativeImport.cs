using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Hackathon.Tools
{
    internal class NativeImport
    {
        internal class WindowsStyleModifiers
        {
            public const int GWL_EXSTYLE = -20;

            public const int WS_EX_LAYERED = 0x80000;

            public const int WS_EX_TRANSPARENT = 0x20;

            public const int LWA_ALPHA = 0x1;

            public const int LWA_COLORKEY = 0x030201;
        }

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern uint GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll")]
        internal static extern bool SetLayeredWindowAttributes(IntPtr hwnd, uint crKey, byte bAlpha, uint dwFlags);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);
    }
}
