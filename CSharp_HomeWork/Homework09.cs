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
    public partial class Homework09 : Form
    {
        List<int> Oline = new List<int>(), Xline = new List<int>();
        Button[] OXBtns = new Button[9];
        Boolean isGameOver = false;
        Boolean XorO = false;
        int[,] wincondition = new int[8,3]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 },
            { 1, 4, 7 },
            { 2, 5, 8 },
            { 3, 6, 9 },
            { 1, 5, 9 },
            { 7, 5, 3 }
        };
        //預先載入
        public Homework09()
        {
            OXBtns = new Button[9] { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            InitializeComponent();
        }
        //遊戲開始
        void GameStart()
        {
            isGameOver = false;
            XorO = true;
        }
        
        //點OX
        void BtnClick(object sender, EventArgs e)
        {
            int num = int.Parse(((Button)sender).Name[6].ToString());
            ((Button)sender).Enabled = false;
            if (XorO)
            {
                Oline.Add(num);
            }
            else
            {
                Xline.Add(num);
            }
            OXBtns[num - 1].Text = XorO ? "O" : "X";
            XorO = !XorO;

        }

        //檢查贏家
        void Checkwinner()
        {

        }

        //



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
