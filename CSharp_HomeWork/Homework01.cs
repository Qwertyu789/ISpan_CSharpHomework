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
    public partial class Homework01 : Form
    {
        public Homework01()
        {
            InitializeComponent();
        }

        private void Hi_But_Click(object sender, EventArgs e)
        {
            string CNName = NameCNTB.Text;
            string ENName = NameENTB.Text;
            string Gender = GenderTB.Text;
            string Sign = SignTB.Text;

            MessageBox.Show("Hi！我是 " + CNName + "\n英文名字是：" + ENName + "\n性別是：" + Gender + "\n星座是：" + Sign + "\n很高興認識你們！");

        }

        private void HelloBut_Click(object sender, EventArgs e)
        {
            string CNName = NameCNTB.Text;
            string ENName = NameENTB.Text;
            string Gender = GenderTB.Text;
            string Sign = SignTB.Text;

            MessageBox.Show("Hello！我是 " + CNName + "\n英文名字是：" + ENName + "\n性別是：" + Gender + "\n星座是：" + Sign + "\n很高興認識你們！");

        }
    }
}
