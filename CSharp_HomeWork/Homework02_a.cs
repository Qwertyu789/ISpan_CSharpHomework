using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_HomeWork
{
    
    public partial class Homework02_a : Form
    {



        public int Changeint(string putin)
        {
            int changeintresult = Convert.ToInt32(putin);
            return changeintresult;
        }
        public Homework02_a()
        {
            InitializeComponent();

        }

        int Target, TimeLimit, TimeMonth, DP;
        double Rate, Rate00, monthpayrate, TargetR, monthpay;

        private void ReportBut_Click(object sender, EventArgs e)
        {

        }

        double Moonthpay()
        {
            Target = Convert.ToInt32(TargetTB01.Text);
            TimeLimit = Convert.ToInt32(TimelimitTB01.Text);
            TimeMonth = TimeLimit * 12;
            Rate = Convert.ToInt32(RateTB01.Text);
            DP = Convert.ToInt32(DPTB.Text);
            Rate00 = 1 / (1 + ((Rate / 100) / 12));
            monthpayrate = 0;
            TargetR = (Target - DP);
            for (int i = 1; i <= TimeMonth; i++)
            {
                monthpayrate += Math.Pow(Rate00, i);
            }
            monthpay = TargetR / monthpayrate;
            return monthpay;
        }
        internal void PMTBut_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Math.Round(Moonthpay()).ToString());
}

        internal void TotalPayBut_Click(object sender, EventArgs e)
        {

            MessageBox.Show((Math.Round(Moonthpay()) * TimeMonth).ToString());

        }

        

        /*private void FortestBut_Click(object sender, EventArgs e)
        {
            string TargetST = TargetTB01.Text;
            int Target = Convert.ToInt32(TargetST);
            MessageBox.Show();
        }*/
    }
}
