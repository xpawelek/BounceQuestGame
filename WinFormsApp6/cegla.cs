using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public class cegla
    {

        public PictureBox pb = new PictureBox();


        int top = 0;
        int left = 0;
        public cegla(int _top, int _left)
        {
            top = _top;
            left = _left;
            pb.Image = BounceQuestGame.Properties.Resources.brickX;
            pb.SizeMode = PictureBoxSizeMode.Normal;
            pb.BorderStyle = BorderStyle.FixedSingle;
            pb.Width = 100;
            pb.Height = 50;
            pb.Top = top;
            pb.Left = left;

        }

        public int x = Form1.x;

        public void kolizja(Button x1, Panel p)
        {


            if (x1.Right >= pb.Left - Form1.y && x1.Left <= pb.Right - Form1.y)
            {

                
                if (x1.Top >= pb.Bottom && x1.Top <= pb.Bottom - Form1.x)
                {

                    p.Controls.Remove(pb);
                    pb.SetBounds(0, 0, 0, 0);
                    Form1.x = -Form1.x;
                    Form1.simpleSound1.Play();
                  
                   
                    Form1.zniszczoneBloczki++;

                    Form1.destroyedBricks++;
                }

                if (x1.Bottom <= pb.Top && x1.Bottom >= pb.Top - Form1.x)
                {

                    p.Controls.Remove(pb);
                    pb.SetBounds(0, 0, 0, 0);

                    Form1.x = -Form1.x;
                    Form1.simpleSound1.Play();
                    Form1.zniszczoneBloczki++;
                    Form1.destroyedBricks++;
                }
            }

            if (x1.Bottom >= pb.Top && x1.Top <= pb.Bottom )
            {


                if (x1.Left >= pb.Right && x1.Left <= pb.Right - Form1.y)


                {
                    p.Controls.Remove(pb);
                    pb.SetBounds(0, 0, 0, 0);

                    Form1.y = -Form1.y;
                    Form1.simpleSound1.Play();
                    Form1.zniszczoneBloczki++;
                    Form1.destroyedBricks++;
                }
                if (x1.Right <= pb.Left && x1.Right >= pb.Left - Form1.y)
                {

                    p.Controls.Remove(pb);
                    pb.SetBounds(0, 0, 0, 0);

                    Form1.y = -Form1.y;
                    Form1.simpleSound1.Play();
                    Form1.zniszczoneBloczki++;
                    Form1.destroyedBricks++;

                }
            }



        }



    }
}
