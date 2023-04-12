using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p8IkiBoyutluNesneler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        void dondurme()
        {
            Image img = pictureBox2.Image;
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox2.Image = img;

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) 
            {
                pictureBox1.Top -= 5;
            }
            if (e.KeyCode == Keys.Down)
            {
                pictureBox1.Top += 5;
            }
            if (e.KeyCode == Keys.Left)
            {
                pictureBox1.Left -= 5;
            }
            if (e.KeyCode == Keys.Right)
            {
                pictureBox1.Left += 5;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //YUKARI ÇIKARMA
            pictureBox2.Top -= 5;
            if(pictureBox2.Top <=  47) 
            { 
                timer1.Stop();
                timer2.Start();
                dondurme();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //SAĞA DÖNDÜRME
            pictureBox2.Left += 5;
            if (pictureBox2.Left >= 1222)
            {
                timer2.Stop();
                timer3.Start();
                dondurme();               
            }
           
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            //AŞAĞI İNDİRME
            pictureBox2.Top += 5;
            if (pictureBox2.Top >= 586)
            {
                timer3.Stop();
                timer4.Start();
                dondurme();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            //SOLA DÖNDÜRME
            pictureBox2.Left -= 5;
            if(pictureBox2.Left <= 220)
            {
                timer4.Stop(); 
                timer5.Start(); 
                dondurme();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            //YUKARI ÇIKARMA
            pictureBox2.Top -= 5;
            if((pictureBox2.Top <= 144))
            {
                timer5.Stop();
                timer6.Start();
                dondurme();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            //SAĞA DÖNDÜRME
            pictureBox2.Left += 5;
            if((pictureBox2.Left >= 1073))
            {
                timer6.Stop();
                timer7.Start(); 
                dondurme();
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            //AŞAĞI İNDİRME
            pictureBox2.Top += 5;
            if (pictureBox2.Top >= 486)
            {
                timer7.Stop();
                timer8.Start();
                dondurme();
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            //SOLA DÖNDÜRME
            pictureBox2.Left -= 5;
            if (pictureBox2.Left <= 382)
            {
                timer8.Stop();
                timer9.Start();
                dondurme();
            }
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            //YUKARI ÇIKARMA
            pictureBox2.Top -= 5;
            if ((pictureBox2.Top <= 241))
            {
                timer9.Stop();
                timer10.Start();
                dondurme();
            }
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            //SAĞA DÖNDÜRME
            pictureBox2.Left += 5;
            if(pictureBox2.Left >= 925)
            {
                timer10.Stop();
                timer11.Start();
                dondurme();
            }
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            //AŞAĞI İNDİRME
            pictureBox2.Top += 5;
            if (pictureBox2.Top >= 394)
            {
                timer11.Stop();
                timer12.Start();
                dondurme();
            }
        }

        private void timer12_Tick(object sender, EventArgs e)
        {
            //SOLA DÖNDÜRME
            pictureBox2.Left -= 5;
            if (pictureBox2.Left <= 677)
            {
                timer12.Stop();
                timer13.Start();    
                dondurme();
                MessageBox.Show("Yarış Biti!","OYUN BİTTİ",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

      
    }
}
