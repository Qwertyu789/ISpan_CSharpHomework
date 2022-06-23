using System;
using System.Collections;
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
        //Property
        ArrayList arraystu = new ArrayList();
        int counter = 0; //學員人數
        const int w = 4; //調整間隔
        const int ww = 4;
        string starttitle = $"{"姓名",-2}" + $"{"國文",w}" + $"{"英文",w}" 
            + $"{"數學",w}" + $"{"總分",w}" + $"{"平均",w+1}" + $"{"最低",w}" 
            + $"{"最高",w+1}"+"\n"; //TITLE
        //基本資料
        struct studentstatus
        {
            public string Name;
            public int Cht;
            public int Eng;
            public int Math;

        }
            public Homework05()
        {
            InitializeComponent();
        }

        //Mmethod

        //成績欄位加一行
        void studentlist()
        {           
            lbScoreList.Text = starttitle;
            for (int i = 0; i < arraystu.Count; i++)
            {   
                //總和 & 均分     
                int summ = ((studentstatus)(arraystu[i])).Cht+ ((studentstatus)(arraystu[i])).Eng+ ((studentstatus)(arraystu[i])).Math ;
                double avgg = Math.Round((summ / 3.0), 1);

                //最高分 
                int[] compare = new int[] { ((studentstatus)(arraystu[i])).Cht, ((studentstatus)(arraystu[i])).Eng, ((studentstatus)(arraystu[i])).Math };
                int maxscore = compare.Max();
                int maxposition = Array.IndexOf(compare, maxscore);
                string maxclass = "";
                    if (maxposition == 0)
                    {
                        maxclass = "國文" + maxscore;
                    }
                    else if (maxposition == 1)
                    {
                        maxclass = "英文" + maxscore;
                    }
                    else if (maxposition == 2)
                    {
                        maxclass = "數學" + maxscore;
                    }

                //最低分
                int minscore = compare.Min();
                int minposition = Array.IndexOf(compare, minscore);
                string minclass = "";
                    if (minposition == 0)
                   {
                        minclass = "國文" + minscore;
                   }
                    else if (minposition == 1)
                    {
                        minclass = "英文" + minscore;
                    }
                    else if (minposition == 2)
                    {
                        minclass = "數學" + minscore;
                    }

                //顯示在分數版上
                lbScoreList.Text += $"{((studentstatus)arraystu[i]).Name,-4}" + $"{((studentstatus)arraystu[i]).Cht,ww} "
                    + $"{((studentstatus)arraystu[i]).Eng,ww} " + $"{((studentstatus)arraystu[i]).Math,ww+2} "
                    + $"{summ,ww+1} "+ $"{avgg,ww+1}"+ $"{minclass,ww+2} "
                    + $"{maxclass,ww} \r\n";
            }        
        }
        //增加學生資料
        void addData()
        {            
            counter++; //計數器+1
            //填入資料
            studentstatus stu;
            stu.Name = tbName.Text;
            stu.Cht = int.Parse(tbCht.Text);
            stu.Eng = int.Parse(tbEng.Text);
            stu.Math = int.Parse(tbMath.Text);
            //把資料丟進list裡
            arraystu.Add(stu);
        }
        //隨機數值加入
        void ramdomfunction(int times)
        {
            //建立隨機
            Random forran = new Random();
            for (int i =0;i<times;i++)
            {
                counter++; //計數器+1
                studentstatus stu;
                stu.Name = counter.ToString();
                stu.Cht = forran.Next(0,100);
                stu.Eng = forran.Next(0, 100);
                stu.Math = forran.Next(0, 100);
                arraystu.Add(stu);
            }          
        }

        //Function
        //加入學生資料
        private void button1_Click(object sender, EventArgs e)
        {
            addData();           
            studentlist();
        }
        //隨機一筆
        private void button2_Click(object sender, EventArgs e)
        {
            ramdomfunction(1);
            studentlist();
        }
        //隨機20筆
        private void button5_Click(object sender, EventArgs e)
        {
            ramdomfunction(20);
            studentlist();
        }
        //各科統計
        private void button3_Click(object sender, EventArgs e)
        {

        }
        //重設
        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
