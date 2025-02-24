using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp6
{
    class CircuralButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {

            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);

            this.Region = new System.Drawing.Region(gp);

            base.OnPaint(pevent);
        }
    }
}
