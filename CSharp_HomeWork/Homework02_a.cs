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
            
            
            string TargetST = TargetLB01.Text;
            int Target = Convert.ToInt32(TargetST);
            
        }

        /*private void FortestBut_Click(object sender, EventArgs e)
        {
            string TargetST = TargetTB01.Text;
            int Target = Convert.ToInt32(TargetST);
            MessageBox.Show();
        }*/
    }
}
