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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.Text = "به رستوران خوش آمدید";
            timer1.Start();
        }
        int a = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Form2 j=new Form2();
            a++;
            if (a == 20)
            {
                j.Show();
                this.Hide();

            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}

