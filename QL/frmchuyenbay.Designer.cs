﻿namespace QL
{
    partial class frmchuyenbay
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
            this.thongTinChuyenBayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.duLieu = new QL.dataset.DuLieu();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.chuyenbayTableAdapter = new QL.dataset.DuLieuTableAdapters.ChuyenbayTableAdapter();
            this.thongTinChuyenBayTableAdapter = new QL.dataset.DuLieuTableAdapters.ThongTinChuyenBayTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse4 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbchao = new System.Windows.Forms.Label();
            this.btnsua = new Guna.UI.WinForms.GunaButton();
            this.btnluu = new Guna.UI.WinForms.GunaButton();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.btnhuy = new Guna.UI.WinForms.GunaButton();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.btnthen = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.txtsanbayden = new Guna.UI.WinForms.GunaTextBox();
            this.txtsoluongii = new Guna.UI.WinForms.GunaTextBox();
            this.txtdiachi = new Guna.UI.WinForms.GunaTextBox();
            this.txtsbd = new Guna.UI.WinForms.GunaTextBox();
            this.txtthoigianbay = new Guna.UI.WinForms.GunaTextBox();
            this.txtngaybay = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinChuyenBayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // thongTinChuyenBayBindingSource
            // 
            this.thongTinChuyenBayBindingSource.DataMember = "ThongTinChuyenBay";
            this.thongTinChuyenBayBindingSource.DataSource = this.duLieu;
            // 
            // duLieu
            // 
            this.duLieu.DataSetName = "DuLieu";
            this.duLieu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(946, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 602);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(946, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 602);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(946, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 602);
            // 
            // chuyenbayTableAdapter
            // 
            this.chuyenbayTableAdapter.ClearBeforeFill = true;
            // 
            // thongTinChuyenBayTableAdapter
            // 
            this.thongTinChuyenBayTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 10;
            this.gunaElipse2.TargetControl = this;
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.Radius = 10;
            this.gunaElipse3.TargetControl = this;
            // 
            // gunaElipse4
            // 
            this.gunaElipse4.TargetControl = this;
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
            this.progressPanel1.Location = new System.Drawing.Point(3, 556);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(940, 43);
            this.progressPanel1.TabIndex = 18;
            this.progressPanel1.Text = "progressPanel1";
            this.progressPanel1.Click += new System.EventHandler(this.progressPanel1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QL.Properties.Resources.Capture1;
            this.pictureBox1.Location = new System.Drawing.Point(753, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // lbchao
            // 
            this.lbchao.AutoSize = true;
            this.lbchao.BackColor = System.Drawing.Color.Khaki;
            this.lbchao.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbchao.ForeColor = System.Drawing.Color.White;
            this.lbchao.Location = new System.Drawing.Point(60, 36);
            this.lbchao.Name = "lbchao";
            this.lbchao.Size = new System.Drawing.Size(133, 22);
            this.lbchao.TabIndex = 33;
            this.lbchao.Text = "CHUYẾN BAY";
            // 
            // btnsua
            // 
            this.btnsua.AnimationHoverSpeed = 0.07F;
            this.btnsua.AnimationSpeed = 0.03F;
            this.btnsua.BaseColor = System.Drawing.Color.SandyBrown;
            this.btnsua.BorderColor = System.Drawing.Color.Black;
            this.btnsua.FocusedColor = System.Drawing.Color.Empty;
            this.btnsua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnsua.ForeColor = System.Drawing.Color.Black;
            this.btnsua.Image = global::QL.Properties.Resources.pngtree_cancel_vector_icon_png_image_37254282;
            this.btnsua.ImageSize = new System.Drawing.Size(20, 20);
            this.btnsua.Location = new System.Drawing.Point(32, 134);
            this.btnsua.Name = "btnsua";
            this.btnsua.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnsua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnsua.OnHoverForeColor = System.Drawing.Color.White;
            this.btnsua.OnHoverImage = null;
            this.btnsua.OnPressedColor = System.Drawing.Color.Black;
            this.btnsua.Size = new System.Drawing.Size(125, 37);
            this.btnsua.TabIndex = 34;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnluu
            // 
            this.btnluu.AnimationHoverSpeed = 0.07F;
            this.btnluu.AnimationSpeed = 0.03F;
            this.btnluu.BaseColor = System.Drawing.Color.SandyBrown;
            this.btnluu.BorderColor = System.Drawing.Color.Black;
            this.btnluu.FocusedColor = System.Drawing.Color.Empty;
            this.btnluu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnluu.ForeColor = System.Drawing.Color.Black;
            this.btnluu.Image = global::QL.Properties.Resources.tải_xuống__1_6;
            this.btnluu.ImageSize = new System.Drawing.Size(20, 20);
            this.btnluu.Location = new System.Drawing.Point(32, 219);
            this.btnluu.Name = "btnluu";
            this.btnluu.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnluu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnluu.OnHoverForeColor = System.Drawing.Color.White;
            this.btnluu.OnHoverImage = null;
            this.btnluu.OnPressedColor = System.Drawing.Color.Black;
            this.btnluu.Size = new System.Drawing.Size(125, 37);
            this.btnluu.TabIndex = 33;
            this.btnluu.Text = "Lưu";
            this.btnluu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // gunaButton4
            // 
            this.gunaButton4.AnimationHoverSpeed = 0.07F;
            this.gunaButton4.AnimationSpeed = 0.03F;
            this.gunaButton4.BaseColor = System.Drawing.Color.SandyBrown;
            this.gunaButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton4.ForeColor = System.Drawing.Color.Black;
            this.gunaButton4.Image = global::QL.Properties.Resources.Timkiem;
            this.gunaButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton4.Location = new System.Drawing.Point(32, 371);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.BlanchedAlmond;
            this.gunaButton4.Size = new System.Drawing.Size(125, 32);
            this.gunaButton4.TabIndex = 32;
            this.gunaButton4.Text = "Tìm kiếm";
            this.gunaButton4.Click += new System.EventHandler(this.gunaButton4_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.AnimationHoverSpeed = 0.07F;
            this.btnhuy.AnimationSpeed = 0.03F;
            this.btnhuy.BaseColor = System.Drawing.Color.SandyBrown;
            this.btnhuy.BorderColor = System.Drawing.Color.Black;
            this.btnhuy.FocusedColor = System.Drawing.Color.Empty;
            this.btnhuy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnhuy.ForeColor = System.Drawing.Color.Black;
            this.btnhuy.Image = global::QL.Properties.Resources.Xóa;
            this.btnhuy.ImageSize = new System.Drawing.Size(20, 20);
            this.btnhuy.Location = new System.Drawing.Point(32, 300);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnhuy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnhuy.OnHoverForeColor = System.Drawing.Color.White;
            this.btnhuy.OnHoverImage = null;
            this.btnhuy.OnPressedColor = System.Drawing.Color.Black;
            this.btnhuy.Size = new System.Drawing.Size(125, 37);
            this.btnhuy.TabIndex = 30;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnhuy.Click += new System.EventHandler(this.gunaButton1_Click_2);
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.Location = new System.Drawing.Point(3, 420);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Size = new System.Drawing.Size(174, 26);
            this.gunaTextBox1.TabIndex = 5;
            // 
            // btnthen
            // 
            this.btnthen.AnimationHoverSpeed = 0.07F;
            this.btnthen.AnimationSpeed = 0.03F;
            this.btnthen.BaseColor = System.Drawing.Color.SandyBrown;
            this.btnthen.BorderColor = System.Drawing.Color.Black;
            this.btnthen.FocusedColor = System.Drawing.Color.Empty;
            this.btnthen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnthen.ForeColor = System.Drawing.Color.Black;
            this.btnthen.Image = global::QL.Properties.Resources.them;
            this.btnthen.ImageSize = new System.Drawing.Size(20, 20);
            this.btnthen.Location = new System.Drawing.Point(32, 53);
            this.btnthen.Name = "btnthen";
            this.btnthen.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnthen.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnthen.OnHoverForeColor = System.Drawing.Color.White;
            this.btnthen.OnHoverImage = null;
            this.btnthen.OnPressedColor = System.Drawing.Color.Black;
            this.btnthen.Size = new System.Drawing.Size(125, 38);
            this.btnthen.TabIndex = 2;
            this.btnthen.Text = "Thêm";
            this.btnthen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnthen.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.SkyBlue;
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Controls.Add(this.gunaGroupBox2);
            this.gunaPanel1.Controls.Add(this.groupBox2);
            this.gunaPanel1.Controls.Add(this.gunaPanel2);
            this.gunaPanel1.Controls.Add(this.dataGridView1);
            this.gunaPanel1.Controls.Add(this.pictureBox1);
            this.gunaPanel1.Controls.Add(this.progressPanel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(946, 602);
            this.gunaPanel1.TabIndex = 0;
            this.gunaPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel1_Paint);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(306, 311);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(153, 21);
            this.gunaLabel1.TabIndex = 96;
            this.gunaLabel1.Text = "Thông tin máy bay";
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.btnluu);
            this.gunaGroupBox2.Controls.Add(this.btnhuy);
            this.gunaGroupBox2.Controls.Add(this.gunaTextBox1);
            this.gunaGroupBox2.Controls.Add(this.btnthen);
            this.gunaGroupBox2.Controls.Add(this.gunaButton4);
            this.gunaGroupBox2.Controls.Add(this.btnsua);
            this.gunaGroupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox2.Location = new System.Drawing.Point(760, 101);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Size = new System.Drawing.Size(184, 449);
            this.gunaGroupBox2.TabIndex = 93;
            this.gunaGroupBox2.Text = "Chức năng";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox2.Controls.Add(this.gunaLabel8);
            this.groupBox2.Controls.Add(this.txtsanbayden);
            this.groupBox2.Controls.Add(this.txtsoluongii);
            this.groupBox2.Controls.Add(this.txtdiachi);
            this.groupBox2.Controls.Add(this.txtsbd);
            this.groupBox2.Controls.Add(this.txtthoigianbay);
            this.groupBox2.Controls.Add(this.txtngaybay);
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
            this.groupBox2.Size = new System.Drawing.Size(759, 187);
            this.groupBox2.TabIndex = 91;
            this.groupBox2.TabStop = false;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel8.Location = new System.Drawing.Point(398, 156);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(100, 15);
            this.gunaLabel8.TabIndex = 28;
            this.gunaLabel8.Text = "Số lượng vé loại II";
            // 
            // txtsanbayden
            // 
            this.txtsanbayden.BaseColor = System.Drawing.Color.White;
            this.txtsanbayden.BorderColor = System.Drawing.Color.Silver;
            this.txtsanbayden.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsanbayden.FocusedBaseColor = System.Drawing.Color.White;
            this.txtsanbayden.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtsanbayden.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtsanbayden.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtsanbayden.Location = new System.Drawing.Point(510, 30);
            this.txtsanbayden.Name = "txtsanbayden";
            this.txtsanbayden.PasswordChar = '\0';
            this.txtsanbayden.Size = new System.Drawing.Size(196, 26);
            this.txtsanbayden.TabIndex = 27;
            // 
            // txtsoluongii
            // 
            this.txtsoluongii.BaseColor = System.Drawing.Color.White;
            this.txtsoluongii.BorderColor = System.Drawing.Color.Silver;
            this.txtsoluongii.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsoluongii.FocusedBaseColor = System.Drawing.Color.White;
            this.txtsoluongii.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtsoluongii.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtsoluongii.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtsoluongii.Location = new System.Drawing.Point(510, 147);
            this.txtsoluongii.Name = "txtsoluongii";
            this.txtsoluongii.PasswordChar = '\0';
            this.txtsoluongii.Size = new System.Drawing.Size(196, 26);
            this.txtsoluongii.TabIndex = 22;
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
            this.txtdiachi.Location = new System.Drawing.Point(510, 87);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.PasswordChar = '\0';
            this.txtdiachi.Size = new System.Drawing.Size(196, 26);
            this.txtdiachi.TabIndex = 21;
            // 
            // txtsbd
            // 
            this.txtsbd.BaseColor = System.Drawing.Color.White;
            this.txtsbd.BorderColor = System.Drawing.Color.Silver;
            this.txtsbd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsbd.FocusedBaseColor = System.Drawing.Color.White;
            this.txtsbd.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtsbd.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtsbd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtsbd.Location = new System.Drawing.Point(137, 147);
            this.txtsbd.Name = "txtsbd";
            this.txtsbd.PasswordChar = '\0';
            this.txtsbd.Size = new System.Drawing.Size(196, 26);
            this.txtsbd.TabIndex = 20;
            // 
            // txtthoigianbay
            // 
            this.txtthoigianbay.BaseColor = System.Drawing.Color.White;
            this.txtthoigianbay.BorderColor = System.Drawing.Color.Silver;
            this.txtthoigianbay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtthoigianbay.FocusedBaseColor = System.Drawing.Color.White;
            this.txtthoigianbay.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtthoigianbay.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtthoigianbay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtthoigianbay.Location = new System.Drawing.Point(137, 87);
            this.txtthoigianbay.Name = "txtthoigianbay";
            this.txtthoigianbay.PasswordChar = '\0';
            this.txtthoigianbay.Size = new System.Drawing.Size(196, 26);
            this.txtthoigianbay.TabIndex = 19;
            // 
            // txtngaybay
            // 
            this.txtngaybay.BaseColor = System.Drawing.Color.White;
            this.txtngaybay.BorderColor = System.Drawing.Color.Silver;
            this.txtngaybay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtngaybay.FocusedBaseColor = System.Drawing.Color.White;
            this.txtngaybay.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtngaybay.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtngaybay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtngaybay.Location = new System.Drawing.Point(137, 26);
            this.txtngaybay.Name = "txtngaybay";
            this.txtngaybay.PasswordChar = '\0';
            this.txtngaybay.Size = new System.Drawing.Size(196, 26);
            this.txtngaybay.TabIndex = 18;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel7.Location = new System.Drawing.Point(383, 121);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(0, 15);
            this.gunaLabel7.TabIndex = 17;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(398, 98);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(97, 15);
            this.gunaLabel6.TabIndex = 16;
            this.gunaLabel6.Text = "Số lượng vé loại I";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(407, 30);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(71, 15);
            this.gunaLabel5.TabIndex = 15;
            this.gunaLabel5.Text = "Sân bay đến";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(28, 156);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(61, 15);
            this.gunaLabel4.TabIndex = 14;
            this.gunaLabel4.Text = "Sân bay đi";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(28, 98);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(78, 15);
            this.gunaLabel3.TabIndex = 13;
            this.gunaLabel3.Text = "Thời gian bay";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(28, 30);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(57, 15);
            this.gunaLabel2.TabIndex = 12;
            this.gunaLabel2.Text = "Ngày bay";
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gunaPanel2.Controls.Add(this.labelControl4);
            this.gunaPanel2.Controls.Add(this.labelControl5);
            this.gunaPanel2.Controls.Add(this.labelControl6);
            this.gunaPanel2.Controls.Add(this.lbchao);
            this.gunaPanel2.Controls.Add(this.pictureBox2);
            this.gunaPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(759, 102);
            this.gunaPanel2.TabIndex = 90;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseBackColor = true;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(583, 72);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(145, 13);
            this.labelControl4.TabIndex = 92;
            this.labelControl4.Text = "-----------------------------";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl5.Appearance.Options.UseBackColor = true;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(642, 42);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(55, 13);
            this.labelControl5.TabIndex = 91;
            this.labelControl5.Text = "*Admin *";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseBackColor = true;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(583, 12);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(89, 13);
            this.labelControl6.TabIndex = 90;
            this.labelControl6.Text = "Quyền Sử Dụng:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = global::QL.Properties.Resources.kh2;
            this.pictureBox2.Image = global::QL.Properties.Resources._1;
            this.pictureBox2.Location = new System.Drawing.Point(289, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(170, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(0, 335);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(759, 217);
            this.dataGridView1.TabIndex = 89;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaCB";
            this.Column1.HeaderText = "Mã CB";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Ngaybay";
            this.Column2.HeaderText = "Ngày bay";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Thoigianbay";
            this.Column3.HeaderText = "Thời gian bay";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Sabden";
            this.Column4.HeaderText = "Sân bay đến";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Sabdi";
            this.Column5.HeaderText = "Sân bay đi";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SLveLoaiI";
            this.Column6.HeaderText = "Số lượng vé loại I";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "SLveloaiII";
            this.Column7.HeaderText = "Số lượng vé loại II";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Thoigiandung";
            this.Column8.HeaderText = "Thời gian dừng";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "SBtrunggian";
            this.Column9.HeaderText = "Sân bay trung gian";
            this.Column9.Name = "Column9";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 602);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thongTinChuyenBayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaGroupBox2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private dataset.DuLieu duLieu;
        private dataset.DuLieuTableAdapters.ChuyenbayTableAdapter chuyenbayTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSbDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource thongTinChuyenBayBindingSource;
        private dataset.DuLieuTableAdapters.ThongTinChuyenBayTableAdapter thongTinChuyenBayTableAdapter;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
        private Guna.UI.WinForms.GunaElipse gunaElipse4;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton gunaButton4;
        private Guna.UI.WinForms.GunaButton btnhuy;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private Guna.UI.WinForms.GunaButton btnthen;
        private System.Windows.Forms.Label lbchao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private Guna.UI.WinForms.GunaButton btnluu;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI.WinForms.GunaTextBox txtsoluongii;
        private Guna.UI.WinForms.GunaTextBox txtdiachi;
        private Guna.UI.WinForms.GunaTextBox txtsbd;
        private Guna.UI.WinForms.GunaTextBox txtthoigianbay;
        private Guna.UI.WinForms.GunaTextBox txtngaybay;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtsanbayden;
        private Guna.UI.WinForms.GunaButton btnsua;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
    }
}