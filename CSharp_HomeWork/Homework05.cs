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
    public partial class Homework05 : Form
    {
        const int w = 4;
        string starttitle = $"{"姓名",-5}" + $"{"國文",w}" + $"{"英文",w}" + $"{"數學",w}" + $"{"總分",w}" + $"{"平均",w}" 
            + $"{"最低",w}" + $"{"最高",w}";

        public Homework05()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbScoreList.Text = starttitle;
        }


    }
}
