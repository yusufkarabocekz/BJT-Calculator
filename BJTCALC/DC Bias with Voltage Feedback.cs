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
    public partial class DC_Bias_with_Voltage_Feedback : Form
    {
        public DC_Bias_with_Voltage_Feedback()
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


            double ib = (vcc - vbe) / (r1/1000 + beta*(r2/1000 + r3/1000));
            double ic = beta * ib;
            double vc = vcc - ic * r2 / 1000;
            double ie = ib * (beta + 1);
            double ve = ie * r3 / 1000;
            double vce = vcc - ic * (r2/1000 + r3/1000);


            ibtxt.Text = ib.ToString();
            ictxt.Text = ic.ToString();
            vcetxt.Text = vce.ToString();
            vctxt.Text = vc.ToString();
            vetxt.Text = ve.ToString();

        }

        private void DC_Bias_with_Voltage_Feedback_Load(object sender, EventArgs e)
        {

        }
    }
}
