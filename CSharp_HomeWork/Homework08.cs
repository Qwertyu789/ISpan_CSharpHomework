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

        //奇數偶數
        private void button3_Click(object sender, EventArgs e)
        {
            int x=0, y=0;
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
            lbResult.Text = $"";


        }
        //最長名字
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
    }
}
