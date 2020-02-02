using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleRevenueGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblComparison.Text = "";
            lblRevenue.Text = "This Year's Revenue: $0";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double contestantsNow, contestantsLast, rev;

            contestantsNow = Convert.ToDouble(txtThisYearCount.Text);
            contestantsLast = Convert.ToDouble(txtLastYearCount.Text);

            rev = contestantsNow * 25;

            lblRevenue.Text = "This Year's Revenue: " + rev.ToString("C2");
            if (contestantsNow > contestantsLast)
                lblComparison.Text = "There are " + (contestantsNow - contestantsLast) + " more contestants this year than last year.";
            else if (contestantsNow < contestantsLast)
                lblComparison.Text = "There are " + (contestantsLast - contestantsNow) + " fewer contestants this year than last year.";
            else
                lblComparison.Text = "Both years have the same amount of contestants.";
        }
    }
}
