
namespace CSharp_HomeWork
{
    partial class Homework06
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbScoreList = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.butTotal = new System.Windows.Forms.Button();
            this.butADD = new System.Windows.Forms.Button();
            this.tbMath = new System.Windows.Forms.TextBox();
            this.tbEng = new System.Windows.Forms.TextBox();
            this.tbCht = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbMath = new System.Windows.Forms.Label();
            this.lbEng = new System.Windows.Forms.Label();
            this.lbCht = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.butInsert = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(150, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainer1.Panel1.Controls.Add(this.lbScoreList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbTotal);
            this.splitContainer1.Size = new System.Drawing.Size(376, 380);
            this.splitContainer1.SplitterDistance = 273;
            this.splitContainer1.TabIndex = 30;
            // 
            // lbScoreList
            // 
            this.lbScoreList.AutoEllipsis = true;
            this.lbScoreList.AutoSize = true;
            this.lbScoreList.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbScoreList.Location = new System.Drawing.Point(3, 0);
            this.lbScoreList.Name = "lbScoreList";
            this.lbScoreList.Size = new System.Drawing.Size(0, 13);
            this.lbScoreList.TabIndex = 15;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(4, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(0, 12);
            this.lbTotal.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(11, 289);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 31);
            this.button4.TabIndex = 28;
            this.button4.Text = "重設所有資料";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // butTotal
            // 
            this.butTotal.Enabled = false;
            this.butTotal.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butTotal.Location = new System.Drawing.Point(402, 398);
            this.butTotal.Name = "butTotal";
            this.butTotal.Size = new System.Drawing.Size(124, 31);
            this.butTotal.TabIndex = 27;
            this.butTotal.Text = "各科統計";
            this.butTotal.UseVisualStyleBackColor = true;
            this.butTotal.Click += new System.EventHandler(this.button3_Click);
            // 
            // butADD
            // 
            this.butADD.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butADD.Location = new System.Drawing.Point(11, 178);
            this.butADD.Name = "butADD";
            this.butADD.Size = new System.Drawing.Size(124, 31);
            this.butADD.TabIndex = 25;
            this.butADD.Text = "加入學生資料";
            this.butADD.UseVisualStyleBackColor = true;
            this.butADD.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbMath
            // 
            this.tbMath.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbMath.Location = new System.Drawing.Point(68, 133);
            this.tbMath.Name = "tbMath";
            this.tbMath.Size = new System.Drawing.Size(76, 30);
            this.tbMath.TabIndex = 24;
            // 
            // tbEng
            // 
            this.tbEng.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbEng.Location = new System.Drawing.Point(68, 93);
            this.tbEng.Name = "tbEng";
            this.tbEng.Size = new System.Drawing.Size(76, 30);
            this.tbEng.TabIndex = 23;
            // 
            // tbCht
            // 
            this.tbCht.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbCht.Location = new System.Drawing.Point(68, 52);
            this.tbCht.Name = "tbCht";
            this.tbCht.Size = new System.Drawing.Size(76, 30);
            this.tbCht.TabIndex = 22;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbName.Location = new System.Drawing.Point(68, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(76, 30);
            this.tbName.TabIndex = 21;
            // 
            // lbMath
            // 
            this.lbMath.AutoSize = true;
            this.lbMath.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbMath.Location = new System.Drawing.Point(7, 133);
            this.lbMath.Name = "lbMath";
            this.lbMath.Size = new System.Drawing.Size(67, 24);
            this.lbMath.TabIndex = 20;
            this.lbMath.Text = "數學：";
            // 
            // lbEng
            // 
            this.lbEng.AutoSize = true;
            this.lbEng.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbEng.Location = new System.Drawing.Point(7, 93);
            this.lbEng.Name = "lbEng";
            this.lbEng.Size = new System.Drawing.Size(67, 24);
            this.lbEng.TabIndex = 19;
            this.lbEng.Text = "英文：";
            // 
            // lbCht
            // 
            this.lbCht.AutoSize = true;
            this.lbCht.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbCht.Location = new System.Drawing.Point(7, 52);
            this.lbCht.Name = "lbCht";
            this.lbCht.Size = new System.Drawing.Size(67, 24);
            this.lbCht.TabIndex = 18;
            this.lbCht.Text = "國文：";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbName.Location = new System.Drawing.Point(7, 12);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(67, 24);
            this.lbName.TabIndex = 17;
            this.lbName.Text = "姓名：";
            // 
            // butInsert
            // 
            this.butInsert.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butInsert.Location = new System.Drawing.Point(11, 215);
            this.butInsert.Name = "butInsert";
            this.butInsert.Size = new System.Drawing.Size(124, 31);
            this.butInsert.TabIndex = 31;
            this.butInsert.Text = "插入學生資料";
            this.butInsert.UseVisualStyleBackColor = true;
            this.butInsert.Click += new System.EventHandler(this.butInsert_Click);
            // 
            // butDelete
            // 
            this.butDelete.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butDelete.Location = new System.Drawing.Point(11, 252);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(124, 31);
            this.butDelete.TabIndex = 32;
            this.butDelete.Text = "刪除學生資料";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butSearch
            // 
            this.butSearch.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butSearch.Location = new System.Drawing.Point(11, 380);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(124, 31);
            this.butSearch.TabIndex = 33;
            this.butSearch.Text = "Search";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(11, 349);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 25);
            this.textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2.Location = new System.Drawing.Point(87, 349);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(48, 25);
            this.textBox2.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(4, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "搜尋國文成績範圍";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(66, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "-";
            // 
            // Homework06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 435);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butInsert);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.butTotal);
            this.Controls.Add(this.butADD);
            this.Controls.Add(this.tbMath);
            this.Controls.Add(this.tbEng);
            this.Controls.Add(this.tbCht);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbMath);
            this.Controls.Add(this.lbEng);
            this.Controls.Add(this.lbCht);
            this.Controls.Add(this.lbName);
            this.Name = "Homework06";
            this.Text = "Homework06";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbScoreList;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button butTotal;
        private System.Windows.Forms.Button butADD;
        private System.Windows.Forms.TextBox tbMath;
        private System.Windows.Forms.TextBox tbEng;
        private System.Windows.Forms.TextBox tbCht;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbMath;
        private System.Windows.Forms.Label lbEng;
        private System.Windows.Forms.Label lbCht;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button butInsert;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}