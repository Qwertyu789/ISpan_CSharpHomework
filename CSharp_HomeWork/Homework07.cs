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
    public partial class Homework07 : Form
    {        
        public Homework07()
        {
            InitializeComponent();
        }
        
        void plus(decimal a, decimal b)
        {
            decimal result = (a+b);
            textBox3.Text = result.ToString();
        }
        void minus(decimal a, decimal b)
        {
            decimal result = (a - b);
            textBox3.Text = result.ToString();
        }
        void multi(decimal a, decimal b)
        {
            decimal result = (a * b);
            textBox3.Text = result.ToString();
        }
        void divide(decimal a, decimal b)
        {
            decimal result = decimal.Round((a / b),4);
            textBox3.Text = result.ToString();
        }

        private void btnAnd_Click(object sender, EventArgs e)
        {
            decimal res, res2 = 0;
            bool test = decimal.TryParse(textBox1.Text, out res);
            bool test2 = decimal.TryParse(textBox2.Text, out res2);
            if (test&& test2) 
            {
                plus(res,res2);
            }
            else
            {
                DialogResult result = MessageBox.Show("請輸入數值。", "", MessageBoxButtons.OK);
            } 
            
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            decimal res, res2 = 0;
            bool test = decimal.TryParse(textBox1.Text, out res);
            bool test2 = decimal.TryParse(textBox2.Text, out res2);
            if (test && test2)
            {
                minus(res, res2);
            }
            else
            {
                DialogResult result = MessageBox.Show("請輸入數值。", "", MessageBoxButtons.OK);
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            decimal res, res2 = 0;
            bool test = decimal.TryParse(textBox1.Text, out res);
            bool test2 = decimal.TryParse(textBox2.Text, out res2);
            if (test && test2)
            {
                multi(res, res2);
            }
            else
            {
                DialogResult result = MessageBox.Show("請輸入數值。", "", MessageBoxButtons.OK);
            }
        }

        private void btnDivid_Click(object sender, EventArgs e)
        {
            decimal res, res2 = 0;
            bool test = decimal.TryParse(textBox1.Text, out res);
            bool test2 = decimal.TryParse(textBox2.Text, out res2);
            if (test && test2)
            {
                divide(res, res2);
            }
            else
            {
                DialogResult result = MessageBox.Show("請輸入數值。", "", MessageBoxButtons.OK);
            }
        }
    }
}
