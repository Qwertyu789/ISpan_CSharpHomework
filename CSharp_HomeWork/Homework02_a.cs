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
        public Homework02_a()
        {
            InitializeComponent();
        }

        int Target, TimeLimit, TimeMonth, DP;
        double Rate, Rate00, monthpayrate, TargetR, monthpay;

        private String bTarget, bTime, bRate, bmonthpay, btotalpay;

        public double Monthpay()
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

        private void ReportBut_Click(object sender, EventArgs e)
        {
            Math.Round(Monthpay());          
            bTarget = TargetTB01.Text;
            bTime = TimelimitTB01.Text;
            bRate = RateTB01.Text;
            TimeLimit = Convert.ToInt32(TimelimitTB01.Text);
            TimeMonth = TimeLimit * 12;
            bmonthpay = Math.Round(Monthpay()).ToString();
            btotalpay = Math.Round((Monthpay()) * TimeMonth).ToString();
            Homework02_b reportb = new Homework02_b(this);
            reportb.Show();
        }

        //public Homework02_a getHomework02_A()
        //{
        //    return this;
        //}

        internal void PMTBut_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Math.Round(Monthpay()).ToString());
}

        internal void TotalPayBut_Click(object sender, EventArgs e)
        {

            MessageBox.Show((Math.Round(Monthpay()) * TimeMonth).ToString());

        }

        public string getTarget()
        {
            return bTarget;
        }
        public string getTime()
        {
            return bTime;
        }
        public string getRate()
        {
            return bRate;
        }
        public string getNonthpay()
        {
            return bmonthpay;
        }
        public string getTotalpay()
        {
            return btotalpay;
        }


        /*private void FortestBut_Click(object sender, EventArgs e)
        {
            string TargetST = TargetTB01.Text;
            int Target = Convert.ToInt32(TargetST);
            MessageBox.Show();
        }*/
    }
}

