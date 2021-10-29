using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication144
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ارسال شد");
            this.Close();
            Form2 k = new Form2();
            k.Focus();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string ffff = System.IO.File.ReadAllText("C:\\ProgramData\\factor.txt");
            label4.Text = ffff;
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true; 
            }
            else
            {

                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.bmi.ir");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.bpi.ir");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.bmi.ir");
        }
    }
}
