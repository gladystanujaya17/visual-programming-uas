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
using System.IO;

namespace appdesign1
{
    public partial class InputFileSupplier : Form
    {
        string constring = "Data Source=DESKTOP-JKBJBEN\\SQLEXPRESS;Initial Catalog=Apotek;Integrated Security=True";
        DataSet DS = new DataSet();
        string vquery = "";
        public InputFileSupplier()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            tampil();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(@"d:\\supplier.txt");
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
    }
}
