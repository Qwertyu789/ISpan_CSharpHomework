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
            + $"{"最低",w}" + $"{"最高",w}"+"\n";
        public string Name="";
        public int Cht = 0;
        public int Eng = 0;
        public int Math = 0;

        public Homework05()
        {
            InitializeComponent();
        }
        //public void loadsome()
        //{
        //    Cht = Convert.ToInt32(tbCht.Text);
        //    Eng = Convert.ToInt32(tbEng.Text);
        //    Math = Convert.ToInt32(tbMath.Text);
        //}
        
        //進頁面讀取跑清單
         private void Homework05_Load(object sender, EventArgs e)
        {
            lbScoreList.Text = starttitle;
        }
        //加入學生資料
        private void button1_Click(object sender, EventArgs e)
        {
            Homework05_Student Student = new Homework05_Student();
            Name = tbName.Text;
            Student.totalscore();
            Student.avgscore();
            lbScoreList.Text += $"{tbName.Text,-5}"+$"{Cht,w}"+$"{Eng,w}"+$"{Math,w}"+$"{Student.sum,w}"+$"{Student.avg,w}\n";
        }

        
    }
}
