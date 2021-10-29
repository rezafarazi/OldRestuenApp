using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace WindowsFormsApplication144
{
    public partial class Form2 : Form
    {
        private Button printButton = new Button();
        private PrintDocument printDocument1 = new PrintDocument();
        public Form2()
        {
            printButton.Text = "چاپ فاکتور";
            printButton.Click += new EventHandler(printButton_Click);
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            this.Controls.Add(printButton);
            InitializeComponent();
        }
        void printButton_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();
        }
        Bitmap memoryImage;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }
        private void printDocument1_PrintPage(System.Object sender,
           System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("می خوای بری", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading)==DialogResult.OK)
                Application.Exit();
        }
        int q1, q2, q3, q4, d1, d2, d3, n1, n2, n3;
        int a, b, c, d, f, g, h, l, m, n, o, p;
        int aq1, bq2, cq3, dq4, fd1, gd2, hd3, ln1, mn2, nn3;
        string ko, kb, s, j, ss, sf, jl, nos, dl, dog;
        private void Form2_Load(object sender, EventArgs e)
        {
            this.table1TableAdapter.Fill(this.database1DataSet1.Table1);
            // TODO: This line of code loads data into the 'database1DataSet.Table1' table. You can move, or remove it, as needed.
           
            label38.Text = string.Format("{0:00}:{1:00}", DateTime.Now.Hour, DateTime.Now.Minute);
            try
            {
                for (int a = 0; a <= 100; a++)
                    comboBox1.Items.Add(dataGridView1.Rows[a].Cells[4].Value.ToString());
            }
            catch
            {
            }
            finally
            {
            }
            try
            {
                ko=System.IO.File.ReadAllText("C:\\ProgramData\\ko.txt");
                kb = System.IO.File.ReadAllText("C:\\ProgramData\\kb.txt");
                s = System.IO.File.ReadAllText("C:\\ProgramData\\s.txt");
                j = System.IO.File.ReadAllText("C:\\ProgramData\\j.txt");
                ss = System.IO.File.ReadAllText("C:\\ProgramData\\ss.txt");
                sf = System.IO.File.ReadAllText("C:\\ProgramData\\sf.txt");
                jl = System.IO.File.ReadAllText("C:\\ProgramData\\jl.txt");
                nos = System.IO.File.ReadAllText("C:\\ProgramData\\nos.txt");
                dl = System.IO.File.ReadAllText("C:\\ProgramData\\dl.txt");
                dog = System.IO.File.ReadAllText("C:\\ProgramData\\dog.txt");
                label6.Text = ko;
                label7.Text = j;
                label8.Text = s;
                label9.Text = kb;
                label17.Text = ss;
                label18.Text = sf;
                label19.Text = jl;
                label26.Text = nos;
                label27.Text = dl;
                label28.Text = dog;
            }
            catch
            {
              System.IO.File.WriteAllText("C:\\ProgramData\\ko.txt","50000");
              System.IO.File.WriteAllText("C:\\ProgramData\\kb.txt","60000");
              System.IO.File.WriteAllText("C:\\ProgramData\\s.txt","200000");
              System.IO.File.WriteAllText("C:\\ProgramData\\j.txt","180000");
              System.IO.File.WriteAllText("C:\\ProgramData\\ss.txt","15000");
              System.IO.File.WriteAllText("C:\\ProgramData\\sf.txt","14000");
              System.IO.File.WriteAllText("C:\\ProgramData\\jl.txt","1000");
              System.IO.File.WriteAllText("C:\\ProgramData\\nos.txt","15000");
              System.IO.File.WriteAllText("C:\\ProgramData\\dl.txt","14000");
              System.IO.File.WriteAllText("C:\\ProgramData\\dog.txt","1000");
            }
            this.BackColor = Color.White;
        }

        private void glassButton1_Click(object sender, EventArgs e)
        {
        }
        private void glassButton2_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Visible = true;
                label6.Visible = true;
                label10.Visible = true;
            }
            else
            {
                textBox1.Visible = false;
                label6.Visible = false;
                label10.Visible = false;
                textBox1.Text = "";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox2.Visible = true;
                label7.Visible = true;
                label11.Visible = true;
            }
            else
            {
                textBox2.Visible = false;
                label7.Visible = false;
                label11.Visible = false;
                textBox2.Text = "";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox3.Visible = true;
                label8.Visible = true;
                label12.Visible = true;
            }
            else
            {
                textBox3.Visible = false;
                label8.Visible = false;
                label12.Visible = false;
                textBox3.Text = "";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                textBox4.Visible = true;
                label9.Visible = true;
                label13.Visible = true;
            }
            else
            {
                textBox4.Visible = false;
                label9.Visible = false;
                label13.Visible = false;
                textBox4.Text = "";
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                textBox5.Visible = true;
                label17.Visible = true;
                label20.Visible = true;
            }
            else
            {
                textBox5.Visible = false;
                label17.Visible = false;
                label20.Visible = false;
                textBox5.Text = "";
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                textBox6.Visible = true;
                label18.Visible = true;
                label21.Visible = true;
            }
            else
            {
                textBox6.Visible = false;
                label18.Visible = false;
                label21.Visible = false;
                textBox6.Text="";
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                textBox7.Visible = true;
                label19.Visible = true;
                label22.Visible = true;
            }
            else
            {
                textBox7.Visible = false;
                label19.Visible = false;
                label22.Visible = false;
                textBox7.Text = "";
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                textBox8.Visible = true;
                label29.Visible = true;
                label26.Visible = true;
            }
            else
            {
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                textBox8.Visible = false;
                label29.Visible = false;
                label26.Visible = false;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                radioButton4.Visible = true;
                radioButton5.Visible = true;
                radioButton6.Visible = true;
                textBox9.Visible = true;
                label30.Visible = true;
                label27.Visible = true;
            }
            else
            {
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                textBox9.Visible = false;
                label30.Visible = false;
                label27.Visible = false;
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                textBox10.Visible = true;
                label28.Visible = true;
                label31.Visible = true;
            }
            else
            {
                textBox10.Visible = false;
                label28.Visible = false;
                label31.Visible = false;
            }
        }
        int intx;
        private void button1_Click(object sender, EventArgs e)
        {
            label32.Text=( intx=aq1+ bq2+ cq3+ dq4+ fd1+ gd2+ hd3+ ln1+ mn2+ nn3).ToString();
            System.IO.File.WriteAllText("C:\\ProgramData\\factor.txt", intx.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                q1 = int.Parse(label6.Text);
                a = int.Parse(textBox1.Text);
                aq1 = q1 * a;
                label10.Text = (aq1).ToString();
            }
            catch
            {
                q1 = int.Parse(label6.Text);
                a = 0;
                aq1 = q1 * a;
                label10.Text = (aq1).ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                q2 = int.Parse(label7.Text);
                b = int.Parse(textBox2.Text);
                bq2 = q2 * b;
                label11.Text = bq2.ToString();
            }
            catch
            {
            q2 = int.Parse(label7.Text);
            b = 0;
            bq2 = q2 * b;
            label11.Text = bq2.ToString();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                q3 = int.Parse(label8.Text);
                c = int.Parse(textBox3.Text);
                cq3 = q3 * c;
                label12.Text = cq3.ToString();
            }
            catch
            {
                q3 = int.Parse(label8.Text);
                c = 0;
                cq3 = q3 * c;
                label12.Text = cq3.ToString();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                q4 = int.Parse(label9.Text);
                d = int.Parse(textBox4.Text);
                dq4 = d * q4;
                label13.Text = dq4.ToString();
            }
            catch
            {
                q4 = int.Parse(label9.Text);
                d = 0;
                dq4 = d * q4;
                label13.Text = dq4.ToString();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                f = int.Parse(textBox5.Text);
                d1 = int.Parse(label17.Text);
                fd1 = f * d1;
                label20.Text = fd1.ToString();
            }
            catch
            {
                f = 0;
                d1 = int.Parse(label17.Text);
                fd1 = f * d1;
                label20.Text = fd1.ToString();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                g = int.Parse(textBox6.Text);
                d2 = int.Parse(label18.Text);
                gd2 = g * d2;
                label21.Text = gd2.ToString();
            }
            catch
            {
                g = 0;
                d2 = int.Parse(label18.Text);
                gd2 = g * d2;
                label21.Text = gd2.ToString();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                h = int.Parse(textBox7.Text);
                d3 = int.Parse(label19.Text);
                hd3 = h * d3;
                label22.Text = hd3.ToString();
            }
            catch
            {
                h = 0;
                d3 = int.Parse(label19.Text);
                hd3 = h * d3;
                label22.Text = hd3.ToString();
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            n1 = int.Parse(label26.Text);
            l = int.Parse(textBox8.Text);
            ln1 = l * n1;
            label29.Text = ln1.ToString();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            m = int.Parse(textBox9.Text);
            n2 = int.Parse(label27.Text);
            mn2 = m * n2;
            label30.Text = mn2.ToString();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            n = int.Parse(textBox10.Text);
            n3 = int.Parse(label28.Text);
            nn3 = n * n3;
            label31.Text = nn3.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 iq = new Form3();
            string adress = textBox11.Text;
            if (textBox11.Text == "")
                MessageBox.Show("چیزی وارد نکردی");
            else
            {
                if (MessageBox.Show(adress, "ایا درست است", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.IO.File.WriteAllText("C:\\ProgramData\\factor.txt", (intx = aq1 + bq2 + cq3 + dq4 + fd1 + gd2 + hd3 + ln1 + mn2 + nn3).ToString());
                    iq.Show();
                }
            }
        }

        private void اشتراکجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 hhg = new Form4();
            hhg.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch
            {
                MessageBox.Show("مقدار ورودی اشتباه است");
            }
        }

        private void قیمتهایجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 llk = new Form5();
            llk.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = dataGridView1.Rows[comboBox1.SelectedIndex].Cells[2].Value.ToString();
            textBox12.Text = name;
            string address = dataGridView1.Rows[comboBox1.SelectedIndex].Cells[3].Value.ToString();
            textBox11.Text = address;
        }
    }
}
