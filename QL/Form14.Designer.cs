namespace QL
{
    partial class Form14
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
            this.btnSent = new Guna.UI.WinForms.GunaButton();
            this.txtmaxn = new System.Windows.Forms.TextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // btnSent
            // 
            this.btnSent.AnimationHoverSpeed = 0.07F;
            this.btnSent.AnimationSpeed = 0.03F;
            this.btnSent.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSent.BorderColor = System.Drawing.Color.Black;
            this.btnSent.FocusedColor = System.Drawing.Color.Empty;
            this.btnSent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSent.ForeColor = System.Drawing.Color.Black;
            this.btnSent.Image = null;
            this.btnSent.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSent.Location = new System.Drawing.Point(176, 159);
            this.btnSent.Name = "btnSent";
            this.btnSent.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSent.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSent.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSent.OnHoverImage = null;
            this.btnSent.OnPressedColor = System.Drawing.Color.Black;
            this.btnSent.Size = new System.Drawing.Size(66, 28);
            this.btnSent.TabIndex = 11;
            this.btnSent.Text = "Gửi";
            this.btnSent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSent.Click += new System.EventHandler(this.btnSent_Click);
            // 
            // txtmaxn
            // 
            this.txtmaxn.Location = new System.Drawing.Point(149, 98);
            this.txtmaxn.Name = "txtmaxn";
            this.txtmaxn.Size = new System.Drawing.Size(178, 20);
            this.txtmaxn.TabIndex = 9;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.DarkOrange;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(37, 98);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(80, 15);
            this.gunaLabel2.TabIndex = 7;
            this.gunaLabel2.Text = "Nhập mã OTP";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Salmon;
            this.gunaLabel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(172, 24);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(91, 23);
            this.gunaLabel1.TabIndex = 6;
            this.gunaLabel1.Text = "Xác Nhận";
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(429, 258);
            this.Controls.Add(this.btnSent);
            this.Controls.Add(this.txtmaxn);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form14";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form14";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnSent;
        private System.Windows.Forms.TextBox txtmaxn;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}