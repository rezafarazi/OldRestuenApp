using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace WindowsFormsApplication144
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int a;
        private void Form4_Load(object sender, EventArgs e)
        {
            Random l = new Random();
            a = l.Next(10000, 999999);
            label6.Text = a.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                MessageBox.Show("چیزی وارد نکردی");
            else
            {
                OleDbConnection h = new OleDbConnection();
                h.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Database1.mdb";
                OleDbCommand j = new OleDbCommand("insert into table1(name,family,nname,address,ss) values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"',"+a+")",h);
                h.Open();
                j.ExecuteNonQuery();
                h.Close();
                this.table1TableAdapter.Fill(this.database1DataSet.Table1);

                if (MessageBox.Show("ثبت شد") == DialogResult.OK)
                    Application.Restart();
            }
        

        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
