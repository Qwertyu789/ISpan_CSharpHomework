
namespace CSharp_HomeWork
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.NameCNLb = new System.Windows.Forms.Label();
            this.NameENLb = new System.Windows.Forms.Label();
            this.GenderLb = new System.Windows.Forms.Label();
            this.SignLb = new System.Windows.Forms.Label();
            this.Hi_But = new System.Windows.Forms.Button();
            this.HelloBut = new System.Windows.Forms.Button();
            this.NameCNTB = new System.Windows.Forms.TextBox();
            this.NameENTB = new System.Windows.Forms.TextBox();
            this.GenderTB = new System.Windows.Forms.TextBox();
            this.SignTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NameCNLb
            // 
            this.NameCNLb.AutoSize = true;
            this.NameCNLb.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NameCNLb.Location = new System.Drawing.Point(37, 84);
            this.NameCNLb.Name = "NameCNLb";
            this.NameCNLb.Size = new System.Drawing.Size(57, 20);
            this.NameCNLb.TabIndex = 0;
            this.NameCNLb.Text = "姓名：";
            // 
            // NameENLb
            // 
            this.NameENLb.AutoSize = true;
            this.NameENLb.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NameENLb.Location = new System.Drawing.Point(39, 141);
            this.NameENLb.Name = "NameENLb";
            this.NameENLb.Size = new System.Drawing.Size(71, 20);
            this.NameENLb.TabIndex = 1;
            this.NameENLb.Text = "Name：";
            // 
            // GenderLb
            // 
            this.GenderLb.AutoSize = true;
            this.GenderLb.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GenderLb.Location = new System.Drawing.Point(39, 191);
            this.GenderLb.Name = "GenderLb";
            this.GenderLb.Size = new System.Drawing.Size(57, 20);
            this.GenderLb.TabIndex = 2;
            this.GenderLb.Text = "性別：";
            // 
            // SignLb
            // 
            this.SignLb.AutoSize = true;
            this.SignLb.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SignLb.Location = new System.Drawing.Point(39, 236);
            this.SignLb.Name = "SignLb";
            this.SignLb.Size = new System.Drawing.Size(57, 20);
            this.SignLb.TabIndex = 3;
            this.SignLb.Text = "星座：";
            // 
            // Hi_But
            // 
            this.Hi_But.Location = new System.Drawing.Point(42, 321);
            this.Hi_But.Name = "Hi_But";
            this.Hi_But.Size = new System.Drawing.Size(133, 44);
            this.Hi_But.TabIndex = 4;
            this.Hi_But.Text = "HI";
            this.Hi_But.UseVisualStyleBackColor = true;
            this.Hi_But.Click += new System.EventHandler(this.Hi_But_Click);
            // 
            // HelloBut
            // 
            this.HelloBut.Location = new System.Drawing.Point(243, 320);
            this.HelloBut.Name = "HelloBut";
            this.HelloBut.Size = new System.Drawing.Size(133, 44);
            this.HelloBut.TabIndex = 5;
            this.HelloBut.Text = "Hello";
            this.HelloBut.UseVisualStyleBackColor = true;
            // 
            // NameCNTB
            // 
            this.NameCNTB.Location = new System.Drawing.Point(136, 84);
            this.NameCNTB.Name = "NameCNTB";
            this.NameCNTB.Size = new System.Drawing.Size(100, 22);
            this.NameCNTB.TabIndex = 6;
            // 
            // NameENTB
            // 
            this.NameENTB.Location = new System.Drawing.Point(136, 141);
            this.NameENTB.Name = "NameENTB";
            this.NameENTB.Size = new System.Drawing.Size(100, 22);
            this.NameENTB.TabIndex = 7;
            // 
            // GenderTB
            // 
            this.GenderTB.Location = new System.Drawing.Point(136, 191);
            this.GenderTB.Name = "GenderTB";
            this.GenderTB.Size = new System.Drawing.Size(100, 22);
            this.GenderTB.TabIndex = 8;
            // 
            // SignTB
            // 
            this.SignTB.Location = new System.Drawing.Point(136, 236);
            this.SignTB.Name = "SignTB";
            this.SignTB.Size = new System.Drawing.Size(100, 22);
            this.SignTB.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SignTB);
            this.Controls.Add(this.GenderTB);
            this.Controls.Add(this.NameENTB);
            this.Controls.Add(this.NameCNTB);
            this.Controls.Add(this.HelloBut);
            this.Controls.Add(this.Hi_But);
            this.Controls.Add(this.SignLb);
            this.Controls.Add(this.GenderLb);
            this.Controls.Add(this.NameENLb);
            this.Controls.Add(this.NameCNLb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameCNLb;
        private System.Windows.Forms.Label NameENLb;
        private System.Windows.Forms.Label GenderLb;
        private System.Windows.Forms.Label SignLb;
        private System.Windows.Forms.Button Hi_But;
        private System.Windows.Forms.Button HelloBut;
        private System.Windows.Forms.TextBox NameCNTB;
        private System.Windows.Forms.TextBox NameENTB;
        private System.Windows.Forms.TextBox GenderTB;
        private System.Windows.Forms.TextBox SignTB;
    }
}

