
namespace CSharp_HomeWork
{
    partial class Homework02_a
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
            this.TargetLB01 = new System.Windows.Forms.Label();
            this.TimelimitLB01 = new System.Windows.Forms.Label();
            this.RateLB01 = new System.Windows.Forms.Label();
            this.DPLB = new System.Windows.Forms.Label();
            this.TargetTB01 = new System.Windows.Forms.TextBox();
            this.TimelimitTB01 = new System.Windows.Forms.TextBox();
            this.RateTB01 = new System.Windows.Forms.TextBox();
            this.DPTB = new System.Windows.Forms.TextBox();
            this.PMTBut = new System.Windows.Forms.Button();
            this.TotalPayBut = new System.Windows.Forms.Button();
            this.ReportBut = new System.Windows.Forms.Button();
            this.FortestBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TargetLB01
            // 
            this.TargetLB01.AutoSize = true;
            this.TargetLB01.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TargetLB01.Location = new System.Drawing.Point(133, 74);
            this.TargetLB01.Name = "TargetLB01";
            this.TargetLB01.Size = new System.Drawing.Size(74, 21);
            this.TargetLB01.TabIndex = 4;
            this.TargetLB01.Text = "貸款金額";
            // 
            // TimelimitLB01
            // 
            this.TimelimitLB01.AutoSize = true;
            this.TimelimitLB01.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TimelimitLB01.Location = new System.Drawing.Point(133, 114);
            this.TimelimitLB01.Name = "TimelimitLB01";
            this.TimelimitLB01.Size = new System.Drawing.Size(42, 21);
            this.TimelimitLB01.TabIndex = 5;
            this.TimelimitLB01.Text = "期限";
            // 
            // RateLB01
            // 
            this.RateLB01.AutoSize = true;
            this.RateLB01.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RateLB01.Location = new System.Drawing.Point(133, 154);
            this.RateLB01.Name = "RateLB01";
            this.RateLB01.Size = new System.Drawing.Size(68, 21);
            this.RateLB01.TabIndex = 6;
            this.RateLB01.Text = "利率(%)";
            // 
            // DPLB
            // 
            this.DPLB.AutoSize = true;
            this.DPLB.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DPLB.Location = new System.Drawing.Point(133, 195);
            this.DPLB.Name = "DPLB";
            this.DPLB.Size = new System.Drawing.Size(58, 21);
            this.DPLB.TabIndex = 7;
            this.DPLB.Text = "頭期款";
            // 
            // TargetTB01
            // 
            this.TargetTB01.Location = new System.Drawing.Point(217, 74);
            this.TargetTB01.Name = "TargetTB01";
            this.TargetTB01.Size = new System.Drawing.Size(189, 22);
            this.TargetTB01.TabIndex = 8;
            // 
            // TimelimitTB01
            // 
            this.TimelimitTB01.Location = new System.Drawing.Point(217, 114);
            this.TimelimitTB01.Name = "TimelimitTB01";
            this.TimelimitTB01.Size = new System.Drawing.Size(189, 22);
            this.TimelimitTB01.TabIndex = 9;
            // 
            // RateTB01
            // 
            this.RateTB01.Location = new System.Drawing.Point(217, 154);
            this.RateTB01.Name = "RateTB01";
            this.RateTB01.Size = new System.Drawing.Size(189, 22);
            this.RateTB01.TabIndex = 10;
            // 
            // DPTB
            // 
            this.DPTB.Location = new System.Drawing.Point(217, 195);
            this.DPTB.Name = "DPTB";
            this.DPTB.Size = new System.Drawing.Size(189, 22);
            this.DPTB.TabIndex = 11;
            // 
            // PMTBut
            // 
            this.PMTBut.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PMTBut.Location = new System.Drawing.Point(112, 302);
            this.PMTBut.Name = "PMTBut";
            this.PMTBut.Size = new System.Drawing.Size(113, 43);
            this.PMTBut.TabIndex = 12;
            this.PMTBut.Text = "PMT(月付)";
            this.PMTBut.UseVisualStyleBackColor = true;
            this.PMTBut.Click += new System.EventHandler(this.PMTBut_Click);
            // 
            // TotalPayBut
            // 
            this.TotalPayBut.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TotalPayBut.Location = new System.Drawing.Point(243, 302);
            this.TotalPayBut.Name = "TotalPayBut";
            this.TotalPayBut.Size = new System.Drawing.Size(113, 43);
            this.TotalPayBut.TabIndex = 13;
            this.TotalPayBut.Text = "總金額";
            this.TotalPayBut.UseVisualStyleBackColor = true;
            // 
            // ReportBut
            // 
            this.ReportBut.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ReportBut.Location = new System.Drawing.Point(524, 302);
            this.ReportBut.Name = "ReportBut";
            this.ReportBut.Size = new System.Drawing.Size(113, 43);
            this.ReportBut.TabIndex = 14;
            this.ReportBut.Text = "報告";
            this.ReportBut.UseVisualStyleBackColor = true;
            // 
            // FortestBut
            // 
            this.FortestBut.Location = new System.Drawing.Point(137, 244);
            this.FortestBut.Name = "FortestBut";
            this.FortestBut.Size = new System.Drawing.Size(121, 35);
            this.FortestBut.TabIndex = 15;
            this.FortestBut.Text = "Fortest";
            this.FortestBut.UseVisualStyleBackColor = true;
 // todo          this.FortestBut.Click += new System.EventHandler(this.FortestBut_Click);
            // 
            // Homework02_a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 362);
            this.Controls.Add(this.FortestBut);
            this.Controls.Add(this.ReportBut);
            this.Controls.Add(this.TotalPayBut);
            this.Controls.Add(this.PMTBut);
            this.Controls.Add(this.DPTB);
            this.Controls.Add(this.RateTB01);
            this.Controls.Add(this.TimelimitTB01);
            this.Controls.Add(this.TargetTB01);
            this.Controls.Add(this.DPLB);
            this.Controls.Add(this.RateLB01);
            this.Controls.Add(this.TimelimitLB01);
            this.Controls.Add(this.TargetLB01);
            this.Name = "Homework02_a";
            this.Text = "Homework02_a";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TargetLB01;
        private System.Windows.Forms.Label TimelimitLB01;
        private System.Windows.Forms.Label RateLB01;
        private System.Windows.Forms.Label DPLB;
        private System.Windows.Forms.TextBox TargetTB01;
        private System.Windows.Forms.TextBox TimelimitTB01;
        private System.Windows.Forms.TextBox RateTB01;
        private System.Windows.Forms.TextBox DPTB;
        private System.Windows.Forms.Button PMTBut;
        private System.Windows.Forms.Button TotalPayBut;
        private System.Windows.Forms.Button ReportBut;
        private System.Windows.Forms.Button FortestBut;
    }
}