﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public class Helper
    {
        private static void BlendPictures(Bitmap bg, Bitmap front, int deltaX, int deltaY)
        {
            for(int y=0; y<front.Height; y++)
            {
                for(int x=0; x<front.Width; x++)
                {
                    if (front.GetPixel(x,y).A<255)
                    {
                        Color newColor = bg.GetPixel(x + deltaX, y + deltaY);
                        front.SetPixel(x, y, newColor);
                    }
                }
            }
        }

        public static void BlendPicutres(PictureBox back, PictureBox front)
        {
            int leftDifference = Math.Abs(back.Left - front.Left);
            int topDifference = Math.Abs(back.Top - front.Top);

            BlendPictures((Bitmap)back.Image, (Bitmap)front.Image, leftDifference, topDifference);
        }
    }
}
