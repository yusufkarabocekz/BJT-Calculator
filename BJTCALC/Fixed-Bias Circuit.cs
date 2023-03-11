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
    public partial class Fixed_Bias_Circuit : Form
    {
        public Fixed_Bias_Circuit()
        {
            InitializeComponent();
        }

        private void Fixed_Bias_Circuit_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vcc = Convert.ToDouble(vcctxt.Text);
            double r1 = Convert.ToDouble(r1txt.Text);
            double r2 = Convert.ToDouble(r2txt.Text);
            double vbe = Convert.ToDouble(vbetxt.Text);
            double beta = Convert.ToDouble(betatxt.Text);

            double ib = (vcc - vbe) /r1*1000;
            double ic = ib*beta;
            double vce = vcc - (ic * r2)/1000;
            double vc = vcc - ic * r2/1000;
            double vb = vcc - ib * r1/1000;
            double ve = (vc - vce)/1000;

            ibtxt.Text = ib.ToString();
            ictxt.Text = ic.ToString();
            vcetxt.Text = vce.ToString();
            vctxt.Text = vc.ToString();
            vbtxt.Text = vb.ToString();
            vetxt.Text = ve.ToString();


        }
    }
}
