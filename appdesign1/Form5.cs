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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalReport3 vcr = new CrystalReport3();
            vcr.SetParameterValue("P_JENIS", comboBox1.Text);
            crystalReportViewer1.ReportSource = vcr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
