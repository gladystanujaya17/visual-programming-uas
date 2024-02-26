using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace appdesign1
{
    public partial class InputFileObat : Form
    {
        string constring = "Data Source=DESKTOP-JKBJBEN\\SQLEXPRESS;Initial Catalog=Apotek;Integrated Security=True";
        DataSet DS = new DataSet();
        string vquery = "";
        public InputFileObat()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter(@"d:\\obat.txt");
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j <= dataGridView1.Rows.Count; j++)
                {
                    writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString());
                }
                writer.WriteLine("");
            }
            writer.Close();
            MessageBox.Show("Data has been exported");
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

        private void button1_Click(object sender, EventArgs e)
        {
            tampil();
        }
    }
}
