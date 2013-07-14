using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace para_sell
{
    public partial class Form1 : Form
    {
        Int32 portno = 0;
        public class portAccess
        {
            [DllImport("inpout32.dll", EntryPoint = "Out32")]
            public static extern void Output(int adress, int value);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fanp1.Enabled = true;
            fanp2.Enabled = true;
            lightp.Enabled = true;
            dancepb.Enabled = true;
            dancepw.Enabled = true;
            fanp1.Interval = 100;
            fanp2.Interval = 200;
            lightp.Interval = 1;
            dancepb.Interval = 100;
            dancepw.Interval = 200;
            checkBox1.Text = "Fan";
            checkBox2.Text = "Lights";
            checkBox3.Text = "LED dance";
            radioButton1.Text = "Low light";
            radioButton2.Text = "High light";
            button1.Text = "NULL";
            button2.Text = "All with H-light";
            button3.Text = "All with L-light";
            button4.Text = "Exit";
            groupBox1.Text = "instrument controls";
            pictureBox2.Image = System.Drawing.Bitmap.FromFile("Image\\Picture3.png", true);
            pictureBox3.Image = System.Drawing.Bitmap.FromFile("Image\\Picture3.png", true);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                pictureBox1.Image = System.Drawing.Bitmap.FromFile("Image\\f1.png", true);
                portAccess.Output(888,64);
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                pictureBox1.Image = System.Drawing.Bitmap.FromFile("Image\\f2.png", true);
                portAccess.Output(888,64);
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true && radioButton1.Checked == true)
                pictureBox2.Image = System.Drawing.Bitmap.FromFile("Image\\Picture1.png", true);
            else if (checkBox2.Checked == true && radioButton2.Checked == true)
                pictureBox2.Image = System.Drawing.Bitmap.FromFile("Image\\Picture2.png", true);
            else
                pictureBox2.Image = System.Drawing.Bitmap.FromFile("Image\\Picture3.png", true);
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            if(checkBox3.Checked==true)
                pictureBox3.Image = System.Drawing.Bitmap.FromFile("Image\\Picture4.png", true);
            else
                pictureBox3.Image = System.Drawing.Bitmap.FromFile("Image\\Picture3.png", true);
        }
        private void timer5_Tick(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
                pictureBox3.Image = System.Drawing.Bitmap.FromFile("Image\\Picture5.png", true);
            else
                pictureBox3.Image = System.Drawing.Bitmap.FromFile("Image\\Picture3.png", true);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            portAccess.Output(888,0);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            radioButton2.Checked = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            radioButton1.Checked = true;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
