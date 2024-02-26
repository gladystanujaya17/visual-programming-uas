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
    public partial class Form8 : Form
    {
        string constring = "Data Source=DESKTOP-JKBJBEN\\SQLEXPRESS;Initial Catalog=Apotek;Integrated Security=True";
        //string constring = "Data Source=LAPTOP-E77432C0\\SQLEXPRESS;Initial Catalog=Apotek;Integrated Security=True";
        //string constring = "Data Source=DESKTOP-80HKNEJ\\SQLEXPRESS;Initial Catalog=Apotek;Integrated Security=True";
        
        DataSet DS = new DataSet();
        string vquery = "";
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 vform = new Form2();
            //vform.MdiParent = this;
            vform.Show();
            
        }

        void tampil()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            DS.Clear();
            vquery = "select * from Pembelian";
            SqlDataAdapter DA = new SqlDataAdapter(vquery, conn);
            DA.Fill(DS, "dataPembelian");
            dataGridView1.DataSource = DS.Tables["dataPembelian"];
            conn.Close();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Form2 frm1 = new Form2();
            frm1.IdPembelian = dataGridView1.Rows[e.RowIndex].Cells["pembelianid"].Value.ToString();
            frm1.NomObat = dataGridView1.Rows[e.RowIndex].Cells["obatid"].Value.ToString();
            frm1.NamaObat = dataGridView1.Rows[e.RowIndex].Cells["namaobat"].Value.ToString();
            frm1.Jenis = dataGridView1.Rows[e.RowIndex].Cells["jenisobat"].Value.ToString();
            frm1.Qty = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["jumlahobat"].Value.ToString());
            frm1.Harga = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["hargaobat"].Value.ToString());
            frm1.TglBeli = dataGridView1.Rows[e.RowIndex].Cells["tanggalbeli"].Value.ToString();
            frm1.Expaired = dataGridView1.Rows[e.RowIndex].Cells["expired"].Value.ToString();
            frm1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form2 frm1 = new Form2();
            frm1.IdPembelian = dataGridView1.Rows[e.RowIndex].Cells["pembelianid"].Value.ToString();
            frm1.NomObat = dataGridView1.Rows[e.RowIndex].Cells["obatid"].Value.ToString();
            frm1.NamaObat = dataGridView1.Rows[e.RowIndex].Cells["namaobat"].Value.ToString();
            frm1.Jenis = dataGridView1.Rows[e.RowIndex].Cells["jenisobat"].Value.ToString();
            frm1.Qty = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["jumlahobat"].Value.ToString());
            frm1.Harga = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["hargaobat"].Value.ToString());
            frm1.TglBeli = dataGridView1.Rows[e.RowIndex].Cells["tanggalbeli"].Value.ToString();
            frm1.Expaired = dataGridView1.Rows[e.RowIndex].Cells["expired"].Value.ToString();
            frm1.Show();
        }
    }
}
