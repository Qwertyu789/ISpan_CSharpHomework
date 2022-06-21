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
    public partial class Homework04 : Form
    {
        string name, cht, math, eng;
        int chti, mathi, engi = 0;
        string[] classname = { "國文", "英文", "數學" };
        int[] scoresort = new int[3];
        
        

        public Homework04()
        {
            InitializeComponent();
        }
        void putspace()
        {
            name = cht = math = eng = "";
            name = namebox.Text;
            cht = chtbox.Text;
            math = mathbox.Text;
            eng = engbox.Text;
            chti = Int32.Parse(cht);
            mathi = Int32.Parse(math);
            engi = Int32.Parse(eng);
            int[] score = { chti, engi, mathi };
        }
        
        void highlow()
        {
            highlowbox.Text = "";
            int[] score = { chti, engi, mathi };
            for(int i = 0; i< score.Length; i++)
            {
                scoresort[i] = score[i];
            }
            Array.Sort(scoresort);
            int maxintindex = Array.IndexOf(score, scoresort[scoresort.Length - 1]);
            int minintindex = Array.IndexOf(score, scoresort[0]);
            highlowbox.Text = "最高科目成績為：" + classname[maxintindex] + scoresort[scoresort.Length - 1] + "分\r\n最低科目成績為：" + classname[minintindex] + scoresort[0] + "分";
    
            //if (chti >= mathi && chti >= engi)
            //{
            //    if (mathi >= engi)
            //    {
            //        highlowbox.Text = "最高科目成績為：國文" + chti + "分\r\n最低科目成績為：英文" + engi + "分";
            //    }
            //    else
            //    {
            //        highlowbox.Text = "最高科目成績為：國文" + chti + "分\r\n最低科目成績為：數學" + mathi + "分";
            //    }
            //}
            //if (mathi >= chti && mathi >= engi)
            //{
            //    if (chti >= engi)
            //    {
            //        highlowbox.Text = "最高科目成績為：數學" + mathi + "分\r\n最低科目成績為：英文" + engi + "分";
            //    }
            //    else
            //    {
            //        highlowbox.Text = "最高科目成績為：數學" + mathi + "分\r\n最低科目成績為：國文" + chti + "分";
            //    }
            //}
            //if (engi >= chti && engi >= mathi)
            //{
            //    if (chti >= mathi)
            //        {
            //            highlowbox.Text = "最高科目成績為：英文" + engi + "分\r\n最低科目成績為：數學" + mathi + "分";
            //        }
            //    else
            //        {
            //            highlowbox.Text = "最高科目成績為：英文" + engi + "分\r\n最低科目成績為：國文" + chti + "分";
            //        }
            //}

        }

        private void Homework04_Load(object sender, EventArgs e)
        {
        }      

        private void button1_Click(object sender, EventArgs e)
        {
            putspace();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            playbox.Text = "姓名：" + name + "\r\n國文：" + chti + "\r\n英文：" + engi + "\r\n數學：" + mathi;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            highlow();
        }
    }
}
