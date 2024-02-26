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
    public partial class Form6 : Form
    {
        string constring = "Data Source=DESKTOP-JKBJBEN\\SQLEXPRESS;Initial Catalog=Apotek;Integrated Security=True";
        DataSet DS = new DataSet();
        string vquery = "";
        public Form6()
        {
            InitializeComponent();
        }

        void tampil()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            DS.Clear();
            vquery = "select * from Obat";
            SqlDataAdapter DA = new SqlDataAdapter(vquery, conn);
            DA.Fill(DS, "dataObat");
            dataGridView1.DataSource = DS.Tables["dataObat"];
            conn.Close();
        }

       
        private void Form6_Load(object sender, EventArgs e)
        {
            tampil();

        }

        private void but_tambah_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && comboBox1.Text != "" && textBox3.Text != "" && textBox4.Text != "" && dateTimePicker1.Text != "")
            {
                string query = "insert into Obat (ObatID, NamaObat, JenisObat, StokObat, HargaObat, Expired) values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + dateTimePicker1.Text + "')";
                SqlConnection con = new SqlConnection(constring);
                SqlDataAdapter DA = new SqlDataAdapter(query, con);
                DA.Fill(DS, "dataObat");
                tampil();
                MessageBox.Show("Insert Anda berhasil");
            }
            else
            {
                MessageBox.Show("Ada data yang belum terisi");
            }
        }

        private void but_edit_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && comboBox1.Text != "" && textBox3.Text != "" && textBox4.Text != "" && dateTimePicker1.Text != "")
            {
                string query = "update Obat set NamaObat='" + textBox2.Text + "', JenisObat = '" + comboBox1.Text + "', StokObat = '" + textBox3.Text + "', HargaObat = '" + textBox4.Text + "', Expired = '" + dateTimePicker1.Text + "'where ObatID='" + textBox1.Text + "'";
                SqlConnection con = new SqlConnection(constring);
                SqlDataAdapter DA = new SqlDataAdapter(query, con);
                DA.Fill(DS, "dataObat");
                tampil();
                MessageBox.Show("Update Anda berhasil");
            }
            else
            {
                MessageBox.Show("Ada data yang belum terisi");
            }
        }

        private void but_hapus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string query = "delete from Obat where ObatID='" + textBox1.Text + "'";
                SqlConnection con = new SqlConnection(constring);
                SqlDataAdapter DA = new SqlDataAdapter(query, con);
                DA.Fill(DS, "dataObat");
                tampil();
                MessageBox.Show("delete Anda berhasil");
            }
            else
            {
                MessageBox.Show("Data tidak dapat terhapus");
            }
        }

        private void but_kembali_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                SqlConnection vconn = new SqlConnection(constring);
                vconn.Open();
                DS.Clear();
                vquery = "SELECT * FROM Obat WHERE ObatID = '" + textBox1.Text + "'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(vquery, vconn);
                dataAdapter.Fill(DS, "dataObat");
                textBox2.DataBindings.Add("text", DS.Tables["dataObat"], "NamaObat");
                comboBox1.DataBindings.Add("text", DS.Tables["dataObat"], "JenisObat");
                textBox3.DataBindings.Add("text", DS.Tables["dataObat"], "StokObat");
                textBox4.DataBindings.Add("text", DS.Tables["dataObat"], "HargaObat");

            }
            catch
            {

            }
        }
    }
}
