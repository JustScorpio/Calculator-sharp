using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Calculator_sharp
{
    class CustomButton: Button
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern System.IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            IntPtr ptr = CreateRoundRectRgn(0, 0, Width, Height, 30, 30);
            Region = Region.FromHrgn(ptr);
        }
    }
}
