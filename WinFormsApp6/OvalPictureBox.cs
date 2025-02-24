using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp6
{
    class OvalPictureBox : PictureBox
    {
        public OvalPictureBox()
        {
            this.BackColor = Color.DarkGray;
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            using (var gp = new GraphicsPath())
            {
                gp.AddEllipse(new Rectangle(0, 0, this.Width - 1, this.Height - 1));
                this.Region = new System.Drawing.Region(gp);

               
            }
        }
    }
}
