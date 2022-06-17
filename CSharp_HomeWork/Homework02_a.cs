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
        public int changeint(string putin)
        {
            int changeintresult = Convert.ToInt32(putin);
            return changeintresult;
        }
        public Homework02_a()
        {
            InitializeComponent();
        }

        private void PMTBut_Click(object sender, EventArgs e)
        {


            //string TargetST = TargetLB01.Text;
            //int Target = Convert.ToInt32(TargetST);
            int Target = Convert.ToInt32(TargetTB01.Text);
            int TimeLimit = Convert.ToInt32(TimelimitTB01.Text);
            double Rate = Convert.ToInt32(RateTB01.Text);
            int DP = Convert.ToInt32(DPTB.Text);
            double moonrate = 1 + (Rate / 12.0);

            //公式錯了
            int yearrate = (int)(Math.Pow(moonrate,12)*(Rate/12)/(Math.Pow(moonrate, 12) - 1));
            int moonpay = (Target - DP) * yearrate;

            MessageBox.Show(Convert.ToString(moonpay));
}

        /*private void FortestBut_Click(object sender, EventArgs e)
        {
            string TargetST = TargetTB01.Text;
            int Target = Convert.ToInt32(TargetST);
            MessageBox.Show();
        }*/
    }
}
