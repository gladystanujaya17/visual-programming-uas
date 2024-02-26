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
    public partial class Form7 : Form
    {
        string constring = "Data Source=DESKTOP-JKBJBEN\\SQLEXPRESS;Initial Catalog=Apotek;Integrated Security=True";
        DataSet DS = new DataSet();
        string vquery = "";
        public Form7()
        {
            InitializeComponent();
        }
        void tampil()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            DS.Clear();
            vquery = "select * from Staff";
            SqlDataAdapter DA = new SqlDataAdapter(vquery, conn);
            DA.Fill(DS, "dataAnggota");
            dataGridView1.DataSource = DS.Tables["dataAnggota"];
            conn.Close();
        }

        private void but_tambah_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox5.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                string query = "insert into Staff (StaffID, StaffName, StaffTelp, StaffAddress, StaffEmail) " +
                    "values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox5.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
                SqlConnection con = new SqlConnection(constring);
                SqlDataAdapter DA = new SqlDataAdapter(query, con);
                DA.Fill(DS, "dataAnggota");
                tampil();
                MessageBox.Show("Insert Anda berhasil");
            }
            else
            {
                MessageBox.Show("Ada data yang belum terisi");
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void but_edit_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox5.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                string query = "update Staff set StaffName='" + textBox2.Text + "', StaffTelp = '" + textBox5.Text + "', StaffAddress = '" + textBox3.Text + "', StaffEmail = '" + textBox4.Text + "" +
                    "'where StaffID='" + textBox1.Text + "'";
                SqlConnection con = new SqlConnection(constring);
                SqlDataAdapter DA = new SqlDataAdapter(query, con);
                DA.Fill(DS, "dataAnggota");
                tampil();
                MessageBox.Show("Update Anda berhasil");
            }
            else
            {
                MessageBox.Show("Ada data yang belum terisi");
            }
        }

        private void but_kembali_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void but_hapus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string query = "delete from Staff where StaffID='" + textBox1.Text + "'";
                SqlConnection con = new SqlConnection(constring);
                SqlDataAdapter DA = new SqlDataAdapter(query, con);
                DA.Fill(DS, "dataAnggota");
                tampil();
                MessageBox.Show("delete Anda berhasil");
            }
            else
            {
                MessageBox.Show("Data tidak dapat terhapus");
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                SqlConnection vconn = new SqlConnection(constring);
                vconn.Open();
                DS.Clear();
                vquery = "SELECT * FROM Staff WHERE StaffID = '" + textBox1.Text + "'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(vquery, vconn);
                dataAdapter.Fill(DS, "dataAnggota");
                textBox2.DataBindings.Add("text", DS.Tables["dataAnggota"], "StaffName");
                textBox5.DataBindings.Add("text", DS.Tables["dataAnggota"], "StaffTelp");
                textBox3.DataBindings.Add("text", DS.Tables["dataAnggota"], "StaffAddress");
                textBox4.DataBindings.Add("text", DS.Tables["dataAnggota"], "StaffEmail");
            }
            catch
            {

            }
        }
    }
}
