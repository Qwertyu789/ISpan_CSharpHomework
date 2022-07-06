
namespace CSharp_HomeWork
{
    partial class Homework10
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homework10));
            this.pboxO = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pboxO)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxO
            // 
            this.pboxO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxO.Image = ((System.Drawing.Image)(resources.GetObject("pboxO.Image")));
            this.pboxO.Location = new System.Drawing.Point(877, 12);
            this.pboxO.Name = "pboxO";
            this.pboxO.Size = new System.Drawing.Size(323, 259);
            this.pboxO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxO.TabIndex = 0;
            this.pboxO.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Homework10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1224, 637);
            this.Controls.Add(this.pboxO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Homework10";
            this.Text = "Homework10";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Homework10_Load);
            this.Click += new System.EventHandler(this.Homework10_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pboxO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxO;
        private System.Windows.Forms.Timer timer1;
    }
}