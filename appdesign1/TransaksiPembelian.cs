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
    public partial class Form2 : Form
    {
        string constring = "Data Source=DESKTOP-JKBJBEN\\SQLEXPRESS;Initial Catalog=Apotek;Integrated Security=True";
        DataSet DS = new DataSet();
        string vquery = "";
        public Form2()
        {
            InitializeComponent();
        }

        public string IdPembelian { get; set; }
        public string NomObat { get; set; }
        public string NamaObat { get; set; }
        public int Qty { get; set; }
        public string TglBeli { get; set; }
        public string Jenis { get; set; }
        public int Harga { get; set; }
        public string Expaired { get; set; }
        

        private void label5_Click(object sender, EventArgs e)
        {

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

        void tampilSatu()
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

        private void Form2_Load(object sender, EventArgs e)
        {
            this.obatTableAdapter.Fill(this.apotekDataSet.Obat);
            tampil();
            
            textBox4.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int Total = Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox6.Text.Replace(".","").Replace(",",""));
            try
            {
                SqlConnection con = new SqlConnection(constring);
                SqlCommand insert = new SqlCommand("insert into Pembelian(obatid, namaobat, jumlahobat, tanggalbeli, jenisobat, hargaobat, expired,total) " +
                    "values (@obatid, @namaobat, @jumlahobat, @tanggalbeli, @jenisobat, @hargaobat, @expired,@total)", con);
                insert.Parameters.AddWithValue("@obatid", textBox4.Text);
                insert.Parameters.AddWithValue("@namaobat", textBox1.Text);
                insert.Parameters.AddWithValue("@jumlahobat", textBox2.Text);
                insert.Parameters.AddWithValue("@tanggalbeli", dateTimePicker1.Value);
                insert.Parameters.AddWithValue("@jenisobat", comboBox1.Text);
                insert.Parameters.AddWithValue("@hargaobat",Convert.ToInt32(textBox6.Text.Replace(".","").Replace(",","")));
                insert.Parameters.AddWithValue("@expired", dateTimePicker2.Value);
                insert.Parameters.AddWithValue("@total", Total);

                SqlCommand updateStok = new SqlCommand("UPDATE obat SET stokobat=stokobat + " + Convert.ToInt32(textBox2.Text) + " WHERE obatid='"+textBox4.Text+"'",con);

                con.Open();
                insert.ExecuteNonQuery();
                updateStok.ExecuteNonQuery();
                con.Close();
                con.Dispose();
                insert.Dispose();
                updateStok.Dispose();
                tampil();
                Bersih();
                MessageBox.Show("Data pembelian sukses tersimpan");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Tidak bisa membuka koneksi!");
            }
            finally
            {
              
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            Form8 vform = new Form8();
            vform.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int Total = Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox6.Text);
                SqlConnection con = new SqlConnection(constring);
                
                SqlCommand insert = new SqlCommand("UPDATE Pembelian SET obatid= @obatid, namaobat=@namaobat, jumlahobat=@jumlahobat, " +
                    "tanggalbeli=@tanggalbeli, jenisobat=@jenisobat, hargaobat=@hargaobat, expired= @expired,total=@total WHERE pembelianid=@pembelianid", con);
                insert.Parameters.AddWithValue("@pembelianid", textBox3.Text);
                insert.Parameters.AddWithValue("@obatid", textBox4.Text);
                insert.Parameters.AddWithValue("@namaobat", textBox1.Text);
                insert.Parameters.AddWithValue("@jumlahobat", textBox2.Text);
                insert.Parameters.AddWithValue("@tanggalbeli", dateTimePicker1.Text);
                insert.Parameters.AddWithValue("@jenisobat", comboBox1.Text);
                insert.Parameters.AddWithValue("@hargaobat", Convert.ToInt32(textBox6.Text));
                insert.Parameters.AddWithValue("@expired", dateTimePicker2.Text);
                insert.Parameters.AddWithValue("@total", Total);

                SqlCommand UpdateData = new SqlCommand("UPDATE Obat SET stokobat = stokobat - " + Qty + " WHERE obatid='" + NomObat + "'", con);
                SqlCommand updateStok = new SqlCommand("UPDATE Obat SET stokobat = stokobat + " + Convert.ToInt32(textBox2.Text) + " WHERE obatid='" + textBox4.Text + "'", con);

                con.Open();
                insert.ExecuteNonQuery();
                UpdateData.ExecuteNonQuery();
                updateStok.ExecuteNonQuery();
                con.Close();
                con.Dispose();
                insert.Dispose();
                updateStok.Dispose();
                UpdateData.Dispose();
                tampil();
                Bersih();
                MessageBox.Show("Data pembelian sukses di update");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan Edit!");
            }
        }

        private void Bersih()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox4.Focus();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (textBox4.Text == string.Empty)
                {
                    MessageBox.Show("Masukan kode obat dahulu..");
                    textBox4.Focus();
                    return;
                }
                else
                {
                    string cariObat = "SELECT namaobat,jenisobat,hargaobat,expired FROM obat WHERE obatid='" + textBox4.Text.Trim() + "'";
                    SqlConnection vconn = new SqlConnection(constring);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cariObat, vconn);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    textBox1.Text = dt.Rows[0]["namaobat"].ToString();
                    comboBox1.Text = dt.Rows[0]["jenisobat"].ToString();
                    string harga = dt.Rows[0]["hargaobat"].ToString();
                    textBox6.Text = string.Format("{0:#,0}", int.Parse(harga));
                    dateTimePicker2.Text = dt.Rows[0]["expired"].ToString();
                    vconn.Close();
                    vconn.Dispose();
                    dt.Dispose();
                    textBox2.Focus();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(constring);
                SqlCommand Hapus = new SqlCommand("DELETE FROM Pembelian WHERE pembelianid=@pembelianid", con);
                Hapus.Parameters.AddWithValue("@pembelianid", textBox3.Text);

                SqlCommand UpdateData = new SqlCommand("UPDATE Obat SET stokobat = stokobat - " + Qty + " WHERE obatid='" + NomObat + "'", con);

                con.Open();
                Hapus.ExecuteNonQuery();
                UpdateData.ExecuteNonQuery();
                con.Close();
                con.Dispose();
                Hapus.Dispose();
                UpdateData.Dispose();
                tampil();
                Bersih();
                MessageBox.Show("Data pembelian sukses di hapus");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan Hapus!");
            }
        }

       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["PembelianID"].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["ObatID"].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["NamaObat"].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["JumlahObat"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells["TanggalBeli"].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["JenisObat"].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells["HargaObat"].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[e.RowIndex].Cells["Expired"].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
