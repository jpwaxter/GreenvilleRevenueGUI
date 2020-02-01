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
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double contestantsNow, contestantsLast, rev;

            contestantsNow = Convert.ToDouble(txtThisYearCount.Text);
            contestantsLast = Convert.ToDouble(txtLastYearCount.Text);

            rev = contestantsNow * 25;


        }
    }
}
