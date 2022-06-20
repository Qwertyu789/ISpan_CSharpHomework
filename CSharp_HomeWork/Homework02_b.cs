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
    public partial class Homework02_b : Form
    {
        Homework02_a hwa;
        public Homework02_b()
        {
            InitializeComponent();

        }
        public Homework02_b(Form A)
        {
            InitializeComponent();
            hwa = (Homework02_a)A;
        }

        

        private void Homework02_b_Load(object sender, EventArgs e)
        {         
            hwa.Monthpay();
            Label lab6 = label6;
            lab6.Text = hwa.getTarget();
            //lab6.Text = 
        }
    }
}
