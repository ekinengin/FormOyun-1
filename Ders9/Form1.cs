using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonstart_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;

            timer1.Enabled = true;
            timer1.Interval = 500;

            timer3.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            pictureBox1.Location = new Point(0, 36);
            pictureBox2.Location = new Point(0, 155);
            pictureBox3.Location = new Point(0, 272);

            timer2.Enabled = true;
            timer2.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();

            if (pictureBox1.Left < label9.Right && pictureBox2.Left < label10.Right && pictureBox3.Left < label11.Right)
            {
                pictureBox1.Left += random.Next(10, 20);
                pictureBox2.Left += random.Next(10, 20);
                pictureBox3.Left += random.Next(10, 20);
            }
            else
            {
                timer1.Stop();
            }

            label5.Text = $"1.At :  {pictureBox1.Left.ToString()} m.";        
            label6.Text = $"2.At :  {pictureBox2.Left.ToString()} m.";
            label7.Text = $"3.At :  {pictureBox3.Left.ToString()} m.";

            //Yarış başla Spiker devreye girer. 

            if (pictureBox1.Right > pictureBox2.Right && pictureBox1.Right > pictureBox3.Right)
            {
                labelspiker.Text = "1. At hızlı bir çıkışla liderliği ele alıyor.";
            }
            else if (pictureBox2.Right > pictureBox1.Right && pictureBox2.Right > pictureBox3.Right)
            {
                labelspiker.Text = "2. At farkı kapatıp öne geçmeyi başardı.";
            }
            else if (pictureBox3.Right > pictureBox1.Right && pictureBox3.Right > pictureBox2.Right)
            {
                labelspiker.Text = "3. At bi anda atağa kalkarak rakiplerinin önünde şuan";
            }



            if (pictureBox1.Location.X >= label9.Right)                 // picturebox1.left de yazılabilinirdi..
            {
                labelspiker.Text = "1. At Kazandı.";
            }
            else if (pictureBox2.Location.X >= label10.Right)
            {
                labelspiker.Text = "2. At Kazandı.";
            }
            else if (pictureBox3.Location.X >= label11.Right)
            {
                labelspiker.Text = "3. At Kazandı";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(0, 36);
            pictureBox2.Location = new Point(0, 155);
            pictureBox3.Location = new Point(0, 272);
        }
        
        int a = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {      
            a++;

            if (a == 1 )
            {
                labelspiker.Text = "At Yarışına Hoşgeldiniz";
            }
            if (a == 3)
            {
                labelspiker.Text = "Yarışımız birazdan başlayacaktır..";
            }
            if (a == 5)
            {
                labelspiker.Text = "Yarışı başlatmak için Başla tuşuna basınız";
            }

        }

        int b = 0;
        private void timer3_Tick(object sender, EventArgs e)
        {
            b++;

            if (pictureBox1.Location.X >= label9.Right)                
            {
                timer3.Stop();
                label14.Text = $"{b.ToString()} sn.";

            }
            else if (pictureBox2.Location.X >= label10.Right)
            {
                timer3.Stop();
                label13.Text = $"{b.ToString()} sn.";
            }
            else if (pictureBox3.Location.X >= label11.Right)
            {
                timer3.Stop();
                label12.Text = $"{b.ToString()} sn.";
            }
        }
    }
}
