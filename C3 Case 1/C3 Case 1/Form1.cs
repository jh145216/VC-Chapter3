﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C3_Case_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int lastYearParticipants = Convert.ToInt32(txtlastYear.Text);
            int thisYearParticipants = Convert.ToInt32(txtThisYear.Text);
            int revenue = thisYearParticipants * 25;

            if (lastYearParticipants > thisYearParticipants)
            {
                int max = lastYearParticipants - thisYearParticipants;
                lblOutput.Text = "Last year participants "
                    + " were " + lastYearParticipants
                    + " and current year participants are "
                    + thisYearParticipants + ". Last year"
                    + " participation was mor with " + max
                    + " number of participants. Revenue"
                    + " for current year is $" + revenue + ".";
            }
            else
            {
                int max = thisYearParticipants - lastYearParticipants;
                lblOutput.Text = "Last year participants"
           + " were " + lastYearParticipants
           + " and current year participants are "
           + thisYearParticipants + ". This year "
           + "participation is more with " + max
           + " number of participants. Revenue "
           + "for current year is $" + revenue + ".";
            }
        }
    }
}
