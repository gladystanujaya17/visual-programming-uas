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

namespace appdesign1
{
    public partial class ReadFileSupplier : Form
    {
        OpenFileDialog openfile = new OpenFileDialog();
        string line = "";
        public ReadFileSupplier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openfile.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openfile.FileName);
                while(line != null)
                {
                    line = sr.ReadLine();
                    if(line != null)
                    {
                        //textBox1.Items.Add(line);
                        listBox1.Items.Add(line);
                    }
                }
                sr.Close();
            }
        }

        private void ReadFileSupplier_Load(object sender, EventArgs e)
        {
            openfile.Filter = "Text files (.txt)| *.txt";
        }
    }
}
