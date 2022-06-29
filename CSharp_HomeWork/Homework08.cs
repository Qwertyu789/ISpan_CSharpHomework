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
            //做兩個int array抓最大值搜尋index 
            int[] arraystrint = new int[array0711_str.Length];
            int[] arraystrintmax = new int[array0711_str.Length];
            for (int i = 0; i < array0711_str.Length; i++)
            {
                arraystrint[i] = array0711_str[i].Length;
                arraystrintmax[i] = array0711_str[i].Length;
            }
            int x = arraystrintmax.Max();
            string res = array0711_str[Array.IndexOf(arraystrint, x)];
            lbResult.Text = $"陣列arr0711_Str [mother張 , emma , 迪克蕭 , J40 , Candy , Cindy , Coconut , Motherfacker] \r\n最長的名字是{res}";
        }
        //檢查奇數偶數
        private void button1_Click(object sender, EventArgs e)
        {
            int res = 0;
            bool test = int.TryParse(tbNum.Text, out res);
            if (test) 
            {
                if (res % 2 == 0)
                {
                    lbResult.Text = $"輸入的數為 {res} 偶數";
                }
                else 
                {
                    lbResult.Text = $"輸入的數為 {res} 奇數";
                }
            }
            else { DialogResult result = MessageBox.Show("請輸入數值。", "", MessageBoxButtons.OK); }
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
                    x += 1;
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
            array
        }
        //[10,10] 邊0內1
        private void button6_Click(object sender, EventArgs e)
        {

        }
        //[10,10] 101010
        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
