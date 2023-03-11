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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fixed_Bias_Circuit fixedbias = new Fixed_Bias_Circuit();
            fixedbias.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Emitter___Stabilized_Bias_Circuit emitterstabilized = new Emitter___Stabilized_Bias_Circuit();
            emitterstabilized.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Voltage_Divider_Bias voltagedivider = new Voltage_Divider_Bias();
            voltagedivider.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DC_Bias_with_Voltage_Feedback feedback = new DC_Bias_with_Voltage_Feedback();
            feedback.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PNP_Transistors pnp = new PNP_Transistors();
            pnp.Show();
        }
    }
}
