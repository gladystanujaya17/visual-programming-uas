using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace appdesign1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-E77432C0\SQLEXPRESS;Initial Catalog=Apotek;Integrated Security=True");
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-JKBJBEN\SQLEXPRESS;Initial Catalog=Apotek;Integrated Security=True");
            string query = "Select * from Admin Where Username = '" + textBox1.Text.Trim() + "' and Password = '" + textBox2.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                Form1 objForm1 = new Form1();
                this.Hide();
                objForm1.Show();
            }
            else
            {
                MessageBox.Show("Username dan Password Salah");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
