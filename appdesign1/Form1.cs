using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appdesign1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pembelianObatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 vform = new Form2();
            vform.MdiParent = this;
            vform.Show();
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void penjualanObatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 vform = new Form3();
            vform.MdiParent= this;
            vform.Show();
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void pembelianObatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 vform = new Form4();
            vform.MdiParent = this;
            vform.Show();
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void penjualanObatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form5 vform = new Form5();
            vform.MdiParent = this;
            vform.Show();
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void dataObatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 vform = new Form6();
            vform.MdiParent = this;
            vform.Show();
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void dataSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dataAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 vform = new Form7();
            vform.MdiParent = this;
            vform.Show();
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inputFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputFileStaff vform = new InputFileStaff();
            vform.MdiParent = this;
            vform.Show();
        }

        private void dataAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAkun vform = new DataAkun();
            vform.MdiParent = this;
            vform.Show();
        }

        private void inputFileObatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputFileObat vform = new InputFileObat();
            vform.MdiParent = this;
            vform.Show();
        }

        private void obatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaporanObat vform = new LaporanObat();
            vform.MdiParent = this;
            vform.Show();
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void dataSupplierToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DataSupplier vform = new DataSupplier();
            vform.MdiParent = this;
            vform.Show();
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void inputFileTransaksiPembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputFileSupplier vform = new InputFileSupplier();
            vform.MdiParent = this;
            vform.Show();
        }

        private void readFileSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadFileSupplier vform = new ReadFileSupplier();
            vform.MdiParent = this;
            vform.Show();
        }

        private void inputFileTransaksiPenjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadFileStaff vform = new ReadFileStaff();
            vform.MdiParent = this;
            vform.Show();
        }

        private void readFileObatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadFileObat vform = new ReadFileObat();
            vform.MdiParent = this;
            vform.Show();
        }
    }
}
