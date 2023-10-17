using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odevv15_uygulama_1550
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            double tutar;
            tutar=Convert.ToDouble(txtTutar.Text);
            if (rb1Taksitli.Checked == true || rb2Taksitli.Checked == true)
            {
                tutar += (tutar * 0.05);
            }
            if (rb3Taksitli.Checked == true || rb4Taksitli.Checked == true)
            {
                tutar += (tutar * 0.10);
            }
            MessageBox.Show(("odenecek toplam tutar:") + tutar.ToString() + "TL");
        }
    }
}
