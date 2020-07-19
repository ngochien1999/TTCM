namespace QL
{
    partial class Form21
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
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQRCode = new System.Windows.Forms.TextBox();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtemail = new Guna.UI.WinForms.GunaTextBox();
            this.txtcmnd = new Guna.UI.WinForms.GunaTextBox();
            this.txtdiachi = new Guna.UI.WinForms.GunaTextBox();
            this.txtsdt = new Guna.UI.WinForms.GunaTextBox();
            this.txttuoi = new Guna.UI.WinForms.GunaTextBox();
            this.txtten = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(406, 27);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(130, 46);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Camera";
            // 
            // txtQRCode
            // 
            this.txtQRCode.Location = new System.Drawing.Point(406, 79);
            this.txtQRCode.Multiline = true;
            this.txtQRCode.Name = "txtQRCode";
            this.txtQRCode.Size = new System.Drawing.Size(204, 45);
            this.txtQRCode.TabIndex = 2;
            this.txtQRCode.TextChanged += new System.EventHandler(this.txtQRCode_TextChanged);
            // 
            // cboDevice
            // 
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.Location = new System.Drawing.Point(121, 27);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(236, 21);
            this.cboDevice.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(56, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 273);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtemail
            // 
            this.txtemail.BaseColor = System.Drawing.Color.White;
            this.txtemail.BorderColor = System.Drawing.Color.Silver;
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemail.FocusedBaseColor = System.Drawing.Color.White;
            this.txtemail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtemail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtemail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtemail.Location = new System.Drawing.Point(787, 292);
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.Size = new System.Drawing.Size(196, 26);
            this.txtemail.TabIndex = 35;
            // 
            // txtcmnd
            // 
            this.txtcmnd.BaseColor = System.Drawing.Color.White;
            this.txtcmnd.BorderColor = System.Drawing.Color.Silver;
            this.txtcmnd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcmnd.FocusedBaseColor = System.Drawing.Color.White;
            this.txtcmnd.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtcmnd.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtcmnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtcmnd.Location = new System.Drawing.Point(787, 223);
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.PasswordChar = '\0';
            this.txtcmnd.Size = new System.Drawing.Size(196, 26);
            this.txtcmnd.TabIndex = 34;
            // 
            // txtdiachi
            // 
            this.txtdiachi.BaseColor = System.Drawing.Color.White;
            this.txtdiachi.BorderColor = System.Drawing.Color.Silver;
            this.txtdiachi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdiachi.FocusedBaseColor = System.Drawing.Color.White;
            this.txtdiachi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtdiachi.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtdiachi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtdiachi.Location = new System.Drawing.Point(787, 144);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.PasswordChar = '\0';
            this.txtdiachi.Size = new System.Drawing.Size(196, 26);
            this.txtdiachi.TabIndex = 33;
            // 
            // txtsdt
            // 
            this.txtsdt.BaseColor = System.Drawing.Color.White;
            this.txtsdt.BorderColor = System.Drawing.Color.Silver;
            this.txtsdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsdt.FocusedBaseColor = System.Drawing.Color.White;
            this.txtsdt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtsdt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtsdt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtsdt.Location = new System.Drawing.Point(460, 281);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.PasswordChar = '\0';
            this.txtsdt.Size = new System.Drawing.Size(196, 26);
            this.txtsdt.TabIndex = 32;
            // 
            // txttuoi
            // 
            this.txttuoi.BaseColor = System.Drawing.Color.White;
            this.txttuoi.BorderColor = System.Drawing.Color.Silver;
            this.txttuoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttuoi.FocusedBaseColor = System.Drawing.Color.White;
            this.txttuoi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txttuoi.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txttuoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txttuoi.Location = new System.Drawing.Point(460, 212);
            this.txttuoi.Name = "txttuoi";
            this.txttuoi.PasswordChar = '\0';
            this.txttuoi.Size = new System.Drawing.Size(196, 26);
            this.txttuoi.TabIndex = 31;
            // 
            // txtten
            // 
            this.txtten.BaseColor = System.Drawing.Color.White;
            this.txtten.BorderColor = System.Drawing.Color.Silver;
            this.txtten.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtten.FocusedBaseColor = System.Drawing.Color.White;
            this.txtten.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtten.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtten.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtten.Location = new System.Drawing.Point(460, 144);
            this.txtten.Name = "txtten";
            this.txtten.PasswordChar = '\0';
            this.txtten.Size = new System.Drawing.Size(196, 26);
            this.txtten.TabIndex = 30;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel7.Location = new System.Drawing.Point(714, 292);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(39, 15);
            this.gunaLabel7.TabIndex = 29;
            this.gunaLabel7.Text = "Email ";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(701, 223);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(43, 15);
            this.gunaLabel6.TabIndex = 28;
            this.gunaLabel6.Text = "CMND";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(701, 144);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(43, 15);
            this.gunaLabel5.TabIndex = 27;
            this.gunaLabel5.Text = "Địa chỉ";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(375, 292);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(79, 15);
            this.gunaLabel4.TabIndex = 26;
            this.gunaLabel4.Text = "Số điện thoại ";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(381, 223);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(30, 15);
            this.gunaLabel3.TabIndex = 25;
            this.gunaLabel3.Text = "Tuổi";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(381, 144);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(58, 15);
            this.gunaLabel2.TabIndex = 24;
            this.gunaLabel2.Text = "Họ và tên";
            // 
            // Form21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 441);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtcmnd);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txttuoi);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.cboDevice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtQRCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Name = "Form21";
            this.Text = "Form21";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form21_FormClosing);
            this.Load += new System.EventHandler(this.Form21_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQRCode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboDevice;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaTextBox txtemail;
        private Guna.UI.WinForms.GunaTextBox txtcmnd;
        private Guna.UI.WinForms.GunaTextBox txtdiachi;
        private Guna.UI.WinForms.GunaTextBox txtsdt;
        private Guna.UI.WinForms.GunaTextBox txttuoi;
        private Guna.UI.WinForms.GunaTextBox txtten;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}