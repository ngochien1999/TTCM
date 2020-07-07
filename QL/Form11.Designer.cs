namespace QL
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbMayBay = new Guna.UI.WinForms.GunaComboBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.tbgiobay = new System.Windows.Forms.MaskedTextBox();
            this.dtThoiGiandung = new System.Windows.Forms.MaskedTextBox();
            this.dtngay = new Guna.UI.WinForms.GunaDateTimePicker();
            this.cbTrungGian = new Guna.UI.WinForms.GunaComboBox();
            this.cbden = new Guna.UI.WinForms.GunaComboBox();
            this.cbdi = new Guna.UI.WinForms.GunaComboBox();
            this.txtma = new Guna.UI.WinForms.GunaTextBox();
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.duLieu = new QL.dataset.DuLieu();
            this.sanbayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sanbayTableAdapter = new QL.dataset.DuLieuTableAdapters.SanbayTableAdapter();
            this.sanbayBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sanbayBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.maybayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maybayTableAdapter = new QL.dataset.DuLieuTableAdapters.MaybayTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanbayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanbayBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanbayBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maybayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbMayBay);
            this.panel1.Controls.Add(this.gunaButton1);
            this.panel1.Controls.Add(this.tbgiobay);
            this.panel1.Controls.Add(this.dtThoiGiandung);
            this.panel1.Controls.Add(this.dtngay);
            this.panel1.Controls.Add(this.cbTrungGian);
            this.panel1.Controls.Add(this.cbden);
            this.panel1.Controls.Add(this.cbdi);
            this.panel1.Controls.Add(this.txtma);
            this.panel1.Controls.Add(this.progressPanel1);
            this.panel1.Controls.Add(this.gunaLabel8);
            this.panel1.Controls.Add(this.gunaLabel7);
            this.panel1.Controls.Add(this.gunaLabel6);
            this.panel1.Controls.Add(this.gunaLabel5);
            this.panel1.Controls.Add(this.gunaLabel4);
            this.panel1.Controls.Add(this.gunaLabel3);
            this.panel1.Controls.Add(this.gunaLabel2);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 391);
            this.panel1.TabIndex = 0;
            // 
            // cbMayBay
            // 
            this.cbMayBay.BackColor = System.Drawing.Color.Transparent;
            this.cbMayBay.BaseColor = System.Drawing.Color.White;
            this.cbMayBay.BorderColor = System.Drawing.Color.Silver;
            this.cbMayBay.DataSource = this.maybayBindingSource;
            this.cbMayBay.DisplayMember = "TenMB";
            this.cbMayBay.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMayBay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMayBay.FocusedColor = System.Drawing.Color.Empty;
            this.cbMayBay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMayBay.ForeColor = System.Drawing.Color.Black;
            this.cbMayBay.FormattingEnabled = true;
            this.cbMayBay.Location = new System.Drawing.Point(157, 72);
            this.cbMayBay.Name = "cbMayBay";
            this.cbMayBay.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbMayBay.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbMayBay.Size = new System.Drawing.Size(166, 26);
            this.cbMayBay.TabIndex = 44;
            this.cbMayBay.ValueMember = "MaMB";
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(49, 217);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(141, 40);
            this.gunaButton1.TabIndex = 43;
            this.gunaButton1.Text = "gunaButton1";
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // tbgiobay
            // 
            this.tbgiobay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbgiobay.Location = new System.Drawing.Point(486, 67);
            this.tbgiobay.Mask = "00:00";
            this.tbgiobay.Name = "tbgiobay";
            this.tbgiobay.Size = new System.Drawing.Size(204, 20);
            this.tbgiobay.TabIndex = 42;
            this.tbgiobay.ValidatingType = typeof(System.DateTime);
            // 
            // dtThoiGiandung
            // 
            this.dtThoiGiandung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtThoiGiandung.Location = new System.Drawing.Point(486, 172);
            this.dtThoiGiandung.Mask = "00:00";
            this.dtThoiGiandung.Name = "dtThoiGiandung";
            this.dtThoiGiandung.Size = new System.Drawing.Size(204, 20);
            this.dtThoiGiandung.TabIndex = 41;
            this.dtThoiGiandung.ValidatingType = typeof(System.DateTime);
            // 
            // dtngay
            // 
            this.dtngay.BaseColor = System.Drawing.Color.White;
            this.dtngay.BorderColor = System.Drawing.Color.Silver;
            this.dtngay.CustomFormat = "dd/MM/yyyy";
            this.dtngay.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtngay.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtngay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtngay.ForeColor = System.Drawing.Color.Black;
            this.dtngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtngay.Location = new System.Drawing.Point(486, 22);
            this.dtngay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtngay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtngay.Name = "dtngay";
            this.dtngay.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtngay.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtngay.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtngay.OnPressedColor = System.Drawing.Color.Black;
            this.dtngay.Size = new System.Drawing.Size(204, 20);
            this.dtngay.TabIndex = 24;
            this.dtngay.Text = "07/07/2020";
            this.dtngay.Value = new System.DateTime(2020, 7, 7, 16, 28, 54, 495);
            // 
            // cbTrungGian
            // 
            this.cbTrungGian.BackColor = System.Drawing.Color.Transparent;
            this.cbTrungGian.BaseColor = System.Drawing.Color.White;
            this.cbTrungGian.BorderColor = System.Drawing.Color.Silver;
            this.cbTrungGian.DataSource = this.sanbayBindingSource2;
            this.cbTrungGian.DisplayMember = "TenSb";
            this.cbTrungGian.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTrungGian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrungGian.FocusedColor = System.Drawing.Color.Empty;
            this.cbTrungGian.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTrungGian.ForeColor = System.Drawing.Color.Black;
            this.cbTrungGian.FormattingEnabled = true;
            this.cbTrungGian.Location = new System.Drawing.Point(486, 112);
            this.cbTrungGian.Name = "cbTrungGian";
            this.cbTrungGian.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbTrungGian.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbTrungGian.Size = new System.Drawing.Size(204, 26);
            this.cbTrungGian.TabIndex = 23;
            this.cbTrungGian.ValueMember = "MaSb";
            // 
            // cbden
            // 
            this.cbden.BackColor = System.Drawing.Color.Transparent;
            this.cbden.BaseColor = System.Drawing.Color.White;
            this.cbden.BorderColor = System.Drawing.Color.Silver;
            this.cbden.DataSource = this.sanbayBindingSource1;
            this.cbden.DisplayMember = "TenSb";
            this.cbden.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbden.FocusedColor = System.Drawing.Color.Empty;
            this.cbden.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbden.ForeColor = System.Drawing.Color.Black;
            this.cbden.FormattingEnabled = true;
            this.cbden.Location = new System.Drawing.Point(161, 172);
            this.cbden.Name = "cbden";
            this.cbden.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbden.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbden.Size = new System.Drawing.Size(162, 26);
            this.cbden.TabIndex = 22;
            this.cbden.ValueMember = "MaSb";
            // 
            // cbdi
            // 
            this.cbdi.BackColor = System.Drawing.Color.Transparent;
            this.cbdi.BaseColor = System.Drawing.Color.White;
            this.cbdi.BorderColor = System.Drawing.Color.Silver;
            this.cbdi.DataSource = this.sanbayBindingSource;
            this.cbdi.DisplayMember = "TenSb";
            this.cbdi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdi.FocusedColor = System.Drawing.Color.Blue;
            this.cbdi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbdi.ForeColor = System.Drawing.Color.Black;
            this.cbdi.FormattingEnabled = true;
            this.cbdi.Location = new System.Drawing.Point(161, 122);
            this.cbdi.Name = "cbdi";
            this.cbdi.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbdi.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbdi.Size = new System.Drawing.Size(162, 26);
            this.cbdi.TabIndex = 21;
            this.cbdi.ValueMember = "MaSb";
            // 
            // txtma
            // 
            this.txtma.BaseColor = System.Drawing.Color.White;
            this.txtma.BorderColor = System.Drawing.Color.Silver;
            this.txtma.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtma.FocusedBaseColor = System.Drawing.Color.White;
            this.txtma.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtma.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtma.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtma.Location = new System.Drawing.Point(157, 13);
            this.txtma.Name = "txtma";
            this.txtma.PasswordChar = '\0';
            this.txtma.Size = new System.Drawing.Size(167, 30);
            this.txtma.TabIndex = 19;
            this.txtma.Text = "gunaTextBox1";
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
            this.progressPanel1.Caption = "VietNam AirLine";
            this.progressPanel1.Location = new System.Drawing.Point(10, 345);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(744, 43);
            this.progressPanel1.TabIndex = 18;
            this.progressPanel1.Text = "progressPanel1";
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel8.Location = new System.Drawing.Point(374, 123);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(108, 15);
            this.gunaLabel8.TabIndex = 7;
            this.gunaLabel8.Text = "Sân Bay Trung Gian";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel7.Location = new System.Drawing.Point(384, 172);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(87, 15);
            this.gunaLabel7.TabIndex = 6;
            this.gunaLabel7.Text = "Thời gian dừng";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(384, 72);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(47, 15);
            this.gunaLabel6.TabIndex = 5;
            this.gunaLabel6.Text = "Giờ bay";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(374, 28);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(57, 15);
            this.gunaLabel5.TabIndex = 4;
            this.gunaLabel5.Text = "Ngày bay";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(47, 172);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(72, 15);
            this.gunaLabel4.TabIndex = 3;
            this.gunaLabel4.Text = "Sân bay Đến";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(47, 123);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(62, 15);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "Sân Bay Đi";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(46, 72);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(52, 15);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "May bay";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(46, 28);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(90, 15);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Mã Chuyến Bay";
            // 
            // duLieu
            // 
            this.duLieu.DataSetName = "DuLieu";
            this.duLieu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sanbayBindingSource
            // 
            this.sanbayBindingSource.DataMember = "Sanbay";
            this.sanbayBindingSource.DataSource = this.duLieu;
            // 
            // sanbayTableAdapter
            // 
            this.sanbayTableAdapter.ClearBeforeFill = true;
            // 
            // sanbayBindingSource1
            // 
            this.sanbayBindingSource1.DataMember = "Sanbay";
            this.sanbayBindingSource1.DataSource = this.duLieu;
            // 
            // sanbayBindingSource2
            // 
            this.sanbayBindingSource2.DataMember = "Sanbay";
            this.sanbayBindingSource2.DataSource = this.duLieu;
            // 
            // maybayBindingSource
            // 
            this.maybayBindingSource.DataMember = "Maybay";
            this.maybayBindingSource.DataSource = this.duLieu;
            // 
            // maybayTableAdapter
            // 
            this.maybayTableAdapter.ClearBeforeFill = true;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 410);
            this.Controls.Add(this.panel1);
            this.Name = "Form11";
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanbayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanbayBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanbayBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maybayBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.MaskedTextBox tbgiobay;
        private System.Windows.Forms.MaskedTextBox dtThoiGiandung;
        private Guna.UI.WinForms.GunaDateTimePicker dtngay;
        private Guna.UI.WinForms.GunaComboBox cbTrungGian;
        private Guna.UI.WinForms.GunaComboBox cbden;
        private Guna.UI.WinForms.GunaComboBox cbdi;
        private Guna.UI.WinForms.GunaTextBox txtma;
        private Guna.UI.WinForms.GunaComboBox cbMayBay;
        private dataset.DuLieu duLieu;
        private System.Windows.Forms.BindingSource sanbayBindingSource;
        private dataset.DuLieuTableAdapters.SanbayTableAdapter sanbayTableAdapter;
        private System.Windows.Forms.BindingSource sanbayBindingSource2;
        private System.Windows.Forms.BindingSource sanbayBindingSource1;
        private System.Windows.Forms.BindingSource maybayBindingSource;
        private dataset.DuLieuTableAdapters.MaybayTableAdapter maybayTableAdapter;
    }
}