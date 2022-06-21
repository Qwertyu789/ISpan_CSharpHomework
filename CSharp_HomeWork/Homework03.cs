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
    public partial class Homework03 : Form
    {
        public Homework03()
        {
            InitializeComponent();
        }

        int Beer, Tequila, Whisky, Wine = 0;
        int billpay;

        void Cart()
        {
            //string Eat = "";
            bill.Text = "";
            billpay = Beer * 120 + Tequila * 180 + Whisky * 350 + Wine * 320;
            list.Text = "";
            if (Beer > 0)
            {
                list.Text += "啤酒 Beer x" + Beer + ",共NT $" + (Beer * 120) + " 元\r\n";
            }
            if (Tequila > 0)
            {
                list.Text += "龍舌蘭 Tequila x" + Tequila + ",共NT $" + (Tequila * 180) + " 元\r\n";
            }
            if (Whisky > 0)
            {
                list.Text += "威士忌 Whisky x" + Whisky + " ,共NT $" + (Whisky * 350) + " 元\r\n";
            }
            if (Wine > 0)
            {
                list.Text += "紅酒 Wine x" + Wine + " ,共NT $" + (Wine * 320) + " 元";
            }
            if (Beer + Tequila + Whisky + Wine == 0)
            {
                list.Text = "尚未點餐";
            }
            bill.Text = "NT $ " + billpay+" ";
            


        }
        private void WineBtn_Click(object sender, EventArgs e)
        {
            Wine += 1;
            Cart();
            
        }

        private void Homework03_Load(object sender, EventArgs e)
        {
            Cart();
        }

        private void ClearListBtn_Click(object sender, EventArgs e)
        {
            Beer = Tequila = Whisky = Wine = 0;
            Cart();
        }

        private void Cashbtn_Click(object sender, EventArgs e)
        {
            if(billpay>0)
            {
                DialogResult result = MessageBox.Show("總金額：NT$ " + billpay, "確認付款？"
                , MessageBoxButtons.YesNo);
            }
            else
            {
                DialogResult result = MessageBox.Show("尚未點餐！", "確認付款？", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void CreditBtn_Click(object sender, EventArgs e)
        {
            if (billpay > 0)
            {
                DialogResult result = MessageBox.Show("總金額：NT$ " + billpay +"\n折扣後金額：NT$ "+ billpay*0.9, "確認付款？"
                , MessageBoxButtons.YesNo);
            }
            else
            {
                DialogResult result = MessageBox.Show("尚未點餐！", "確認付款？", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void WhiskyBtn_Click(object sender, EventArgs e)
        {
            Whisky += 1;
            Cart();
        }

        private void TequilaBtn_Click(object sender, EventArgs e)
        {
            Tequila += 1;
            Cart();
        }

        private void BeerBtn_Click(object sender, EventArgs e)
        {
            Beer += 1;
            Cart();
        }
    }
}
