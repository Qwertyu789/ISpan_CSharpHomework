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
        Boolean XorO = false;

        //不規則陣列
        int[][] wincondition = new int[][]
        {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9 },
            new int[] { 1, 4, 7 },
            new int[] { 2, 5, 8 },
            new int[] { 3, 6, 9 },
            new int[] { 1, 5, 9 },
            new int[] { 7, 5, 3 }
        };
        
        public Homework09()
        {                       
            InitializeComponent();
        }
        //按鍵判定
        private void setKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 82)
            {
                button10.PerformClick();
            }
            if(e.KeyValue == 27)
            {
                button11.PerformClick();
            }
        }

        //找尋配對
        bool checkpair(List<int> ls,int[] ar )
        {
            return ls.Contains(ar[0]) && ls.Contains(ar[1]) && ls.Contains(ar[2]);
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
            Checkwinner();
        }
        //檢查贏家
        void Checkwinner()
        {
            for(int i = 0; i < 8; i++)
            {
                if (checkpair(Oline, wincondition[i]))
                {
                    MessageBox.Show($"O贏，請重新開始");
                    setReset();
                }
                else if(checkpair(Xline , wincondition[i]))
                {
                    MessageBox.Show($"X贏，請重新開始");
                    setReset();
                }
            }
            if (Oline.Count + Xline.Count == 9)
            {
                MessageBox.Show($"平手，請重新開始");
                setReset();
            }
        }
        //載入
        private void Homework09_Load(object sender, EventArgs e)
        {
            OXBtns = new Button[9] { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            setReset();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            setReset();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //重新開始
        void setReset()
        {
            for(int i =0; i < 9; i++)
            {
                OXBtns[i].Enabled = true;
                OXBtns[i].Text = "";                
            }
            Oline.Clear();
            Xline.Clear();
            XorO = false;
        }

    }
}
