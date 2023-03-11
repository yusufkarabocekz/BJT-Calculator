using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BJTCALC
{
    public partial class Voltage_Divider_Bias : Form
    {
        public Voltage_Divider_Bias()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Voltage_Divider_Bias_Load(object sender, EventArgs e)
        {

        }

        private void caltxt_Click(object sender, EventArgs e)
        {
            double vcc = Convert.ToDouble(vcctxt.Text);
            double r1 = Convert.ToDouble(r1txt.Text);
            double r2 = Convert.ToDouble(r2txt.Text);
            double r3 = Convert.ToDouble(r3txt.Text);
            double r4 = Convert.ToDouble(r4txt.Text);
            double vbe = Convert.ToDouble(vbetxt.Text);
            double beta = Convert.ToDouble(betatxt.Text);


            double eth = (vcc * r2 / 1000) / (r1 / 1000 + r2 / 1000);
            double rth = ((r1 * r2) / (r1 + r2)/1000);
            double ib = (eth - vbe) / (rth + (beta+1)*r4/1000);
            double ic = beta * ib;
            double ie = (beta + 1) * ib;
            double vce = vcc - ic * r3 / 1000 - ie * r4 / 1000;
            double vc = vcc - ic * r3 / 1000;
            double ve = ie * r4/1000;
            double vb = ve + vbe;

            ibtxt.Text = ib.ToString();
            ictxt.Text = ic.ToString();
            vcetxt.Text = vce.ToString();
            vctxt.Text = vc.ToString();
            vbtxt.Text = vb.ToString();
            vetxt.Text = ve.ToString();
        }
    }
}
