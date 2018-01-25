using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggsInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClickToCalculate_Click(object sender, EventArgs e)
        {
            int eggs;
            int dozens;
            int eLeft;
            int chick1;
            int chick2;
            int chick3;
            int chick4;
            int chick5;
            string number1;
            string number2;
            string number3;
            string number4;
            string number5;

            number1 = txtChicken1.Text;
            chick1 = Convert.ToInt32(number1);
            number2 = txtChicken2.Text;
            chick2 = Convert.ToInt32(number2);
            number3 = txtChicken3.Text;
            chick3 = Convert.ToInt32(number3);
            number4 = txtChicken4.Text;
            chick4 = Convert.ToInt32(number4);
            number5 = txtChicken5.Text;
            chick5 = Convert.ToInt32(number5);

            eggs = chick1 + chick2 + chick3 + chick4 + chick5;
            dozens = eggs / 12;
            eLeft = eggs % dozens;


            lblResults.Text = eggs + " eggs is " + dozens + " dozen with " + eLeft + " left over.";
        }
    }
}
