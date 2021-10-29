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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.File.WriteAllText("C:\\ProgramData\\ko.txt", textBox1.Text);
                System.IO.File.WriteAllText("C:\\ProgramData\\kb.txt", textBox4.Text);
                System.IO.File.WriteAllText("C:\\ProgramData\\s.txt", textBox3.Text);
                System.IO.File.WriteAllText("C:\\ProgramData\\j.txt", textBox2.Text);
                System.IO.File.WriteAllText("C:\\ProgramData\\ss.txt", textBox6.Text);
                System.IO.File.WriteAllText("C:\\ProgramData\\sf.txt", textBox5.Text);
                System.IO.File.WriteAllText("C:\\ProgramData\\jl.txt", textBox7.Text);
                System.IO.File.WriteAllText("C:\\ProgramData\\nos.txt", textBox8.Text);
                System.IO.File.WriteAllText("C:\\ProgramData\\dl.txt", textBox9.Text);
                System.IO.File.WriteAllText("C:\\ProgramData\\dog.txt", textBox10.Text);
                Application.Restart();
            }
            catch
            {
                MessageBox.Show("اطلاعات مشکل دارد");
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {


        }
    }
}
