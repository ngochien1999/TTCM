namespace QL
{
    partial class Form13
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
            this.pcchinh = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcchinh)).BeginInit();
            this.SuspendLayout();
            // 
            // pcchinh
            // 
            this.pcchinh.Image = global::QL.Properties.Resources.maybay10;
            this.pcchinh.Location = new System.Drawing.Point(-8, -19);
            this.pcchinh.Name = "pcchinh";
            this.pcchinh.Size = new System.Drawing.Size(946, 602);
            this.pcchinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcchinh.TabIndex = 4;
            this.pcchinh.TabStop = false;
            this.pcchinh.Click += new System.EventHandler(this.pcchinh_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.pcchinh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form13";
            this.Text = "Form13";
            ((System.ComponentModel.ISupportInitialize)(this.pcchinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcchinh;
        private System.Windows.Forms.Timer timer1;
    }
}