namespace QL
{
    partial class frmemail
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.txtSubject = new Guna.UI.WinForms.GunaTextBox();
            this.txtCC = new Guna.UI.WinForms.GunaTextBox();
            this.txtMessage = new Guna.UI.WinForms.GunaTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSend = new Guna.UI.WinForms.GunaButton();
            this.chkssl = new Guna.UI.WinForms.GunaCheckBox();
            this.txtSmtp = new Guna.UI.WinForms.GunaTextBox();
            this.txtPort = new Guna.UI.WinForms.GunaTextBox();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.txtussename = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtTo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.makhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTkhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.đCkhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMNDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khachhangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBCMBDataSet14 = new QL.QLBCMBDataSet14();
            this.khachhangTableAdapter = new QL.QLBCMBDataSet14TableAdapters.KhachhangTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBCMBDataSet14)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(63, 71);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(19, 15);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "To";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(64, 283);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(53, 15);
            this.gunaLabel4.TabIndex = 3;
            this.gunaLabel4.Text = "Message";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(63, 176);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(46, 15);
            this.gunaLabel5.TabIndex = 4;
            this.gunaLabel5.Text = "Subject";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(63, 131);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(23, 15);
            this.gunaLabel6.TabIndex = 5;
            this.gunaLabel6.Text = "CC";
            // 
            // txtSubject
            // 
            this.txtSubject.BaseColor = System.Drawing.Color.White;
            this.txtSubject.BorderColor = System.Drawing.Color.Silver;
            this.txtSubject.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSubject.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSubject.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSubject.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSubject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSubject.Location = new System.Drawing.Point(122, 165);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.PasswordChar = '\0';
            this.txtSubject.Size = new System.Drawing.Size(289, 26);
            this.txtSubject.TabIndex = 2;
            // 
            // txtCC
            // 
            this.txtCC.BaseColor = System.Drawing.Color.White;
            this.txtCC.BorderColor = System.Drawing.Color.Silver;
            this.txtCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCC.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCC.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCC.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCC.Location = new System.Drawing.Point(122, 120);
            this.txtCC.Name = "txtCC";
            this.txtCC.PasswordChar = '\0';
            this.txtCC.Size = new System.Drawing.Size(289, 26);
            this.txtCC.TabIndex = 1;
            // 
            // txtMessage
            // 
            this.txtMessage.BaseColor = System.Drawing.Color.White;
            this.txtMessage.BorderColor = System.Drawing.Color.Silver;
            this.txtMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMessage.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMessage.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMessage.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMessage.Location = new System.Drawing.Point(123, 217);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.PasswordChar = '\0';
            this.txtMessage.Size = new System.Drawing.Size(426, 154);
            this.txtMessage.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.chkssl);
            this.groupBox1.Controls.Add(this.txtSmtp);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtussename);
            this.groupBox1.Controls.Add(this.gunaLabel8);
            this.groupBox1.Controls.Add(this.gunaLabel7);
            this.groupBox1.Controls.Add(this.gunaLabel3);
            this.groupBox1.Controls.Add(this.gunaLabel2);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(446, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 141);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cài đặt";
            // 
            // btnSend
            // 
            this.btnSend.AnimationHoverSpeed = 0.07F;
            this.btnSend.AnimationSpeed = 0.03F;
            this.btnSend.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSend.BorderColor = System.Drawing.Color.Black;
            this.btnSend.FocusedColor = System.Drawing.Color.Empty;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Image = null;
            this.btnSend.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSend.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSend.Location = new System.Drawing.Point(336, 50);
            this.btnSend.Name = "btnSend";
            this.btnSend.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSend.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSend.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSend.OnHoverImage = null;
            this.btnSend.OnPressedColor = System.Drawing.Color.Black;
            this.btnSend.Size = new System.Drawing.Size(89, 25);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // chkssl
            // 
            this.chkssl.BaseColor = System.Drawing.Color.White;
            this.chkssl.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkssl.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chkssl.FillColor = System.Drawing.Color.White;
            this.chkssl.Location = new System.Drawing.Point(331, 16);
            this.chkssl.Name = "chkssl";
            this.chkssl.Size = new System.Drawing.Size(51, 20);
            this.chkssl.TabIndex = 1;
            this.chkssl.Text = "SSL";
            // 
            // txtSmtp
            // 
            this.txtSmtp.BaseColor = System.Drawing.Color.White;
            this.txtSmtp.BorderColor = System.Drawing.Color.Silver;
            this.txtSmtp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSmtp.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSmtp.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSmtp.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSmtp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSmtp.Location = new System.Drawing.Point(250, 94);
            this.txtSmtp.Name = "txtSmtp";
            this.txtSmtp.PasswordChar = '\0';
            this.txtSmtp.Size = new System.Drawing.Size(217, 26);
            this.txtSmtp.TabIndex = 4;
            this.txtSmtp.Text = "smtp.gmail.com";
            // 
            // txtPort
            // 
            this.txtPort.BaseColor = System.Drawing.Color.White;
            this.txtPort.BorderColor = System.Drawing.Color.Silver;
            this.txtPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPort.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPort.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPort.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPort.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPort.Location = new System.Drawing.Point(108, 94);
            this.txtPort.Name = "txtPort";
            this.txtPort.PasswordChar = '\0';
            this.txtPort.Size = new System.Drawing.Size(63, 26);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "587";
            // 
            // txtPassword
            // 
            this.txtPassword.BaseColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.Location = new System.Drawing.Point(108, 50);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.Size = new System.Drawing.Size(217, 26);
            this.txtPassword.TabIndex = 2;
            // 
            // txtussename
            // 
            this.txtussename.BaseColor = System.Drawing.Color.White;
            this.txtussename.BorderColor = System.Drawing.Color.Silver;
            this.txtussename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtussename.FocusedBaseColor = System.Drawing.Color.White;
            this.txtussename.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtussename.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtussename.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtussename.Location = new System.Drawing.Point(108, 10);
            this.txtussename.Name = "txtussename";
            this.txtussename.PasswordChar = '\0';
            this.txtussename.Size = new System.Drawing.Size(217, 26);
            this.txtussename.TabIndex = 0;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel8.Location = new System.Drawing.Point(177, 105);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(35, 15);
            this.gunaLabel8.TabIndex = 1;
            this.gunaLabel8.Text = "Smtp";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel7.Location = new System.Drawing.Point(23, 105);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(29, 15);
            this.gunaLabel7.TabIndex = 2;
            this.gunaLabel7.Text = "Port";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(23, 61);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(57, 15);
            this.gunaLabel3.TabIndex = 1;
            this.gunaLabel3.Text = "Password";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(23, 21);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(56, 15);
            this.gunaLabel2.TabIndex = 0;
            this.gunaLabel2.Text = "Usename";
            // 
            // txtTo
            // 
            this.txtTo.FormattingEnabled = true;
            this.txtTo.Location = new System.Drawing.Point(122, 71);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(289, 21);
            this.txtTo.TabIndex = 49;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makhDataGridViewTextBoxColumn,
            this.tenkhDataGridViewTextBoxColumn,
            this.tuoiDataGridViewTextBoxColumn,
            this.sDTkhDataGridViewTextBoxColumn,
            this.đCkhDataGridViewTextBoxColumn,
            this.cMNDDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.khachhangBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(67, 377);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(856, 129);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // makhDataGridViewTextBoxColumn
            // 
            this.makhDataGridViewTextBoxColumn.DataPropertyName = "Makh";
            this.makhDataGridViewTextBoxColumn.HeaderText = "Mã KH";
            this.makhDataGridViewTextBoxColumn.Name = "makhDataGridViewTextBoxColumn";
            this.makhDataGridViewTextBoxColumn.Width = 110;
            // 
            // tenkhDataGridViewTextBoxColumn
            // 
            this.tenkhDataGridViewTextBoxColumn.DataPropertyName = "Tenkh";
            this.tenkhDataGridViewTextBoxColumn.HeaderText = "Họ và tên KH";
            this.tenkhDataGridViewTextBoxColumn.Name = "tenkhDataGridViewTextBoxColumn";
            this.tenkhDataGridViewTextBoxColumn.Width = 110;
            // 
            // tuoiDataGridViewTextBoxColumn
            // 
            this.tuoiDataGridViewTextBoxColumn.DataPropertyName = "Tuoi";
            this.tuoiDataGridViewTextBoxColumn.HeaderText = "Tuổi KH";
            this.tuoiDataGridViewTextBoxColumn.Name = "tuoiDataGridViewTextBoxColumn";
            this.tuoiDataGridViewTextBoxColumn.Width = 110;
            // 
            // sDTkhDataGridViewTextBoxColumn
            // 
            this.sDTkhDataGridViewTextBoxColumn.DataPropertyName = "SDTkh";
            this.sDTkhDataGridViewTextBoxColumn.HeaderText = "SĐT KH";
            this.sDTkhDataGridViewTextBoxColumn.Name = "sDTkhDataGridViewTextBoxColumn";
            this.sDTkhDataGridViewTextBoxColumn.Width = 110;
            // 
            // đCkhDataGridViewTextBoxColumn
            // 
            this.đCkhDataGridViewTextBoxColumn.DataPropertyName = "ĐCkh";
            this.đCkhDataGridViewTextBoxColumn.HeaderText = "Địa chỉ KH";
            this.đCkhDataGridViewTextBoxColumn.Name = "đCkhDataGridViewTextBoxColumn";
            this.đCkhDataGridViewTextBoxColumn.Width = 110;
            // 
            // cMNDDataGridViewTextBoxColumn
            // 
            this.cMNDDataGridViewTextBoxColumn.DataPropertyName = "CMND";
            this.cMNDDataGridViewTextBoxColumn.HeaderText = "CMND KH";
            this.cMNDDataGridViewTextBoxColumn.Name = "cMNDDataGridViewTextBoxColumn";
            this.cMNDDataGridViewTextBoxColumn.Width = 110;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email KH";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // khachhangBindingSource
            // 
            this.khachhangBindingSource.DataMember = "Khachhang";
            this.khachhangBindingSource.DataSource = this.qLBCMBDataSet14;
            // 
            // qLBCMBDataSet14
            // 
            this.qLBCMBDataSet14.DataSetName = "QLBCMBDataSet14";
            this.qLBCMBDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khachhangTableAdapter
            // 
            this.khachhangTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(607, 283);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 20);
            this.textBox1.TabIndex = 51;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(841, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 34);
            this.button1.TabIndex = 52;
            this.button1.Text = "Chọn File";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LemonChiffon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 53;
            this.label1.Text = "Email";
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.White;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = global::QL.Properties.Resources.exit1;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(968, 2);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(33, 32);
            this.gunaButton1.TabIndex = 54;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1004, 518);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form15";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form15";
            this.Load += new System.EventHandler(this.Form15_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBCMBDataSet14)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaTextBox txtSubject;
        private Guna.UI.WinForms.GunaTextBox txtCC;
        private Guna.UI.WinForms.GunaTextBox txtMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaButton btnSend;
        private Guna.UI.WinForms.GunaCheckBox chkssl;
        private Guna.UI.WinForms.GunaTextBox txtSmtp;
        private Guna.UI.WinForms.GunaTextBox txtPort;
        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private Guna.UI.WinForms.GunaTextBox txtussename;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.ComboBox txtTo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLBCMBDataSet14 qLBCMBDataSet14;
        private System.Windows.Forms.BindingSource khachhangBindingSource;
        private QLBCMBDataSet14TableAdapters.KhachhangTableAdapter khachhangTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTkhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn đCkhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMNDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
    }
}