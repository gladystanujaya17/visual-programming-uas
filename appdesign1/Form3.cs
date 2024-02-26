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
    public partial class Form3 : Form
    {
        string constring = "Data Source=DESKTOP-JKBJBEN\\SQLEXPRESS;Initial Catalog=Apotek;Integrated Security=True";
        DataSet DS = new DataSet();
        string vquery = "";
        string noJual;
        public Form3()
        {
            InitializeComponent();
        }

        public string IdPenjualan { get; set; }
        public string NomObat { get; set; }
        public string NamaObat { get; set; }
        public int Qty { get; set; }
        public string TglJual { get; set; }
        public string Jenis { get; set; }
        public int Harga { get; set; }
        public string Expired { get; set; }

        void tampil()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            DS.Clear();
            vquery = "select * from Penjualan";
            SqlDataAdapter DA = new SqlDataAdapter(vquery, conn);
            DA.Fill(DS, "dataPenjualan");
            dataGridView1.DataSource = DS.Tables["dataPenjualan"];
            conn.Close();
            conn.Dispose();
            DA.Dispose();
        }

        void tampilSatu()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            DS.Clear();
            vquery = "select * from Penjualan";
            SqlDataAdapter DA = new SqlDataAdapter(vquery, conn);
            DA.Fill(DS, "dataapotek");
            dataGridView1.DataSource = DS.Tables["dataapotek"];
            conn.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.obatTableAdapter.Fill(this.apotekDataSet1.Obat);
            tampil();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Total = int.Parse(textBox2.Text) * int.Parse(textBox6.Text.Replace(",","").Replace(".",""));
            if (textBox1.Text != "" && textBox2.Text != "" && dateTimePicker1.Text != "" && comboBox1.Text != "" && textBox6.Text != "" && dateTimePicker2.Text != "")
            {
                SqlConnection con = new SqlConnection(constring);

                SqlCommand insert = new SqlCommand("insert into Penjualan (obatID, NamaObat, JumlahObat, TanggalJual, JenisObat, HargaObat, total, Expired) " +
                    "values (@obatid, @namaobat, @jumlahobat, @tgljual, @jenisobat, @hargaobat,@total, @expired)", con);
                insert.Parameters.AddWithValue("@obatid", textBox4.Text);
                insert.Parameters.AddWithValue("@namaobat", textBox1.Text);
                insert.Parameters.AddWithValue("@jumlahobat", textBox2.Text);
                insert.Parameters.AddWithValue("@tgljual", dateTimePicker1.Value);
                insert.Parameters.AddWithValue("@jenisobat", comboBox1.Text);
                insert.Parameters.AddWithValue("@hargaobat", Convert.ToInt32(textBox6.Text.Replace(".", "").Replace(",", "")));
                insert.Parameters.AddWithValue("@total", Total);
                insert.Parameters.AddWithValue("@expired", dateTimePicker2.Value);
                


                SqlCommand cmd = new SqlCommand("UPDATE obat SET stokobat=stokobat -" + int.Parse(textBox2.Text) + " WHERE obatid='" + textBox4.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                insert.ExecuteNonQuery();
                con.Close();
                con.Dispose();
                insert.Dispose();
                cmd.Dispose();
                tampil();
                MessageBox.Show("Insert Anda berhasil");
                Bersih();
                textBox3.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ada data yang belum terisi");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && dateTimePicker1.Text != "" && 
                comboBox1.Text != "" && textBox6.Text != "" && dateTimePicker2.Text != "")
            {
                int Total = Convert.ToInt16(textBox2.Text) * Convert.ToInt16(textBox6.Text);
                SqlConnection con = new SqlConnection(constring);

                SqlCommand insert = new SqlCommand("UPDATE Penjualan SET obatid= @obatid, namaobat=@namaobat, jumlahobat=@jumlahobat, " +
                    "tanggaljual=@tanggaljual, jenisobat=@jenisobat, hargaobat=@hargaobat, expired= @expired, total=@total WHERE penjualanid=@penjualanid", con);
                insert.Parameters.AddWithValue("@penjualanid", textBox3.Text);
                insert.Parameters.AddWithValue("@obatid", textBox4.Text);
                insert.Parameters.AddWithValue("@namaobat", textBox1.Text);
                insert.Parameters.AddWithValue("@jumlahobat", textBox2.Text);
                insert.Parameters.AddWithValue("@tanggaljual", dateTimePicker1.Text);
                insert.Parameters.AddWithValue("@jenisobat", comboBox1.Text);
                insert.Parameters.AddWithValue("@hargaobat", Convert.ToInt32(textBox6.Text));
                insert.Parameters.AddWithValue("@expired", dateTimePicker2.Text);
                insert.Parameters.AddWithValue("@total", Total);
                SqlCommand UpdateData = new SqlCommand("UPDATE Obat SET stokobat = stokobat + " + Qty + " WHERE obatid='" + NomObat + "'", con);
                SqlCommand updateStok = new SqlCommand("UPDATE Obat SET stokobat = stokobat - " + Convert.ToInt32(textBox2.Text) + " WHERE obatid='" + textBox4.Text + "'", con);

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
                MessageBox.Show("Data penjualan sukses di update");
                tampil();
            }
            else
            {
                MessageBox.Show("Tidak bisa membuka koneksi");
            }
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
                    try
                    {
                        string cariObat = "SELECT namaobat,jenisobat,hargaobat,expired FROM obat WHERE obatid='" + textBox4.Text.Trim() + "'";
                        SqlConnection vconn = new SqlConnection(constring);
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cariObat, vconn);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        textBox1.Text = dt.Rows[0]["namaobat"].ToString();
                        comboBox1.Text = dt.Rows[0]["jenisobat"].ToString();
                        textBox6.Text = string.Format("{0:#,0}", int.Parse(dt.Rows[0]["hargaobat"].ToString()));
                        dateTimePicker2.Text = dt.Rows[0]["expired"].ToString();
                        vconn.Close();
                        vconn.Dispose();
                        dt.Dispose();
                        textBox2.Focus();
                    }
                    catch
                    {
                        MessageBox.Show("Kode obat tidak terdaftar....");
                        textBox4.Focus();
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["PenjualanID"].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["ObatID"].Value.ToString();
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["NamaObat"].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["JumlahObat"].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["JenisObat"].Value.ToString();
                textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells["HargaObat"].Value.ToString();
                dateTimePicker2.Text = dataGridView1.Rows[e.RowIndex].Cells["TanggalBeli"].Value.ToString();
            }
            catch
            {

            }  
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    int Total = Convert.ToInt16(textBox2.Text) * Convert.ToInt16(textBox6.Text.Replace(".","").Replace(",",""));
                    tbTotal.Text = string.Format("{0:#,0}", Total);
                    tbBayar.Focus();
                }
                catch
                {

                }
            }
        }

        private void tbBayar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    int Total = Convert.ToInt16(textBox2.Text.Replace(",","").Replace(".","")) * Convert.ToInt16(textBox6.Text.Replace(",","").Replace(".",""));
                    int Kembalian = Convert.ToInt32(tbBayar.Text) - Total;
                    tbKembalian.Text = string.Format("{0:N0}", Kembalian);
                }
                catch
                {

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && dateTimePicker1.Text != "" && comboBox1.Text != "" && 
                textBox6.Text != "" && dateTimePicker2.Text != "")
            {
                int Total = Convert.ToInt16(textBox2.Text) * Convert.ToInt16(textBox6.Text);
                string vquery = "DELETE FROM Penjualan WHERE penjualanid = '" + textBox3.Text + "'";
                SqlConnection vconn = new SqlConnection(constring);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(vquery, vconn);
                dataAdapter.Fill(DS, "dataPenjualan");
                MessageBox.Show("Data berhasil di hapus");
                tampil();
            }
            else
            {
                MessageBox.Show("Tidak bisa membuka koneksi");
            }
        }

        private void Bersih()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox6.Clear();
            tbTotal.Clear();
            tbBayar.Clear();
            tbKembalian.Clear();
            textBox4.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
