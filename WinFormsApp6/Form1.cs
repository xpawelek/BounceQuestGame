using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WinFormsApp6
{
    public  partial class Form1 : Form
    {
       static Random rnd = new Random();
        public static int x , y = rnd.Next(4,8);

        
        public static int zniszczoneBloczki = 0;
        public static int destroyedBricks=0;

        public static int iloscLeveli = 3;
        static int q1 = 0;

        public static int iloscZyc = 3;



       public static SoundPlayer simpleSound1 = new SoundPlayer(BounceQuestGame.Properties.Resources.niszczenie1);


        //   static cegla[] ceglyLevel1 = { new cegla(100, 100, Properties.Resources.cegla), new cegla(100, 250, Properties.Resources.cegla), new cegla(100, 400, Properties.Resources.cegla), new cegla(100, 550, Properties.Resources.cegla), new cegla(200, 100, Properties.Resources.cegla), new cegla(200, 250, Properties.Resources.cegla), new cegla(200, 400, Properties.Resources.cegla), new cegla(200, 550, Properties.Resources.cegla) };
        // static cegla[] ceglyLevel2= { new cegla(100, 110, Properties.Resources.cegla1), new cegla(100, 260, Properties.Resources.cegla1), new cegla(100, 410, Properties.Resources.cegla1), new cegla(100, 560, Properties.Resources.cegla1), new cegla(200, 110, Properties.Resources.cegla1), new cegla(200, 260, Properties.Resources.cegla1), new cegla(200, 410, Properties.Resources.cegla1), new cegla(200, 560, Properties.Resources.cegla1) };


        static cegla[,] cegly = new cegla[4, 10] {
               { new cegla(144,93), new cegla(144,339), new cegla(144,578), new cegla(264, 93), new cegla(264,339), new cegla(264, 578), new cegla(401, 93),new cegla(401, 339), new cegla(401, 578),new cegla(547, 339) },
            { new cegla(90,339), new cegla(186,136), new cegla(186, 545), new cegla(228, 339), new cegla(330, 12), new cegla(330, 630), new cegla(386,339), new cegla(435, 136),new cegla(435, 545),new cegla(517,339) },
        { new cegla(26, 38), new cegla(26, 643), new cegla(129, 190), new cegla(129, 500), new cegla(210, 339), new cegla(281, 339), new cegla(365, 190), new cegla(365, 500),new cegla(473, 38),new cegla(473, 643), },
         { new cegla(482, 79), new cegla(120, 282), new cegla(120, 399), new cegla(482, 594), new cegla(176, 221), new cegla(176, 339), new cegla(176, 456), new cegla(232, 274),new cegla(232, 399),new cegla(288,339) } 

        };


        int cegielInAr = cegly.GetLength(1);
       // int[] szybkosc = { x+2, x+4, x+6, x+8, x+10, x+12 };
         Image[] images = { BounceQuestGame.Properties.Resources.ls0, BounceQuestGame.Properties.Resources.ls1, BounceQuestGame.Properties.Resources.ls2};


        SoundPlayer simpleSound = new SoundPlayer(BounceQuestGame.Properties.Resources.soundtrack);
        SoundPlayer simpleSound2= new SoundPlayer(BounceQuestGame.Properties.Resources.bounce2);
        SoundPlayer simpleSound3 = new SoundPlayer(BounceQuestGame.Properties.Resources.nextLevel);
        SoundPlayer simpleSound4 = new SoundPlayer(BounceQuestGame.Properties.Resources.wygrana);
        SoundPlayer simpleSound5 = new SoundPlayer(BounceQuestGame.Properties.Resources.przegrana);
        SoundPlayer simpleSound6 = new SoundPlayer(BounceQuestGame.Properties.Resources.newlevel);


        public Form1()
        {
            InitializeComponent();

            circuralButton2.Parent = panel1;

       

            pictureBox2.Parent = panel1;
        //    pictureBox4.Parent = panel1;
         //   pictureBox5.Parent = panel1;
         //   pictureBox6.Parent = panel1;
            pictureBox2.SendToBack();
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Width = 785;
            pictureBox2.Height = 954;
            pictureBox2.BackgroundImage = BounceQuestGame.Properties.Resources.landscape1;

            simpleSound.Play();

            pictureBox2.Controls.Add(pictureBox4);
            pictureBox4.Location = new Point(662, 3);
            pictureBox4.BackColor = Color.Transparent;

            pictureBox2.Controls.Add(pictureBox5);
            pictureBox5.Location = new Point(700, 3);
            pictureBox5.BackColor = Color.Transparent;

            pictureBox2.Controls.Add(pictureBox6);
            pictureBox6.Location = new Point(738, 3);
            pictureBox6.BackColor = Color.Transparent;

            średniToolStripMenuItem.Checked = true;
            x = 9;


            // Helper.BlendPicutres(pictureBox2, pictureBox4);



            pictureBox1.Visible = false;
            pictureBox3.Visible = false;
         }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }



        //obsługa odbijania pileczki od panela oraz zakonczecnie gry w przypadku skucia sie
        private void timer1_Tick(object sender, EventArgs e)
        { 
            int currentStateTop = 0;
            int currentStateLeft = 0;

            int t1 = panel1.Height - x - pictureBox1.Height;
            int t2 = 0 + x;

            if (currentStateTop == 0)
            {
                if (pictureBox1.Top <= t1)
                {
                    pictureBox1.Top += x;
                }
                else
                {
                    // x = -x;
                    timer1.Stop();
                    iloscZyc--;
                    if(iloscZyc==2)
                    {
                     pictureBox4.Visible = false;
                    pictureBox1.Location = new Point(361, 600);
                        timer1.Start();
                    }
                    if (iloscZyc == 1)
                    {
                        pictureBox5.Visible = false;
                        pictureBox1.Location = new Point(361, 600);
                        timer1.Start();
                    }
                    if (iloscZyc == 0)
                    {
                        pictureBox6.Visible = false;
                        simpleSound5.Play();
                        MessageBox.Show("Koniec gry!");
                        timer1.Stop();
                    }

                  
                
                }
                if (pictureBox1.Top <= 0)
                {
                    currentStateTop = 1;
                }
            }
            if (currentStateTop == 1)
            {
                if (pictureBox1.Top <= t2)
                {
                    pictureBox1.Top += -x;
                }
                else
                {
                    x = -x;
                }
                if (pictureBox1.Top >= t1)
                {
                    currentStateTop = 0;
                }
            }

            int r1 = panel1.Width - pictureBox1.Width - y;
            int r2 = 0 + y;

            if (currentStateLeft == 0)
            {
                if (pictureBox1.Left <= r1)
                {
                    pictureBox1.Left += y;
                }
                else
                {
                    y = -y;
                }

                if (pictureBox1.Left <= 0)
                {
                    currentStateLeft = 1;
                }
            }
            if (currentStateLeft == 1)
            {
                if (pictureBox1.Left <= r2)
                {
                    pictureBox1.Left += -y;
                }
                else
                {
                    y = -y;
                }
            }




            //obsluga leveli (kolejne levele, zmiana zdjecia, szybkosci czyli x oraz czestotliwosci wykonywania interwalu) oraz odbijania od cegiełek i ich niszczenia 

            int ilosc = iloscLeveli * 10;
            int b1 = 0;


            while (q1 <= iloscLeveli && b1 <= ilosc)
            {
                if (destroyedBricks == 0)
                {
                    for (int i = 0; i < cegielInAr; i++)
                    {
                        panel1.Controls.Add(cegly[q1, i].pb);
                        cegly[q1, i].pb.BringToFront();
                    }
                }

                if (destroyedBricks >= 0 && destroyedBricks < cegielInAr)
                {
                    for (int i = 0; i < cegielInAr; i++)
                    {
                        cegly[q1, i].kolizja(pictureBox1, panel1);

                     }
                }

                if (destroyedBricks == cegielInAr)
                {
                    simpleSound6.Play();
                    timer1.Stop();
                    try
                    {
                     pictureBox2.Image = images[q1];
                    }
                    catch (Exception)
                    {
                        pictureBox1.Image = images[iloscLeveli - 1];
                    }
                   
                    try
                    {
                        x += 2;
                    }
                    catch (Exception)
                    {
                        x = 10;
                    }

                    pictureBox1.Location = new Point(361, 600);


                    q1++;
                    timer1.Interval = (int)timer1.Interval - 2;

                    destroyedBricks = 0;
                    
                    timer1.Start();
                    
                    //  zniszczoneBloczki = zniszczoneBloczki + 1;

                }
              //  label1.Text = x.ToString();
              b1 += cegielInAr;
            }

      

            //koniec gry w przypasku wygranej

          if (zniszczoneBloczki == ilosc+cegielInAr)
            {
                timer1.Stop();
                simpleSound4.Play();
                MessageBox.Show("Koniec gry, wygrałeś!");
            }

            //oodbijanie od panela dolnego - kładki

            if (pictureBox1.Left >= pictureBox3.Left - pictureBox1.Width + y && pictureBox1.Left + pictureBox1.Width <= pictureBox3.Left + pictureBox3.Width + pictureBox1.Width - y)
            { 

                if (pictureBox1.Top + pictureBox1.Height >= pictureBox3.Top && pictureBox1.Top + pictureBox1.Height <= pictureBox3.Top + x)
                {
                    x = -x;
                    simpleSound2.Play();
                }
            }
           

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        //sterowanie panelem w prawo i w lewo
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {


            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (pictureBox3.Left >= 0 + 10)
                    {
                        pictureBox3.Left -= 20;
                    }

                    break;

                case Keys.Right:
                    if (pictureBox3.Right <= panel1.Width - 10)
                    {
                        pictureBox3.Left += 20;
                    }

                    break;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Focus();
          }



        

        private void circuralButton2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            poziomTrudnościToolStripMenuItem.Enabled = false;

            this.ActiveControl = null; // to powoduje, że po kliknięciu na buttona nie robi sie autofocus na nim i dalej możemy sterować panelem

            pictureBox1.Visible = true;
            pictureBox3.Visible = true;
            
            pictureBox3.BringToFront();

            simpleSound.Stop();
            circuralButton2.Visible = false;
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        
       
        }

        private void łatwyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            łatwyToolStripMenuItem.Checked = true;
            średniToolStripMenuItem.Checked = false;
            trudnyToolStripMenuItem.Checked = false;
            x = 6;
        }

        private void średniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            łatwyToolStripMenuItem.Checked = false;
            średniToolStripMenuItem.Checked = true;
            trudnyToolStripMenuItem.Checked = false;
            x = 9;
        }

        private void trudnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            łatwyToolStripMenuItem.Checked = false;
            średniToolStripMenuItem.Checked = false;
            trudnyToolStripMenuItem.Checked = true;
            x = 12;
        }

        private void poziomTrudnościToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < cegielInAr; i++)
            {
                panel1.Controls.Remove(cegly[q1, i].pb);
               
            }
            pictureBox2.Image = BounceQuestGame.Properties.Resources.landscape1;

            zniszczoneBloczki = 0;
        destroyedBricks = 0;
          q1 = 0;
         iloscZyc = 3;
            cegly = new cegla[4, 10] {
               { new cegla(26, 214), new cegla(26, 469), new cegla(140, 74), new cegla(140, 550), new cegla(140,338), new cegla(351, 214), new cegla(351, 469),new cegla(596, 74), new cegla(596, 338),new cegla(596, 591) },
            { new cegla(747, 342), new cegla(180,102), new cegla(180, 351), new cegla(180, 592), new cegla(305, 102), new cegla(305, 351), new cegla(305, 592), new cegla(436, 102),new cegla(436, 351),new cegla(436, 592) },
        { new cegla(26, 38), new cegla(26, 643), new cegla(129, 190), new cegla(129, 500), new cegla(210, 339), new cegla(281, 339), new cegla(365, 190), new cegla(365, 500),new cegla(473, 38),new cegla(473, 643), },
         { new cegla(482, 79), new cegla(120, 282), new cegla(120, 399), new cegla(482, 594), new cegla(176, 221), new cegla(176, 339), new cegla(176, 456), new cegla(232, 274),new cegla(232, 399),new cegla(288,339) }

        };

            circuralButton2.Parent = panel1;



            pictureBox2.Parent = panel1;
            //    pictureBox4.Parent = panel1;
            //   pictureBox5.Parent = panel1;
            //   pictureBox6.Parent = panel1;
            pictureBox2.SendToBack();
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Width = 785;
            pictureBox2.Height = 954;
            pictureBox2.BackgroundImage = BounceQuestGame.Properties.Resources.landscape1;

            simpleSound.Play();

            pictureBox2.Controls.Add(pictureBox4);
            pictureBox4.Location = new Point(662, 3);
            pictureBox4.BackColor = Color.Transparent;

            pictureBox2.Controls.Add(pictureBox5);
            pictureBox5.Location = new Point(700, 3);
            pictureBox5.BackColor = Color.Transparent;

            pictureBox2.Controls.Add(pictureBox6);
            pictureBox6.Location = new Point(738, 3);
            pictureBox6.BackColor = Color.Transparent;

            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;

            pictureBox1.Location = new Point(361, 600);

          if(trudnyToolStripMenuItem.Checked==true)
            {
                x = 12;
            }
          if(średniToolStripMenuItem.Checked==true)
            {
                x = 9;
            }
          if(łatwyToolStripMenuItem.Checked==true)
            {
                x = 6;
            }

            // Helper.BlendPicutres(pictureBox2, pictureBox4);



         

        }

        private void rozpocznijOdNowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            timer1.Stop();
            circuralButton2.Visible = true;
            poziomTrudnościToolStripMenuItem.Enabled = true;

            łatwyToolStripMenuItem.Checked = false;
            trudnyToolStripMenuItem.Checked = false;
            średniToolStripMenuItem.Checked = true;
            x = 9;
            pictureBox1.Visible = false;
            pictureBox3.Visible = false;

            

            for (int i = 0; i < cegielInAr; i++)
            {
                panel1.Controls.Remove(cegly[q1, i].pb);

            }
            simpleSound.Play();
           pictureBox2.Image = BounceQuestGame.Properties.Resources.landscape1;

            zniszczoneBloczki = 0;
            destroyedBricks = 0;
            q1 = 0;
            iloscZyc = 3;
            cegly = new cegla[4, 10] {
               { new cegla(144,93), new cegla(144,339), new cegla(144,578), new cegla(264, 93), new cegla(264,339), new cegla(264, 578), new cegla(401, 93),new cegla(401, 339), new cegla(401, 578),new cegla(547, 339) },
            { new cegla(90,339), new cegla(186,136), new cegla(186, 545), new cegla(228, 339), new cegla(330, 12), new cegla(330, 630), new cegla(386,339), new cegla(435, 136),new cegla(435, 545),new cegla(517,339) },
        { new cegla(26, 38), new cegla(26, 643), new cegla(129, 190), new cegla(129, 500), new cegla(210, 339), new cegla(281, 339), new cegla(365, 190), new cegla(365, 500),new cegla(473, 38),new cegla(473, 643), },
         { new cegla(482, 79), new cegla(120, 282), new cegla(120, 399), new cegla(482, 594), new cegla(176, 221), new cegla(176, 339), new cegla(176, 456), new cegla(232, 274),new cegla(232, 399),new cegla(288,339) }

        };
            pictureBox3.Location = new Point(274, 889);
            circuralButton2.Parent = panel1;



            pictureBox2.Parent = panel1;
            //    pictureBox4.Parent = panel1;
            //   pictureBox5.Parent = panel1;
            //   pictureBox6.Parent = panel1;
            pictureBox2.SendToBack();
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Width = 785;
            pictureBox2.Height = 954;
            pictureBox2.BackgroundImage = BounceQuestGame.Properties.Resources.landscape1;

            simpleSound.Play();

            pictureBox2.Controls.Add(pictureBox4);
            pictureBox4.Location = new Point(662, 3);
            pictureBox4.BackColor = Color.Transparent;

            pictureBox2.Controls.Add(pictureBox5);
            pictureBox5.Location = new Point(700, 3);
            pictureBox5.BackColor = Color.Transparent;

            pictureBox2.Controls.Add(pictureBox6);
            pictureBox6.Location = new Point(738, 3);
            pictureBox6.BackColor = Color.Transparent;

            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;

            pictureBox1.Location = new Point(361, 600);
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            

        }
    }
}
