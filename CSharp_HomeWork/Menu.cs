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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            spC2.Panel2.Controls.Clear();
            Homework01 hw = new Homework01();
            hw.TopLevel = false;
            spC2.Panel2.Controls.Add(hw);
            hw.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            spC2.Panel2.Controls.Clear();
            Homework02_a hw = new Homework02_a();
            hw.TopLevel = false;
            spC2.Panel2.Controls.Add(hw);
            hw.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            spC2.Panel2.Controls.Clear();
            Homework03 hw = new Homework03();
            hw.TopLevel = false;
            spC2.Panel2.Controls.Add(hw);
            hw.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            spC2.Panel2.Controls.Clear();
            Homework04 hw = new Homework04();
            hw.TopLevel = false;
            spC2.Panel2.Controls.Add(hw);
            hw.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            spC2.Panel2.Controls.Clear();
            Homework05 hw = new Homework05();
            hw.TopLevel = false;
            spC2.Panel2.Controls.Add(hw);
            hw.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            spC2.Panel2.Controls.Clear();
            Homework06 hw = new Homework06();
            hw.TopLevel = false;
            spC2.Panel2.Controls.Add(hw);
            hw.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            spC2.Panel2.Controls.Clear();
            Homework07 hw = new Homework07();
            hw.TopLevel = false;
            spC2.Panel2.Controls.Add(hw);
            hw.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            spC2.Panel2.Controls.Clear();
            Homework08 hw = new Homework08();
            hw.TopLevel = false;
            spC2.Panel2.Controls.Add(hw);
            hw.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            spC2.Panel2.Controls.Clear();
            Homework09 hw = new Homework09();
            hw.TopLevel = false;
            spC2.Panel2.Controls.Add(hw);
            hw.Show();
        }
    }
}
