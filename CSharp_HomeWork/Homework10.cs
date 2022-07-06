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
    public partial class Homework10 : Form
    {
        int posx = 10, posy = 10; 
        int mposx=MousePosition.X,mposy=MousePosition.Y;
        public Homework10()
        {
            InitializeComponent();
        }

        private void Homework10_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Cursor.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //圖片自己動
            var bounds = Screen.PrimaryScreen.Bounds;
            pboxO.Top += posy;
            pboxO.Left += posx;
            if (pboxO.Location.X >= (bounds.Width - 244))
            {
                posx = -10;
            }
            if (pboxO.Location.Y >= (bounds.Height - 217))
            {
                posy = -10;
            }
             if (pboxO.Left<=-80)
            {
                posx = 10;
            }
            if (pboxO.Top <= -40)
            {
                posy = 10;
            }
            //滑鼠移動關閉
            if (mposx - MousePosition.X < -50 || mposy - MousePosition.Y < -50)
            {
                Cursor.Show();
                this.Close();
            }
            if (mposx - MousePosition.X > 50 || mposy - MousePosition.Y > 50)
            {
                Cursor.Show();
                this.Close();
            }
            mposx = MousePosition.X;
            mposy = MousePosition.Y;

        }
        private void Homework10_Click(object sender, EventArgs e)
        {
            Cursor.Show();
            this.Close();
        }        
    }
}
