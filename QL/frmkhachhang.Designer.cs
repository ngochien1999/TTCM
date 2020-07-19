namespace QL
{
    partial class frmkhachhang
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
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.makhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTkhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.đCkhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMNDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khachhangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBCMBDataSet13 = new QL.QLBCMBDataSet13();
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.khachhangTableAdapter = new QL.QLBCMBDataSet13TableAdapters.KhachhangTableAdapter();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.txtten = new Guna.UI.WinForms.GunaTextBox();
            this.txttuoi = new Guna.UI.WinForms.GunaTextBox();
            this.txtsdt = new Guna.UI.WinForms.GunaTextBox();
            this.txtdiachi = new Guna.UI.WinForms.GunaTextBox();
            this.txtcmnd = new Guna.UI.WinForms.GunaTextBox();
            this.txtemail = new Guna.UI.WinForms.GunaTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton6 = new Guna.UI.WinForms.GunaButton();
            this.btnLuu = new Guna.UI.WinForms.GunaButton();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.btnHuy = new Guna.UI.WinForms.GunaButton();
            this.btnsua = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.btnthem = new System.Windows.Forms.PictureBox();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtQRCode = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBCMBDataSet13)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnthem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(17, 377);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(180, 26);
            this.txttimkiem.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dataGridView1.Location = new System.Drawing.Point(1, 385);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(726, 173);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // makhDataGridViewTextBoxColumn
            // 
            this.makhDataGridViewTextBoxColumn.DataPropertyName = "Makh";
            this.makhDataGridViewTextBoxColumn.HeaderText = "Mã KH ";
            this.makhDataGridViewTextBoxColumn.Name = "makhDataGridViewTextBoxColumn";
            // 
            // tenkhDataGridViewTextBoxColumn
            // 
            this.tenkhDataGridViewTextBoxColumn.DataPropertyName = "Tenkh";
            this.tenkhDataGridViewTextBoxColumn.HeaderText = "Tên KH";
            this.tenkhDataGridViewTextBoxColumn.Name = "tenkhDataGridViewTextBoxColumn";
            // 
            // tuoiDataGridViewTextBoxColumn
            // 
            this.tuoiDataGridViewTextBoxColumn.DataPropertyName = "Tuoi";
            this.tuoiDataGridViewTextBoxColumn.HeaderText = "Tuổi";
            this.tuoiDataGridViewTextBoxColumn.Name = "tuoiDataGridViewTextBoxColumn";
            // 
            // sDTkhDataGridViewTextBoxColumn
            // 
            this.sDTkhDataGridViewTextBoxColumn.DataPropertyName = "SDTkh";
            this.sDTkhDataGridViewTextBoxColumn.HeaderText = "SĐT KH";
            this.sDTkhDataGridViewTextBoxColumn.Name = "sDTkhDataGridViewTextBoxColumn";
            // 
            // đCkhDataGridViewTextBoxColumn
            // 
            this.đCkhDataGridViewTextBoxColumn.DataPropertyName = "ĐCkh";
            this.đCkhDataGridViewTextBoxColumn.HeaderText = "ĐC KH";
            this.đCkhDataGridViewTextBoxColumn.Name = "đCkhDataGridViewTextBoxColumn";
            // 
            // cMNDDataGridViewTextBoxColumn
            // 
            this.cMNDDataGridViewTextBoxColumn.DataPropertyName = "CMND";
            this.cMNDDataGridViewTextBoxColumn.HeaderText = "CMND";
            this.cMNDDataGridViewTextBoxColumn.Name = "cMNDDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // khachhangBindingSource
            // 
            this.khachhangBindingSource.DataMember = "Khachhang";
            this.khachhangBindingSource.DataSource = this.qLBCMBDataSet13;
            // 
            // qLBCMBDataSet13
            // 
            this.qLBCMBDataSet13.DataSetName = "QLBCMBDataSet13";
            this.qLBCMBDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.Appearance.Options.UseFont = true;
            this.progressPanel1.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressPanel1.AppearanceCaption.Options.UseFont = true;
            this.progressPanel1.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.progressPanel1.AppearanceDescription.Options.UseFont = true;
            this.progressPanel1.BarAnimationElementThickness = 2;
            this.progressPanel1.Caption = "BamBoo AirLine";
            this.progressPanel1.Location = new System.Drawing.Point(1, 564);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(727, 39);
            this.progressPanel1.TabIndex = 19;
            this.progressPanel1.Text = "progressPanel1";
            // 
            // khachhangTableAdapter
            // 
            this.khachhangTableAdapter.ClearBeforeFill = true;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gunaLabel1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.gunaLabel1.Location = new System.Drawing.Point(91, 34);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(127, 27);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Khách hàng";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(500, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 13);
            this.labelControl1.TabIndex = 90;
            this.labelControl1.Text = "Quyền Sử Dụng:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(536, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(115, 13);
            this.labelControl2.TabIndex = 91;
            this.labelControl2.Text = "*Admin -Nhân viên*";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(515, 68);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(145, 13);
            this.labelControl3.TabIndex = 92;
            this.labelControl3.Text = "-----------------------------";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gunaPanel1.Controls.Add(this.labelControl3);
            this.gunaPanel1.Controls.Add(this.labelControl2);
            this.gunaPanel1.Controls.Add(this.labelControl1);
            this.gunaPanel1.Controls.Add(this.pictureBox1);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Location = new System.Drawing.Point(1, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(726, 102);
            this.gunaPanel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::QL.Properties.Resources.kh2;
            this.pictureBox1.Image = global::QL.Properties.Resources.kh2;
            this.pictureBox1.Location = new System.Drawing.Point(289, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(12, 35);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(58, 15);
            this.gunaLabel2.TabIndex = 12;
            this.gunaLabel2.Text = "Họ và tên";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(12, 72);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(30, 15);
            this.gunaLabel3.TabIndex = 13;
            this.gunaLabel3.Text = "Tuổi";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(6, 116);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(79, 15);
            this.gunaLabel4.TabIndex = 14;
            this.gunaLabel4.Text = "Số điện thoại ";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(12, 156);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(43, 15);
            this.gunaLabel5.TabIndex = 15;
            this.gunaLabel5.Text = "Địa chỉ";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(6, 193);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(43, 15);
            this.gunaLabel6.TabIndex = 16;
            this.gunaLabel6.Text = "CMND";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel7.Location = new System.Drawing.Point(12, 226);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(39, 15);
            this.gunaLabel7.TabIndex = 17;
            this.gunaLabel7.Text = "Email ";
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
            this.txtten.Location = new System.Drawing.Point(94, 24);
            this.txtten.Name = "txtten";
            this.txtten.PasswordChar = '\0';
            this.txtten.Size = new System.Drawing.Size(193, 26);
            this.txtten.TabIndex = 18;
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
            this.txttuoi.Location = new System.Drawing.Point(94, 61);
            this.txttuoi.Name = "txttuoi";
            this.txttuoi.PasswordChar = '\0';
            this.txttuoi.Size = new System.Drawing.Size(193, 26);
            this.txttuoi.TabIndex = 19;
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
            this.txtsdt.Location = new System.Drawing.Point(94, 105);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.PasswordChar = '\0';
            this.txtsdt.Size = new System.Drawing.Size(193, 26);
            this.txtsdt.TabIndex = 20;
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
            this.txtdiachi.Location = new System.Drawing.Point(94, 145);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.PasswordChar = '\0';
            this.txtdiachi.Size = new System.Drawing.Size(196, 26);
            this.txtdiachi.TabIndex = 21;
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
            this.txtcmnd.Location = new System.Drawing.Point(94, 182);
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.PasswordChar = '\0';
            this.txtcmnd.Size = new System.Drawing.Size(196, 26);
            this.txtcmnd.TabIndex = 22;
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
            this.txtemail.Location = new System.Drawing.Point(94, 226);
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.Size = new System.Drawing.Size(196, 26);
            this.txtemail.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox2.Controls.Add(this.txtemail);
            this.groupBox2.Controls.Add(this.txtcmnd);
            this.groupBox2.Controls.Add(this.txtdiachi);
            this.groupBox2.Controls.Add(this.txtsdt);
            this.groupBox2.Controls.Add(this.txttuoi);
            this.groupBox2.Controls.Add(this.txtten);
            this.groupBox2.Controls.Add(this.gunaLabel7);
            this.groupBox2.Controls.Add(this.gunaLabel6);
            this.groupBox2.Controls.Add(this.gunaLabel5);
            this.groupBox2.Controls.Add(this.gunaLabel4);
            this.groupBox2.Controls.Add(this.gunaLabel3);
            this.groupBox2.Controls.Add(this.gunaLabel2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(0, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 261);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng";
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.gunaButton1);
            this.gunaGroupBox2.Controls.Add(this.gunaButton6);
            this.gunaGroupBox2.Controls.Add(this.txttimkiem);
            this.gunaGroupBox2.Controls.Add(this.btnLuu);
            this.gunaGroupBox2.Controls.Add(this.gunaButton4);
            this.gunaGroupBox2.Controls.Add(this.btnHuy);
            this.gunaGroupBox2.Controls.Add(this.btnsua);
            this.gunaGroupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox2.Location = new System.Drawing.Point(727, 98);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Size = new System.Drawing.Size(218, 460);
            this.gunaGroupBox2.TabIndex = 94;
            this.gunaGroupBox2.Text = "Chức năng";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(40, 422);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(142, 35);
            this.gunaButton1.TabIndex = 21;
            this.gunaButton1.Text = "Xuất EXCEL khách hàng";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click_1);
            // 
            // gunaButton6
            // 
            this.gunaButton6.AnimationHoverSpeed = 0.07F;
            this.gunaButton6.AnimationSpeed = 0.03F;
            this.gunaButton6.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gunaButton6.BorderColor = System.Drawing.Color.Black;
            this.gunaButton6.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton6.ForeColor = System.Drawing.Color.Black;
            this.gunaButton6.Image = global::QL.Properties.Resources.them1;
            this.gunaButton6.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton6.Location = new System.Drawing.Point(40, 45);
            this.gunaButton6.Name = "gunaButton6";
            this.gunaButton6.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton6.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton6.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton6.OnHoverImage = null;
            this.gunaButton6.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton6.Size = new System.Drawing.Size(142, 35);
            this.gunaButton6.TabIndex = 14;
            this.gunaButton6.Text = "Thêm ";
            this.gunaButton6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton6.Click += new System.EventHandler(this.gunaButton6_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.AnimationHoverSpeed = 0.07F;
            this.btnLuu.AnimationSpeed = 0.03F;
            this.btnLuu.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLuu.BorderColor = System.Drawing.Color.Black;
            this.btnLuu.FocusedColor = System.Drawing.Color.Empty;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Image = global::QL.Properties.Resources.pngtree_cancel_vector_icon_png_image_37254283;
            this.btnLuu.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLuu.Location = new System.Drawing.Point(40, 119);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnLuu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLuu.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLuu.OnHoverImage = null;
            this.btnLuu.OnPressedColor = System.Drawing.Color.Black;
            this.btnLuu.Size = new System.Drawing.Size(142, 35);
            this.btnLuu.TabIndex = 19;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // gunaButton4
            // 
            this.gunaButton4.AnimationHoverSpeed = 0.07F;
            this.gunaButton4.AnimationSpeed = 0.03F;
            this.gunaButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gunaButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton4.ForeColor = System.Drawing.Color.Black;
            this.gunaButton4.Image = global::QL.Properties.Resources.Timkiem1;
            this.gunaButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton4.Location = new System.Drawing.Point(40, 315);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton4.Size = new System.Drawing.Size(142, 35);
            this.gunaButton4.TabIndex = 16;
            this.gunaButton4.Text = "Tìm kiếm";
            this.gunaButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton4.Click += new System.EventHandler(this.gunaButton4_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AnimationHoverSpeed = 0.07F;
            this.btnHuy.AnimationSpeed = 0.03F;
            this.btnHuy.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnHuy.BorderColor = System.Drawing.Color.Black;
            this.btnHuy.FocusedColor = System.Drawing.Color.Empty;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHuy.ForeColor = System.Drawing.Color.Black;
            this.btnHuy.Image = global::QL.Properties.Resources.tải_xuống__1_7;
            this.btnHuy.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHuy.Location = new System.Drawing.Point(40, 251);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnHuy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHuy.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHuy.OnHoverImage = null;
            this.btnHuy.OnPressedColor = System.Drawing.Color.Black;
            this.btnHuy.Size = new System.Drawing.Size(142, 35);
            this.btnHuy.TabIndex = 20;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnsua
            // 
            this.btnsua.AnimationHoverSpeed = 0.07F;
            this.btnsua.AnimationSpeed = 0.03F;
            this.btnsua.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnsua.BorderColor = System.Drawing.Color.Black;
            this.btnsua.FocusedColor = System.Drawing.Color.Empty;
            this.btnsua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnsua.ForeColor = System.Drawing.Color.Black;
            this.btnsua.Image = global::QL.Properties.Resources.sua1;
            this.btnsua.ImageSize = new System.Drawing.Size(20, 20);
            this.btnsua.Location = new System.Drawing.Point(40, 185);
            this.btnsua.Name = "btnsua";
            this.btnsua.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnsua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnsua.OnHoverForeColor = System.Drawing.Color.White;
            this.btnsua.OnHoverImage = null;
            this.btnsua.OnPressedColor = System.Drawing.Color.Black;
            this.btnsua.Size = new System.Drawing.Size(142, 38);
            this.btnsua.TabIndex = 17;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnsua.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.Location = new System.Drawing.Point(274, 363);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(177, 21);
            this.gunaLabel8.TabIndex = 97;
            this.gunaLabel8.Text = "Thông tin khách hàng\r\n";
            // 
            // btnthem
            // 
            this.btnthem.Image = global::QL.Properties.Resources.Capture1;
            this.btnthem.Location = new System.Drawing.Point(727, -1);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(218, 103);
            this.btnthem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnthem.TabIndex = 1;
            this.btnthem.TabStop = false;
            // 
            // cboDevice
            // 
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.Location = new System.Drawing.Point(91, 8);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(206, 21);
            this.cboDevice.TabIndex = 100;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(4, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(298, 194);
            this.pictureBox2.TabIndex = 99;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 98;
            this.label1.Text = "Camera";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Turquoise;
            this.btnStart.Location = new System.Drawing.Point(306, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(109, 34);
            this.btnStart.TabIndex = 102;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtQRCode
            // 
            this.txtQRCode.Location = new System.Drawing.Point(306, 44);
            this.txtQRCode.Multiline = true;
            this.txtQRCode.Name = "txtQRCode";
            this.txtQRCode.Size = new System.Drawing.Size(109, 43);
            this.txtQRCode.TabIndex = 103;
            this.txtQRCode.TextChanged += new System.EventHandler(this.txtQRCode_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.txtQRCode);
            this.panel1.Controls.Add(this.cboDevice);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(306, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 261);
            this.panel1.TabIndex = 102;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 104;
            this.label2.Text = "Quét mã QR tìm kiếm thông tin KH";
            // 
            // frmkhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(946, 602);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaGroupBox2);
            this.Controls.Add(this.progressPanel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.btnthem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmkhachhang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form8_FormClosing);
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBCMBDataSet13)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnthem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnthem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI.WinForms.GunaButton btnsua;
        private Guna.UI.WinForms.GunaButton gunaButton4;
        private Guna.UI.WinForms.GunaButton gunaButton6;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
        private System.Windows.Forms.TextBox txttimkiem;
        private QLBCMBDataSet13 qLBCMBDataSet13;
        private System.Windows.Forms.BindingSource khachhangBindingSource;
        private QLBCMBDataSet13TableAdapters.KhachhangTableAdapter khachhangTableAdapter;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaTextBox txtten;
        private Guna.UI.WinForms.GunaTextBox txttuoi;
        private Guna.UI.WinForms.GunaTextBox txtsdt;
        private Guna.UI.WinForms.GunaTextBox txtdiachi;
        private Guna.UI.WinForms.GunaTextBox txtcmnd;
        private Guna.UI.WinForms.GunaTextBox txtemail;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI.WinForms.GunaButton btnLuu;
        private Guna.UI.WinForms.GunaButton btnHuy;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTkhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn đCkhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMNDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cboDevice;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtQRCode;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}