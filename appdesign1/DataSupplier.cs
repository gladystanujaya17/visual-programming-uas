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
    public partial class DataSupplier : Form
    {
        string constring = "Data Source=DESKTOP-JKBJBEN\\SQLEXPRESS;Initial Catalog=Apotek;Integrated Security=True";
        DataSet DS = new DataSet();
        string vquery = "";
        public DataSupplier()
        {
            InitializeComponent();
        }

        private void but_tambah_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                string query = "insert into Supplier (SupplierID, SupplierName, SupplierTelp, SupplierAddress) " +
                    "values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
                SqlConnection con = new SqlConnection(constring);
                SqlDataAdapter DA = new SqlDataAdapter(query, con);
                DA.Fill(DS, "dataSupplier");
                tampil();
                MessageBox.Show("Insert Anda berhasil");
            }
            else
            {
                MessageBox.Show("Ada data yang belum terisi");
            }
        }

        void tampil()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            DS.Clear();
            vquery = "select * from Supplier";
            SqlDataAdapter DA = new SqlDataAdapter(vquery, conn);
            DA.Fill(DS, "dataSupplier");
            dataGridView1.DataSource = DS.Tables["dataSupplier"];
            conn.Close();
        }

        private void DataSupplier_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void but_kembali_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void but_edit_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                string query = "update Supplier set SupplierName='" + textBox2.Text + "', SupplierTelp = '" + textBox3.Text + "', " +
                    "SupplierAddress = '" + textBox4.Text + "'where SupplierID='" + textBox1.Text + "'";
                SqlConnection con = new SqlConnection(constring);
                SqlDataAdapter DA = new SqlDataAdapter(query, con);
                DA.Fill(DS, "dataSupplier");
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
                string query = "delete from Supplier where SupplierID='" + textBox1.Text + "'";
                SqlConnection con = new SqlConnection(constring);
                SqlDataAdapter DA = new SqlDataAdapter(query, con);
                DA.Fill(DS, "dataSupplier");
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
                vquery = "SELECT * FROM Supplier WHERE SupplierID = '" + textBox1.Text + "'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(vquery, vconn);
                dataAdapter.Fill(DS, "dataSupplier");
                textBox2.DataBindings.Add("text", DS.Tables["dataSupplier"], "SupplierName");
                //comboBox1.DataBindings.Add("text", DS.Tables["dataObat"], "JenisObat");
                textBox3.DataBindings.Add("text", DS.Tables["dataSupplier"], "SupplierTelp");
                textBox4.DataBindings.Add("text", DS.Tables["dataSupplier"], "SupplierAddress");

            }
            catch
            {

            }
        }
    }
}
