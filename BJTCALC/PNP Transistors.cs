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
    public partial class PNP_Transistors : Form
    {
        public PNP_Transistors()
        {
            InitializeComponent();
        }

        private void caltxt_Click(object sender, EventArgs e)
        {
            double vcc = Convert.ToDouble(vcctxt.Text);
            double r1 = Convert.ToDouble(r1txt.Text);
            double r2 = Convert.ToDouble(r2txt.Text);
            double r3 = Convert.ToDouble(r3txt.Text);
            double vbe = Convert.ToDouble(vbetxt.Text);
            double beta = Convert.ToDouble(betatxt.Text);


            double ib = (vcc - vbe) / (r1 / 1000 + (beta + 1) * r3 / 1000);
            double ie = (beta + 1) * ib;
            double ic = beta * ib;
            double vce = -vcc + ic * r2 / 1000 + ie * r3 / 1000;
            double ve = ie * r3 / 1000;
            double vb = vbe + ve;
            double vc = ic * r2 / 1000 + vcc;



            ibtxt.Text = ib.ToString();
            ictxt.Text = ic.ToString();
            vcetxt.Text = vce.ToString();
            vctxt.Text = vc.ToString();
            vbtxt.Text = vb.ToString();
            vetxt.Text = ve.ToString();
        }
    }
}
