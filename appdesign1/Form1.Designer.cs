namespace appdesign1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.akunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataAkunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataObatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pembelianObatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penjualanObatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pembelianObatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.penjualanObatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.obatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputFileObatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputFileTransaksiPembelianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputFileTransaksiPenjualanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.readFileObatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readFileSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.akunToolStripMenuItem,
            this.masterToolStripMenuItem,
            this.transaksiToolStripMenuItem,
            this.laporanToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.logoutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // akunToolStripMenuItem
            // 
            this.akunToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataAkunToolStripMenuItem});
            this.akunToolStripMenuItem.Name = "akunToolStripMenuItem";
            this.akunToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.akunToolStripMenuItem.Text = "Akun";
            // 
            // dataAkunToolStripMenuItem
            // 
            this.dataAkunToolStripMenuItem.Name = "dataAkunToolStripMenuItem";
            this.dataAkunToolStripMenuItem.Size = new System.Drawing.Size(197, 34);
            this.dataAkunToolStripMenuItem.Text = "Data Akun";
            this.dataAkunToolStripMenuItem.Click += new System.EventHandler(this.dataAkunToolStripMenuItem_Click);
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataObatToolStripMenuItem,
            this.dataAdminToolStripMenuItem,
            this.dataSupplierToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // dataObatToolStripMenuItem
            // 
            this.dataObatToolStripMenuItem.Name = "dataObatToolStripMenuItem";
            this.dataObatToolStripMenuItem.Size = new System.Drawing.Size(221, 34);
            this.dataObatToolStripMenuItem.Text = "Data Obat";
            this.dataObatToolStripMenuItem.Click += new System.EventHandler(this.dataObatToolStripMenuItem_Click);
            // 
            // dataAdminToolStripMenuItem
            // 
            this.dataAdminToolStripMenuItem.Name = "dataAdminToolStripMenuItem";
            this.dataAdminToolStripMenuItem.Size = new System.Drawing.Size(221, 34);
            this.dataAdminToolStripMenuItem.Text = "Data Staff";
            this.dataAdminToolStripMenuItem.Click += new System.EventHandler(this.dataAdminToolStripMenuItem_Click);
            // 
            // dataSupplierToolStripMenuItem
            // 
            this.dataSupplierToolStripMenuItem.Name = "dataSupplierToolStripMenuItem";
            this.dataSupplierToolStripMenuItem.Size = new System.Drawing.Size(221, 34);
            this.dataSupplierToolStripMenuItem.Text = "Data Supplier";
            this.dataSupplierToolStripMenuItem.Click += new System.EventHandler(this.dataSupplierToolStripMenuItem_Click_1);
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pembelianObatToolStripMenuItem,
            this.penjualanObatToolStripMenuItem});
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.transaksiToolStripMenuItem.Text = "Transaksi ";
            // 
            // pembelianObatToolStripMenuItem
            // 
            this.pembelianObatToolStripMenuItem.Name = "pembelianObatToolStripMenuItem";
            this.pembelianObatToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.pembelianObatToolStripMenuItem.Text = "Pembelian Obat";
            this.pembelianObatToolStripMenuItem.Click += new System.EventHandler(this.pembelianObatToolStripMenuItem_Click);
            // 
            // penjualanObatToolStripMenuItem
            // 
            this.penjualanObatToolStripMenuItem.Name = "penjualanObatToolStripMenuItem";
            this.penjualanObatToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.penjualanObatToolStripMenuItem.Text = "Penjualan Obat";
            this.penjualanObatToolStripMenuItem.Click += new System.EventHandler(this.penjualanObatToolStripMenuItem_Click);
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pembelianObatToolStripMenuItem1,
            this.penjualanObatToolStripMenuItem1,
            this.obatToolStripMenuItem});
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.laporanToolStripMenuItem.Text = "Laporan";
            // 
            // pembelianObatToolStripMenuItem1
            // 
            this.pembelianObatToolStripMenuItem1.Name = "pembelianObatToolStripMenuItem1";
            this.pembelianObatToolStripMenuItem1.Size = new System.Drawing.Size(240, 34);
            this.pembelianObatToolStripMenuItem1.Text = "Pembelian Obat";
            this.pembelianObatToolStripMenuItem1.Click += new System.EventHandler(this.pembelianObatToolStripMenuItem1_Click);
            // 
            // penjualanObatToolStripMenuItem1
            // 
            this.penjualanObatToolStripMenuItem1.Name = "penjualanObatToolStripMenuItem1";
            this.penjualanObatToolStripMenuItem1.Size = new System.Drawing.Size(240, 34);
            this.penjualanObatToolStripMenuItem1.Text = "Penjualan Obat";
            this.penjualanObatToolStripMenuItem1.Click += new System.EventHandler(this.penjualanObatToolStripMenuItem1_Click);
            // 
            // obatToolStripMenuItem
            // 
            this.obatToolStripMenuItem.Name = "obatToolStripMenuItem";
            this.obatToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.obatToolStripMenuItem.Text = "Obat";
            this.obatToolStripMenuItem.Click += new System.EventHandler(this.obatToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputFileToolStripMenuItem,
            this.inputFileObatToolStripMenuItem,
            this.inputFileTransaksiPembelianToolStripMenuItem,
            this.inputFileTransaksiPenjualanToolStripMenuItem,
            this.readFileObatToolStripMenuItem,
            this.readFileSupplierToolStripMenuItem});
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.logoutToolStripMenuItem.Text = "File";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // inputFileToolStripMenuItem
            // 
            this.inputFileToolStripMenuItem.Name = "inputFileToolStripMenuItem";
            this.inputFileToolStripMenuItem.Size = new System.Drawing.Size(341, 34);
            this.inputFileToolStripMenuItem.Text = "Input File Staff";
            this.inputFileToolStripMenuItem.Click += new System.EventHandler(this.inputFileToolStripMenuItem_Click);
            // 
            // inputFileObatToolStripMenuItem
            // 
            this.inputFileObatToolStripMenuItem.Name = "inputFileObatToolStripMenuItem";
            this.inputFileObatToolStripMenuItem.Size = new System.Drawing.Size(341, 34);
            this.inputFileObatToolStripMenuItem.Text = "Input File Obat";
            this.inputFileObatToolStripMenuItem.Click += new System.EventHandler(this.inputFileObatToolStripMenuItem_Click);
            // 
            // inputFileTransaksiPembelianToolStripMenuItem
            // 
            this.inputFileTransaksiPembelianToolStripMenuItem.Name = "inputFileTransaksiPembelianToolStripMenuItem";
            this.inputFileTransaksiPembelianToolStripMenuItem.Size = new System.Drawing.Size(341, 34);
            this.inputFileTransaksiPembelianToolStripMenuItem.Text = "Input File Supplier";
            this.inputFileTransaksiPembelianToolStripMenuItem.Click += new System.EventHandler(this.inputFileTransaksiPembelianToolStripMenuItem_Click);
            // 
            // inputFileTransaksiPenjualanToolStripMenuItem
            // 
            this.inputFileTransaksiPenjualanToolStripMenuItem.Name = "inputFileTransaksiPenjualanToolStripMenuItem";
            this.inputFileTransaksiPenjualanToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.inputFileTransaksiPenjualanToolStripMenuItem.Text = "Read File Staff";
            this.inputFileTransaksiPenjualanToolStripMenuItem.Click += new System.EventHandler(this.inputFileTransaksiPenjualanToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(85, 29);
            this.logoutToolStripMenuItem1.Text = "Logout";
            this.logoutToolStripMenuItem1.Click += new System.EventHandler(this.logoutToolStripMenuItem1_Click);
            // 
            // readFileObatToolStripMenuItem
            // 
            this.readFileObatToolStripMenuItem.Name = "readFileObatToolStripMenuItem";
            this.readFileObatToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.readFileObatToolStripMenuItem.Text = "Read File Obat";
            this.readFileObatToolStripMenuItem.Click += new System.EventHandler(this.readFileObatToolStripMenuItem_Click);
            // 
            // readFileSupplierToolStripMenuItem
            // 
            this.readFileSupplierToolStripMenuItem.Name = "readFileSupplierToolStripMenuItem";
            this.readFileSupplierToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.readFileSupplierToolStripMenuItem.Text = "Read File Supplier";
            this.readFileSupplierToolStripMenuItem.Click += new System.EventHandler(this.readFileSupplierToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem akunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataAkunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataObatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pembelianObatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penjualanObatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pembelianObatToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem penjualanObatToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inputFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputFileObatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputFileTransaksiPembelianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputFileTransaksiPenjualanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readFileObatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readFileSupplierToolStripMenuItem;
    }
}

