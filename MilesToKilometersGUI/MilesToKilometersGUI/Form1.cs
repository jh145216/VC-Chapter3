using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilesToKilometersGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCulcaluate_Click(object sender, EventArgs e)
        {
            double miles;
            double milesToKilo = 1.6;
            double milesToKiloConversion;

            miles = Convert.ToDouble(txtMiles.Text);

            milesToKiloConversion = miles * milesToKilo;

            lblResults.Text = milesToKiloConversion.ToString("n");
        }
    }
}
