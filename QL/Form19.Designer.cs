namespace QL
{
    partial class Form19
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
            this.btnsent = new Guna.UI.WinForms.GunaButton();
            this.txtpassmoi = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // btnsent
            // 
            this.btnsent.AnimationHoverSpeed = 0.07F;
            this.btnsent.AnimationSpeed = 0.03F;
            this.btnsent.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnsent.BorderColor = System.Drawing.Color.Black;
            this.btnsent.FocusedColor = System.Drawing.Color.Empty;
            this.btnsent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsent.ForeColor = System.Drawing.Color.Black;
            this.btnsent.Image = null;
            this.btnsent.ImageSize = new System.Drawing.Size(20, 20);
            this.btnsent.Location = new System.Drawing.Point(298, 207);
            this.btnsent.Name = "btnsent";
            this.btnsent.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnsent.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnsent.OnHoverForeColor = System.Drawing.Color.White;
            this.btnsent.OnHoverImage = null;
            this.btnsent.OnPressedColor = System.Drawing.Color.Black;
            this.btnsent.Size = new System.Drawing.Size(66, 28);
            this.btnsent.TabIndex = 11;
            this.btnsent.Text = "Hoàn tất";
            this.btnsent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnsent.Click += new System.EventHandler(this.btnsent_Click);
            // 
            // txtpassmoi
            // 
            this.txtpassmoi.Location = new System.Drawing.Point(162, 157);
            this.txtpassmoi.Name = "txtpassmoi";
            this.txtpassmoi.Size = new System.Drawing.Size(176, 20);
            this.txtpassmoi.TabIndex = 10;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(160, 91);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(178, 20);
            this.txtpass.TabIndex = 9;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.DarkOrange;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(24, 162);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(128, 15);
            this.gunaLabel3.TabIndex = 8;
            this.gunaLabel3.Text = "Nhập lại mật khẩu mới";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.DarkOrange;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(24, 96);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(113, 15);
            this.gunaLabel2.TabIndex = 7;
            this.gunaLabel2.Text = "Nhập mật khẩu mới";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Salmon;
            this.gunaLabel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(156, 32);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(91, 23);
            this.gunaLabel1.TabIndex = 6;
            this.gunaLabel1.Text = "Xác nhận ";
            // 
            // Form19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(397, 274);
            this.Controls.Add(this.btnsent);
            this.Controls.Add(this.txtpassmoi);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form19";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form19";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnsent;
        private System.Windows.Forms.TextBox txtpassmoi;
        private System.Windows.Forms.TextBox txtpass;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}