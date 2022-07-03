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
    public partial class Homework08 : Form
    {
        public Homework08()
        {
            InitializeComponent();
        }
        int[] arr0711 = new int[] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578};
        string[] array0711_str = new string[] { "mother張", "emma", "迪克蕭", "J40" ,"Candy","Cindy","Coconut","Motherfacker"};

        //陣列奇數偶數
        private void button3_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;
            for (int i = 0; i < arr0711.Length; i++)
            {
                //整除=偶數   
                if (arr0711[i] % 2 == 0)
                {
                    x += 1;
                }
                //有餘數=奇數
                else
                {
                    y += 1;
                }
            }
            lbResult.Text = $"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578] \r\n奇數共 {y}\r\n偶數共 {x}";


        }
        //陣列最長名字
        private void button4_Click(object sender, EventArgs e)
        {
            ////做兩個int array抓最大值搜尋index 
            //int[] arraystrint = new int[array0711_str.Length];
            //int[] arraystrintmax = new int[array0711_str.Length];
            //for (int i = 0; i < array0711_str.Length; i++)
            //{
            //    arraystrint[i] = array0711_str[i].Length;
            //    arraystrintmax[i] = array0711_str[i].Length;
            //}
            //int x = arraystrintmax.Max();
            //string res = array0711_str[Array.IndexOf(arraystrint, x)];
            //lbResult.Text = $"陣列arr0711_Str [mother張 , emma , 迪克蕭 , J40 , Candy , Cindy , Coconut , Motherfacker] \r\n最長的名字是{res}";

            //用for loop +if 比較 減少記憶體消耗
            int maxindex = 0;
            for(int i = 1; i < array0711_str.Length; i++)
            {
                if(array0711_str[maxindex].Length < array0711_str[i].Length)
                {
                    maxindex = i;
                }
            }
            lbResult.Text = $"陣列arr0711_Str [mother張 , emma , 迪克蕭 , J40 , Candy , Cindy , Coconut , Motherfacker] \r\n最長的名字是{array0711_str[maxindex]}";
        }
        //檢查奇數偶數
        private void button1_Click(object sender, EventArgs e)
        {
            int res = 0;
            bool test = int.TryParse(tbNum.Text, out res);
            if (!test) 
            {
                MessageBox.Show("請輸入數值。");
                return;
            }
            if (res % 2 == 0)
            {
                lbResult.Text = $"輸入的數為 {res} 偶數";
            }
            else
            {
                lbResult.Text = $"輸入的數為 {res} 奇數";
            }

            
        }
        //陣列最大小值
        private void button2_Click(object sender, EventArgs e)
        {
            lbResult.Text = $"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\r\n最大值為 {arr0711.Max()}\r\n最小值為 {arr0711.Min()}";
        }
        //找C和c的字有哪些
        private void button12_Click(object sender, EventArgs e)
        {
            int x = 0;
            for(int i = 0 ; i < array0711_str.Length ; i++ )
            {
                if (array0711_str[i].Contains("C") || array0711_str[i].Contains("c"))
                {
                    x++;
                }
            }
            lbResult.Text = $"陣列arr0711_Str [mother張 , emma , 迪克蕭 , J40 , Candy , Cindy , Coconut , Motherfacker] \r\n有C及c的名字共有{x}個";
        }
        //清空結果
        private void button13_Click(object sender, EventArgs e)
        {
            lbResult.Text = "結果";
        }
        //[10,10] 邊1內0
        private void button5_Click(object sender, EventArgs e)
        {
            int[,] stock = new int[10, 10];
            lbResult.Text = "";
            // i==0或10 或 j==0和10 [i,j]=1
            // i!=0或10 或 j!=0或10 [i,j]=0
            //for (int res =0; res < 10; res++)
            //{               
            //   MessageBox.Show((res%9).ToString());
            //}
            //當 i 或 j 為 (0或9)%9時==0

            //給值
            for (int i = 0;i<10;i++) 
            {
                
                for(int j = 0; j <10; j++)
                {   
                    
                    
                    if ((i % 9) * (j % 9) == 0)
                    {
                        stock[i, j] = 1;
                    }
                    else
                    {
                        stock[i, j] = 0;
                    }
                }                
            }
            //畫圖
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    lbResult.Text += stock[i, j]+" ";
                }
                lbResult.Text += "\r\n";
            }           
            
        }
        
        //[10,10] 邊0內1
        private void button6_Click(object sender, EventArgs e)
        {
            int[,] stock = new int[10, 10];
            lbResult.Text = "";
            //給值
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {   
                    if ((i % 9) * (j % 9) == 0)
                    {
                        stock[i, j] = 0;
                    }
                    else
                    {
                        stock[i, j] = 1;
                    }
                }
            }
            //畫圖
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    lbResult.Text += stock[i, j] + " ";
                }
                lbResult.Text += "\r\n";
            }

        }
        //[10,10] 101010
        private void button7_Click(object sender, EventArgs e)
        {
            int[,] stock = new int[10, 10];
            lbResult.Text = "";
            //給值
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (((i +j)%2) == 0)
                    {
                        stock[i, j] = 1;
                    }
                    else
                    {
                        stock[i, j] = 0;
                    }
                }
            }
            //畫圖
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    lbResult.Text += stock[i, j] + " ";
                }
                lbResult.Text += "\r\n";
            }


        }
        //swap
        private void button8_Click(object sender, EventArgs e)
        {
            int n1 = 100, n2 = 200, i;
            lbResult.Text = $"換位前n1={n1} , n2={n2}\r\n";
            i = n2;
            n2 = n1;
            n1 = i;
            lbResult.Text += $"換位後n1={n1} , n2={n2}\r\n";
        }
        
        private void button9_Click(object sender, EventArgs e)
        {
            lbResult.Text = $"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\r\n" +
                $"加總為 {arr0711.Sum()}";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            lbResult.Text = $"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\r\n" +
                $"最大值為 {arr0711.Max()}";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            lbResult.Text = $"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\r\n" +
                $"最小值為 {arr0711.Min()}";
        }
        //for
        private void btnFor_Click(object sender, EventArgs e)
        {
            //Check TryParse
            int intF, intT, intS;
            bool test = int.TryParse(tbFrom.Text, out intF);
            test &= int.TryParse(tbTo.Text, out intT);
            test &= int.TryParse(tbStep.Text, out intS);
            if (!test)
            {
                MessageBox.Show("請輸入數值。");
                return;
            }

            //FOR
            int res = 0;
            for(int i = intF; i <= intT; i += intS)
            {
                res += i;
            }
            lbResult.Text = $"{intF} 到 {intT} 相隔 {intS - 1}\r\n加總為 {res}";
        }
        //while
        private void btnWhile_Click(object sender, EventArgs e)
        {
            //Check TryParse
            int intF, intT, intS;
            bool test = int.TryParse(tbFrom.Text, out intF);
            test &= int.TryParse(tbTo.Text, out intT);
            test &= int.TryParse(tbStep.Text, out intS);
            if (!test)
            {
                MessageBox.Show("請輸入數值。");
                return;
            }

            //WHILE
            int i = intF;
            int res = 0;
            while (i <= intT)
            {
                res += i;
                i += intS;
            }
            lbResult.Text = $"{intF} 到 {intT} 相隔 {intS - 1}\r\n加總為 {res}";
        }
        //do
        private void btnDo_Click(object sender, EventArgs e)
        {
            //Check TryParse
            int intF, intT, intS;
            bool test = int.TryParse(tbFrom.Text, out intF);
            test &= int.TryParse(tbTo.Text, out intT);
            test &= int.TryParse(tbStep.Text, out intS);
            if (!test)
            {
                MessageBox.Show("請輸入數值。");
                return;
            }

            //DO-WHILE
            int i = intF;
            int res = 0;
            do
            {
                res += i;
                i += intS;
            }
            while (i <= intT);
            lbResult.Text = $"{intF} 到 {intT} 相隔 {intS - 1}\r\n加總為 {res}";
        }
        //Tree
        private void btnTree_Click(object sender, EventArgs e)
        {

            //Check TryParse
            int intR = 0;
            bool test = int.TryParse(tbRows.Text, out intR);
            if (!test)
            {
                MessageBox.Show("請輸入數值。");
                return;
            }
            lbResult.Text = ""; 

                       
            //for(/r/n) + for(*)
            for (int i = 0; i < intR; i++)
            {
                for(int j =0; j <= i; j++)
                {
                    lbResult.Text += "*";
                }
                lbResult.Text += "\r\n";
            }
        }
        //二進位
        private void btn100_Click(object sender, EventArgs e)
        {
            //Convert.ToString(dec, 2)
            lbResult.Text = Convert.ToString(100, 2);
        }
        //樂透
        private void btnLottery_Click(object sender, EventArgs e)
        {
            
            int[] randomArray = new int[6];
            Random randomint = new Random();  

            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = randomint.Next(1, 49);

                for (int j = 0; j < i; j++)
                {
                    //檢查重複
                    while (randomArray[j] == randomArray[i])
                    {
                        //重設j 重新檢查前面項目
                        j = 0;  
                        randomArray[i] = randomint.Next(1, 49);   //重新產生，存回陣列，亂數產生的範圍是1~9
                    }
                }
            }
            lbResult.Text = $"樂透號碼\r\n ";
            for (int i = 0; i < randomArray.Length; i++)
            {
                lbResult.Text += $"{randomArray[i]}  ";
            }

        }
        //九九乘法表
        private void button14_Click(object sender, EventArgs e)
        {
            lbResult.Text = "九九乘法表\r\n";
            for (int i = 1; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {
                    // string.format(string{0,length}{1,length}{2,length},index0,index1,index2)
                    lbResult.Text += String.Format("{0}x {1}={2,3}|",j,i,(i*j));
                }
                lbResult.Text += "\r\n";
            }
        }
    }
}
