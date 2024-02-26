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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CrystalReport2 vcr = new CrystalReport2();
            vcr.SetParameterValue("P_JENIS", comboBox1.Text);
            crystalReportViewer1.ReportSource = vcr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
