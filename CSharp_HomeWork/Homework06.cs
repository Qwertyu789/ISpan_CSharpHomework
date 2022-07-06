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
    public partial class Homework06 : Form
    {
        public Homework06()
        {
            InitializeComponent();
        }

        //Property
        List<studentstatus> arraystu = new List<studentstatus>();
        int counter = 0; //學員人數
        const int w = 4; //調整間隔
        const int ww = 4;
        string starttitle = $"{"姓名",-2}" + $"{"國文",w}" + $"{"英文",w}"
            + $"{"數學",w}" + $"{"總分",w}" + $"{"平均",w + 1}" + $"{"最低",w}"
            + $"{"最高",w + 1}" + "\n"; //TITLE
        //基本資料
        struct studentstatus
        {
            public string Name;
            public int Cht;
            public int Eng;
            public int Math;

        }
        
        //Mmethod
        //成績欄位加一行
        void studentlist()
        {
            lbScoreList.Text = starttitle;
            for (int i = 0; i < arraystu.Count; i++)
            {
                //總和 & 均分     
                int sum = arraystu[i].Cht + arraystu[i].Eng + arraystu[i].Math;
                double avg = Math.Round((sum / 3.0), 1);


                //最高分 
                int[] compare = new int[] { arraystu[i].Cht, arraystu[i].Eng, arraystu[i].Math };
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
                lbScoreList.Text += $"{arraystu[i].Name,-4}" + $"{arraystu[i].Cht,ww + 1} "
                    + $"{arraystu[i].Eng,ww} " + $"{arraystu[i].Math,ww + 2} "
                    + $"{sum,ww + 1} " + $"{avg,ww + 1}" + $"{minclass,ww + 2} "
                    + $"{maxclass,ww} \r\n";

            }
        }
        void Totalshow()
        {
            int sumCht = 0, sumEng = 0, sumMath = 0;
            double avgCht = 0, avgEng = 0, avgMath = 0;
            int maxCht, naxEng, maxMath, minCht, minEng, minMath;

            List<int> comCht = new List<int>();
            List<int> comEng = new List<int>();
            List<int> comMath = new List<int>();

            for (int i = 0; i < arraystu.Count; i++)
            {
                //統計用                
                sumCht += arraystu[i].Cht;
                sumEng += arraystu[i].Eng;
                sumMath += arraystu[i].Math;
                avgCht = Math.Round((sumCht / Convert.ToDouble(counter)), 1);
                avgEng = Math.Round((sumEng / Convert.ToDouble(counter)), 1);
                avgMath = Math.Round((sumMath / Convert.ToDouble(counter)), 1);

                //查科目最高最低                
                comCht.Add(arraystu[i].Cht);
                maxCht = comCht.Max();
                minCht = comCht.Min();
                comEng.Add(arraystu[i].Eng);
                naxEng = comEng.Max();
                minEng = comEng.Min();
                comMath.Add(arraystu[i].Math);
                maxMath = comMath.Max();
                minMath = comMath.Min();

                //顯示在統計版上
                lbTotal.Text = $"{"總分",-4}　{sumCht,ww + 1}　{sumEng,ww + 3}　{sumMath,ww + 3} " +
                    $"\r\n{"平均",-4}　{avgCht,ww + 1}　{avgEng,ww + 3}　{avgMath,ww + 3} " +
                    $"\r\n{"最高分",-5}{maxCht,ww + 1}　{naxEng,ww + 3}　{maxMath,ww + 3} " +
                    $"\r\n{"最低分",-5}{minCht,ww + 1}　{minEng,ww + 3}　{minMath,ww + 3} ";
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
        //插入資料
        void InsertData()
        {
            counter++; //計數器+1
            //填入資料
            studentstatus stu;
            stu.Name = tbName.Text;
            stu.Cht = int.Parse(tbCht.Text);
            stu.Eng = int.Parse(tbEng.Text);
            stu.Math = int.Parse(tbMath.Text);
            //把資料丟進list裡
            arraystu.Insert(0,stu);
        }
        //刪除資料
        void Deletedata()
        {
            counter--; //計數器-1
            //填入資料
            studentstatus stu;
            stu.Name = tbName.Text;
            stu.Cht = int.Parse(tbCht.Text);
            stu.Eng = int.Parse(tbEng.Text);
            stu.Math = int.Parse(tbMath.Text);
            //把資料丟進list裡
            arraystu.RemoveAt(0);
        }
        //搜尋資料
        string SearchCht(int m, int n)
        {
            //重置分數版標題
            lbScoreList.Text = starttitle;

            List<int> comCht = new List<int>();
            List<int> comEng = new List<int>();
            List<int> comMath = new List<int>();

            //製造容器
            string result = "";

            for (int i = 0; i < arraystu.Count; i++)
            {
                if (arraystu[i].Cht >= m && arraystu[i].Cht <= n)
                {
                    //總和 & 均分     
                    int sum = arraystu[i].Cht + arraystu[i].Eng + arraystu[i].Math;
                    double avg = Math.Round((sum / 3.0), 1);


                    //最高分 
                    int[] compare = new int[] { arraystu[i].Cht, arraystu[i].Eng, arraystu[i].Math };
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
                    lbScoreList.Text += $"{arraystu[i].Name,-4}" + $"{arraystu[i].Cht,ww + 1} "
                        + $"{arraystu[i].Eng,ww} " + $"{arraystu[i].Math,ww + 2} "
                        + $"{sum,ww + 1} " + $"{avg,ww + 1}" + $"{minclass,ww + 2} "
                        + $"{maxclass,ww} \r\n";
                }
            }
            //容器裝結果回傳
            result = lbScoreList.Text;
            return result;          
        }

        //Function
        //加入學生資料
        private void button1_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Length > 0)
            {
                if (tbCht.Text.Length > 0)
                {
                    if (tbEng.Text.Length > 0)
                    {
                        if (tbMath.Text.Length > 0)
                        {
                            addData();
                            studentlist();
                            butTotal.Enabled = true;
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("請輸入數學。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("請輸入英文。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("請輸入國文。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("請輸入姓名。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        //各科統計
        private void button3_Click(object sender, EventArgs e)
        {
            Totalshow();
            butADD.Enabled = false;
            butTotal.Enabled = false;
            butInsert.Enabled = false;
            butDelete.Enabled = false;
        }
        //重設
        private void button4_Click(object sender, EventArgs e)
        {
            arraystu.Clear();
            counter = 0;
            lbScoreList.Text = starttitle;
            lbTotal.Text = "";
            butDelete.Enabled = true;
            butInsert.Enabled = true;
            butADD.Enabled = true;
            butTotal.Enabled = false;
        }
        //插入第一個位置
        private void butInsert_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Length > 0)
            {
                if (tbCht.Text.Length > 0)
                {
                    if (tbEng.Text.Length > 0)
                    {
                        if (tbMath.Text.Length > 0)
                        {
                            InsertData();
                            studentlist();
                            butTotal.Enabled = true;
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("請輸入數學。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("請輸入英文。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("請輸入國文。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("請輸入姓名。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //刪除第一個位置
        private void butDelete_Click(object sender, EventArgs e)
        {
            Deletedata();
            studentlist();
        }

        //查詢國文成績
        private void butSearch_Click(object sender, EventArgs e)
        {
            int m = int.Parse(textBox1.Text);
            int n = int.Parse(textBox2.Text);
            SearchCht(m,n);
        }
    }
}
