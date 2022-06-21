
namespace CSharp_HomeWork
{
    partial class Homework03
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WineBtn = new System.Windows.Forms.Button();
            this.TequilaBtn = new System.Windows.Forms.Button();
            this.WhiskyBtn = new System.Windows.Forms.Button();
            this.BeerBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bill = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreditBtn = new System.Windows.Forms.Button();
            this.Cashbtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ClearListBtn = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WineBtn);
            this.groupBox1.Controls.Add(this.TequilaBtn);
            this.groupBox1.Controls.Add(this.WhiskyBtn);
            this.groupBox1.Controls.Add(this.BeerBtn);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(23, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "菜單 Menu";
            // 
            // WineBtn
            // 
            this.WineBtn.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.WineBtn.Location = new System.Drawing.Point(111, 154);
            this.WineBtn.Name = "WineBtn";
            this.WineBtn.Size = new System.Drawing.Size(85, 120);
            this.WineBtn.TabIndex = 3;
            this.WineBtn.Text = "紅酒\r\nWine\r\nNT.320\r\n";
            this.WineBtn.UseVisualStyleBackColor = true;
            this.WineBtn.Click += new System.EventHandler(this.WineBtn_Click);
            // 
            // TequilaBtn
            // 
            this.TequilaBtn.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TequilaBtn.Location = new System.Drawing.Point(111, 30);
            this.TequilaBtn.Name = "TequilaBtn";
            this.TequilaBtn.Size = new System.Drawing.Size(85, 120);
            this.TequilaBtn.TabIndex = 2;
            this.TequilaBtn.Text = "龍舌蘭\r\nTequila\r\nNT.180";
            this.TequilaBtn.UseVisualStyleBackColor = true;
            this.TequilaBtn.Click += new System.EventHandler(this.TequilaBtn_Click);
            // 
            // WhiskyBtn
            // 
            this.WhiskyBtn.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.WhiskyBtn.Location = new System.Drawing.Point(20, 154);
            this.WhiskyBtn.Name = "WhiskyBtn";
            this.WhiskyBtn.Size = new System.Drawing.Size(85, 120);
            this.WhiskyBtn.TabIndex = 1;
            this.WhiskyBtn.Text = "威士忌\r\nWhisky\r\nNT.350";
            this.WhiskyBtn.UseVisualStyleBackColor = true;
            this.WhiskyBtn.Click += new System.EventHandler(this.WhiskyBtn_Click);
            // 
            // BeerBtn
            // 
            this.BeerBtn.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BeerBtn.Location = new System.Drawing.Point(20, 30);
            this.BeerBtn.Name = "BeerBtn";
            this.BeerBtn.Size = new System.Drawing.Size(85, 120);
            this.BeerBtn.TabIndex = 0;
            this.BeerBtn.Text = "啤酒\r\nBeer\r\nNT.120\r\n";
            this.BeerBtn.UseVisualStyleBackColor = true;
            this.BeerBtn.Click += new System.EventHandler(this.BeerBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bill);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(245, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 99);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "總金額 Total Price";
            // 
            // bill
            // 
            this.bill.BackColor = System.Drawing.SystemColors.WindowText;
            this.bill.ForeColor = System.Drawing.SystemColors.Window;
            this.bill.Location = new System.Drawing.Point(11, 42);
            this.bill.Name = "bill";
            this.bill.Size = new System.Drawing.Size(202, 29);
            this.bill.TabIndex = 0;
            this.bill.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.CreditBtn);
            this.groupBox3.Controls.Add(this.Cashbtn);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(245, 143);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 108);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "付款方式";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(133, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "信用卡享九折!";
            // 
            // CreditBtn
            // 
            this.CreditBtn.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CreditBtn.Location = new System.Drawing.Point(117, 38);
            this.CreditBtn.Name = "CreditBtn";
            this.CreditBtn.Size = new System.Drawing.Size(100, 36);
            this.CreditBtn.TabIndex = 1;
            this.CreditBtn.Text = "信用卡";
            this.CreditBtn.UseVisualStyleBackColor = true;
            this.CreditBtn.Click += new System.EventHandler(this.CreditBtn_Click);
            // 
            // Cashbtn
            // 
            this.Cashbtn.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Cashbtn.Location = new System.Drawing.Point(11, 38);
            this.Cashbtn.Name = "Cashbtn";
            this.Cashbtn.Size = new System.Drawing.Size(100, 36);
            this.Cashbtn.TabIndex = 0;
            this.Cashbtn.Text = "現金";
            this.Cashbtn.UseVisualStyleBackColor = true;
            this.Cashbtn.Click += new System.EventHandler(this.Cashbtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ClearListBtn);
            this.groupBox4.Controls.Add(this.list);
            this.groupBox4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.Location = new System.Drawing.Point(489, 38);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(254, 293);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "購物清單 List";
            // 
            // ClearListBtn
            // 
            this.ClearListBtn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ClearListBtn.Location = new System.Drawing.Point(139, 254);
            this.ClearListBtn.Name = "ClearListBtn";
            this.ClearListBtn.Size = new System.Drawing.Size(109, 33);
            this.ClearListBtn.TabIndex = 1;
            this.ClearListBtn.Text = "清除清單";
            this.ClearListBtn.UseVisualStyleBackColor = true;
            this.ClearListBtn.Click += new System.EventHandler(this.ClearListBtn_Click);
            // 
            // list
            // 
            this.list.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.list.Location = new System.Drawing.Point(6, 28);
            this.list.Multiline = true;
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(242, 220);
            this.list.TabIndex = 0;
            this.list.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.list.WordWrap = false;
            // 
            // Homework03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 343);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Homework03";
            this.Text = "Homework03";
            this.Load += new System.EventHandler(this.Homework03_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button WineBtn;
        private System.Windows.Forms.Button TequilaBtn;
        private System.Windows.Forms.Button WhiskyBtn;
        private System.Windows.Forms.Button BeerBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox bill;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button CreditBtn;
        private System.Windows.Forms.Button Cashbtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button ClearListBtn;
        private System.Windows.Forms.TextBox list;
        private System.Windows.Forms.Label label1;
    }
}