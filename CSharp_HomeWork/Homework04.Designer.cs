
namespace CSharp_HomeWork
{
    partial class Homework04
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.namebox = new System.Windows.Forms.TextBox();
            this.chtbox = new System.Windows.Forms.TextBox();
            this.mathbox = new System.Windows.Forms.TextBox();
            this.engbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.highlowbox = new System.Windows.Forms.TextBox();
            this.playbox = new System.Windows.Forms.TextBox();
            this.namelb = new System.Windows.Forms.Label();
            this.chtlb = new System.Windows.Forms.Label();
            this.mathlb = new System.Windows.Forms.Label();
            this.englb = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(72, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "儲存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(229, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "顯示儲存內容";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(472, 325);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "最高分/最低分科目";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // namebox
            // 
            this.namebox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.namebox.Location = new System.Drawing.Point(165, 68);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(133, 29);
            this.namebox.TabIndex = 3;
            this.namebox.Text = "0";
            this.namebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chtbox
            // 
            this.chtbox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chtbox.Location = new System.Drawing.Point(165, 122);
            this.chtbox.Name = "chtbox";
            this.chtbox.Size = new System.Drawing.Size(133, 29);
            this.chtbox.TabIndex = 4;
            this.chtbox.Text = "0";
            this.chtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mathbox
            // 
            this.mathbox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mathbox.Location = new System.Drawing.Point(165, 222);
            this.mathbox.Name = "mathbox";
            this.mathbox.Size = new System.Drawing.Size(133, 29);
            this.mathbox.TabIndex = 5;
            this.mathbox.Text = "0";
            this.mathbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // engbox
            // 
            this.engbox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.engbox.Location = new System.Drawing.Point(165, 168);
            this.engbox.Name = "engbox";
            this.engbox.Size = new System.Drawing.Size(133, 29);
            this.engbox.TabIndex = 6;
            this.engbox.Text = "0";
            this.engbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.highlowbox);
            this.groupBox1.Controls.Add(this.playbox);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(399, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 281);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成績";
            // 
            // highlowbox
            // 
            this.highlowbox.BackColor = System.Drawing.SystemColors.Control;
            this.highlowbox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.highlowbox.Location = new System.Drawing.Point(0, 192);
            this.highlowbox.Multiline = true;
            this.highlowbox.Name = "highlowbox";
            this.highlowbox.Size = new System.Drawing.Size(234, 79);
            this.highlowbox.TabIndex = 1;
            // 
            // playbox
            // 
            this.playbox.BackColor = System.Drawing.SystemColors.Control;
            this.playbox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.playbox.Location = new System.Drawing.Point(0, 31);
            this.playbox.Multiline = true;
            this.playbox.Name = "playbox";
            this.playbox.Size = new System.Drawing.Size(234, 155);
            this.playbox.TabIndex = 0;
            // 
            // namelb
            // 
            this.namelb.AutoSize = true;
            this.namelb.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.namelb.Location = new System.Drawing.Point(84, 65);
            this.namelb.Name = "namelb";
            this.namelb.Size = new System.Drawing.Size(75, 27);
            this.namelb.TabIndex = 8;
            this.namelb.Text = "姓名：";
            // 
            // chtlb
            // 
            this.chtlb.AutoSize = true;
            this.chtlb.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chtlb.Location = new System.Drawing.Point(84, 119);
            this.chtlb.Name = "chtlb";
            this.chtlb.Size = new System.Drawing.Size(75, 27);
            this.chtlb.TabIndex = 10;
            this.chtlb.Text = "國文：";
            // 
            // mathlb
            // 
            this.mathlb.AutoSize = true;
            this.mathlb.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mathlb.Location = new System.Drawing.Point(84, 224);
            this.mathlb.Name = "mathlb";
            this.mathlb.Size = new System.Drawing.Size(75, 27);
            this.mathlb.TabIndex = 11;
            this.mathlb.Text = "數學：";
            // 
            // englb
            // 
            this.englb.AutoSize = true;
            this.englb.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.englb.Location = new System.Drawing.Point(84, 170);
            this.englb.Name = "englb";
            this.englb.Size = new System.Drawing.Size(75, 27);
            this.englb.TabIndex = 12;
            this.englb.Text = "英文：";
            // 
            // Homework04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 375);
            this.Controls.Add(this.englb);
            this.Controls.Add(this.mathlb);
            this.Controls.Add(this.chtlb);
            this.Controls.Add(this.namelb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.engbox);
            this.Controls.Add(this.mathbox);
            this.Controls.Add(this.chtbox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Homework04";
            this.Text = "Homework04";
            this.Load += new System.EventHandler(this.Homework04_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox chtbox;
        private System.Windows.Forms.TextBox mathbox;
        private System.Windows.Forms.TextBox engbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox highlowbox;
        private System.Windows.Forms.TextBox playbox;
        private System.Windows.Forms.Label namelb;
        private System.Windows.Forms.Label chtlb;
        private System.Windows.Forms.Label mathlb;
        private System.Windows.Forms.Label englb;
    }
}