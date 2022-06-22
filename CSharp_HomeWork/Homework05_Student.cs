using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_HomeWork
{
    class Homework05_Student
    {   
        //Property
        public int sum=0;
        public double avg=0;
        public string maxclass="";
        public string minclass="";

        //Method 
        //學生分數總合
        public void totalscore() 
        {
            Homework05 hw05 = new Homework05();
            hw05.loadsome();
            sum = hw05.Cht + hw05.Eng + hw05.Math;
        }
        //學生分數均分
        public void avgscore()
        {

            Homework05 hw05 = new Homework05();
            avg = Convert.ToDouble((hw05.Cht + hw05.Eng + hw05.Math) / 3);
        }
        //加入學生資料
        public void addData() 
        {
            Homework05 hw05 = new Homework05();


        }
        //隨機增加
        public void randomAdd() { }
        //各科統計
        public void avgAllClass() { }



    }
}
