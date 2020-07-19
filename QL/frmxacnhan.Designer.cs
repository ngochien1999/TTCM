namespace QL
{
    partial class frmxacnhan
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtGmail = new System.Windows.Forms.TextBox();
            this.btnSent = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Salmon;
            this.gunaLabel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(171, 26);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(91, 23);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Xác nhận ";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.DarkOrange;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(39, 90);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(77, 15);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Tên tài khoản";
            this.gunaLabel2.Click += new System.EventHandler(this.gunaLabel2_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.DarkOrange;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(39, 156);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(36, 15);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "Email";
            this.gunaLabel3.Click += new System.EventHandler(this.gunaLabel3_Click);
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(147, 88);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(178, 20);
            this.txtTK.TabIndex = 3;
            this.txtTK.Text = "\r\n";
            this.txtTK.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtGmail
            // 
            this.txtGmail.Location = new System.Drawing.Point(147, 151);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(176, 20);
            this.txtGmail.TabIndex = 4;
            this.txtGmail.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            this.btnSent.Location = new System.Drawing.Point(322, 209);
            this.btnSent.Name = "btnSent";
            this.btnSent.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSent.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSent.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSent.OnHoverImage = null;
            this.btnSent.OnPressedColor = System.Drawing.Color.Black;
            this.btnSent.Size = new System.Drawing.Size(66, 28);
            this.btnSent.TabIndex = 5;
            this.btnSent.Text = "Gửi";
            this.btnSent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSent.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(410, 249);
            this.Controls.Add(this.btnSent);
            this.Controls.Add(this.txtGmail);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtGmail;
        private Guna.UI.WinForms.GunaButton btnSent;
    }
}