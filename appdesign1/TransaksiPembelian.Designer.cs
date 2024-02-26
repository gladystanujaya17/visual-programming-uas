namespace appdesign1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.obatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaObatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisObatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokObatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaObatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apotekDataSet = new appdesign1.ApotekDataSet();
            this.obatTableAdapter = new appdesign1.ApotekDataSetTableAdapters.ObatTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apotekDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 551);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Keluar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(40, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 355);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Pembelian Obat";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tablet",
            "Sirup",
            "Bubuk",
            "Suntik",
            "Botol"});
            this.comboBox1.Location = new System.Drawing.Point(190, 225);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(254, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(190, 65);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(254, 26);
            this.textBox4.TabIndex = 0;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "No. Obat";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(190, 300);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(254, 26);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(190, 186);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(254, 26);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tanggal Expired";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(190, 262);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(254, 26);
            this.textBox6.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Harga Obat";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(190, 29);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(139, 26);
            this.textBox3.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Jenis Obat";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(190, 146);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(254, 26);
            this.textBox2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Jumlah Barang";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(190, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nama Obat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tanggal Pembelian";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Pembelian";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(630, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1212, 332);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(134, 551);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 52);
            this.button3.TabIndex = 2;
            this.button3.Text = "Hapus";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 422);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(135, 422);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 52);
            this.button4.TabIndex = 0;
            this.button4.Text = "Simpan";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(630, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Data Pembelian Obat";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.obatIDDataGridViewTextBoxColumn,
            this.namaObatDataGridViewTextBoxColumn,
            this.jenisObatDataGridViewTextBoxColumn,
            this.stokObatDataGridViewTextBoxColumn,
            this.hargaObatDataGridViewTextBoxColumn,
            this.expiredDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.obatBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(630, 426);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1212, 332);
            this.dataGridView2.TabIndex = 13;
            // 
            // obatIDDataGridViewTextBoxColumn
            // 
            this.obatIDDataGridViewTextBoxColumn.DataPropertyName = "ObatID";
            this.obatIDDataGridViewTextBoxColumn.HeaderText = "ObatID";
            this.obatIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.obatIDDataGridViewTextBoxColumn.Name = "obatIDDataGridViewTextBoxColumn";
            this.obatIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // namaObatDataGridViewTextBoxColumn
            // 
            this.namaObatDataGridViewTextBoxColumn.DataPropertyName = "NamaObat";
            this.namaObatDataGridViewTextBoxColumn.HeaderText = "NamaObat";
            this.namaObatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namaObatDataGridViewTextBoxColumn.Name = "namaObatDataGridViewTextBoxColumn";
            this.namaObatDataGridViewTextBoxColumn.Width = 150;
            // 
            // jenisObatDataGridViewTextBoxColumn
            // 
            this.jenisObatDataGridViewTextBoxColumn.DataPropertyName = "JenisObat";
            this.jenisObatDataGridViewTextBoxColumn.HeaderText = "JenisObat";
            this.jenisObatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.jenisObatDataGridViewTextBoxColumn.Name = "jenisObatDataGridViewTextBoxColumn";
            this.jenisObatDataGridViewTextBoxColumn.Width = 150;
            // 
            // stokObatDataGridViewTextBoxColumn
            // 
            this.stokObatDataGridViewTextBoxColumn.DataPropertyName = "StokObat";
            this.stokObatDataGridViewTextBoxColumn.HeaderText = "StokObat";
            this.stokObatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stokObatDataGridViewTextBoxColumn.Name = "stokObatDataGridViewTextBoxColumn";
            this.stokObatDataGridViewTextBoxColumn.Width = 150;
            // 
            // hargaObatDataGridViewTextBoxColumn
            // 
            this.hargaObatDataGridViewTextBoxColumn.DataPropertyName = "HargaObat";
            this.hargaObatDataGridViewTextBoxColumn.HeaderText = "HargaObat";
            this.hargaObatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hargaObatDataGridViewTextBoxColumn.Name = "hargaObatDataGridViewTextBoxColumn";
            this.hargaObatDataGridViewTextBoxColumn.Width = 150;
            // 
            // expiredDataGridViewTextBoxColumn
            // 
            this.expiredDataGridViewTextBoxColumn.DataPropertyName = "Expired";
            this.expiredDataGridViewTextBoxColumn.HeaderText = "Expired";
            this.expiredDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.expiredDataGridViewTextBoxColumn.Name = "expiredDataGridViewTextBoxColumn";
            this.expiredDataGridViewTextBoxColumn.Width = 150;
            // 
            // obatBindingSource
            // 
            this.obatBindingSource.DataMember = "Obat";
            this.obatBindingSource.DataSource = this.apotekDataSet;
            // 
            // apotekDataSet
            // 
            this.apotekDataSet.DataSetName = "ApotekDataSet";
            this.apotekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // obatTableAdapter
            // 
            this.obatTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(630, 399);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Data Obat";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1858, 906);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Transaksi Pembelian Obat";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apotekDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView2;
        private ApotekDataSet apotekDataSet;
        private System.Windows.Forms.BindingSource obatBindingSource;
        private ApotekDataSetTableAdapters.ObatTableAdapter obatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn obatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaObatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisObatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokObatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaObatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiredDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label10;
    }
}