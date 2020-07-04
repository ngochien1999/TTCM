namespace QL
{
    partial class Form5
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
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.cbden = new Guna.UI.WinForms.GunaComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.dttb = new System.Windows.Forms.DataGridView();
            this.matuyenbayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanbaydiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanbaydenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xemchitiet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.cbdi = new Guna.UI.WinForms.GunaComboBox();
            this.txtma = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dttb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gunaPanel1.Controls.Add(this.cbden);
            this.gunaPanel1.Controls.Add(this.label2);
            this.gunaPanel1.Controls.Add(this.pictureBox1);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Controls.Add(this.gunaButton3);
            this.gunaPanel1.Controls.Add(this.dttb);
            this.gunaPanel1.Controls.Add(this.gunaButton2);
            this.gunaPanel1.Controls.Add(this.gunaButton1);
            this.gunaPanel1.Controls.Add(this.cbdi);
            this.gunaPanel1.Controls.Add(this.txtma);
            this.gunaPanel1.Controls.Add(this.gunaLabel4);
            this.gunaPanel1.Controls.Add(this.gunaLabel3);
            this.gunaPanel1.Controls.Add(this.gunaLabel2);
            this.gunaPanel1.Location = new System.Drawing.Point(3, 1);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(580, 493);
            this.gunaPanel1.TabIndex = 0;
            // 
            // cbden
            // 
            this.cbden.BackColor = System.Drawing.Color.Transparent;
            this.cbden.BaseColor = System.Drawing.Color.White;
            this.cbden.BorderColor = System.Drawing.Color.Silver;
            this.cbden.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbden.FocusedColor = System.Drawing.Color.Empty;
            this.cbden.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbden.ForeColor = System.Drawing.Color.Black;
            this.cbden.FormattingEnabled = true;
            this.cbden.Items.AddRange(new object[] {
            "Hà Nội",
            "Buôn Ma Thuột",
            "Đà Nẵng",
            "Vân Đồn",
            "Quy Nhơn"});
            this.cbden.Location = new System.Drawing.Point(141, 231);
            this.cbden.Name = "cbden";
            this.cbden.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbden.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbden.Size = new System.Drawing.Size(257, 26);
            this.cbden.TabIndex = 25;
            this.cbden.SelectedIndexChanged += new System.EventHandler(this.cbden_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Chức năng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QL.Properties.Resources.Airline_strike__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gunaLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(276, 29);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(123, 21);
            this.gunaLabel1.TabIndex = 8;
            this.gunaLabel1.Text = "CHUYẾN BAY";
            // 
            // gunaButton3
            // 
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gunaButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton3.ForeColor = System.Drawing.Color.White;
            this.gunaButton3.Image = global::QL.Properties.Resources.tải_xuống2;
            this.gunaButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton3.Location = new System.Drawing.Point(443, 227);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Size = new System.Drawing.Size(125, 31);
            this.gunaButton3.TabIndex = 24;
            this.gunaButton3.Text = "Sửa";
            this.gunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dttb
            // 
            this.dttb.AutoGenerateColumns = false;
            this.dttb.BackgroundColor = System.Drawing.Color.White;
            this.dttb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dttb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matuyenbayDataGridViewTextBoxColumn,
            this.sanbaydiDataGridViewTextBoxColumn,
            this.sanbaydenDataGridViewTextBoxColumn,
            this.Xemchitiet});
            this.dttb.DataSource = this.customerBindingSource;
            this.dttb.Location = new System.Drawing.Point(24, 280);
            this.dttb.Name = "dttb";
            this.dttb.Size = new System.Drawing.Size(523, 157);
            this.dttb.TabIndex = 7;
            this.dttb.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dttb_CellClick);
            this.dttb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dttb_CellContentClick_1);
            // 
            // matuyenbayDataGridViewTextBoxColumn
            // 
            this.matuyenbayDataGridViewTextBoxColumn.DataPropertyName = "Matuyenbay";
            this.matuyenbayDataGridViewTextBoxColumn.HeaderText = "Matuyenbay";
            this.matuyenbayDataGridViewTextBoxColumn.Name = "matuyenbayDataGridViewTextBoxColumn";
            this.matuyenbayDataGridViewTextBoxColumn.Width = 120;
            // 
            // sanbaydiDataGridViewTextBoxColumn
            // 
            this.sanbaydiDataGridViewTextBoxColumn.DataPropertyName = "Sanbaydi";
            this.sanbaydiDataGridViewTextBoxColumn.HeaderText = "Sanbaydi";
            this.sanbaydiDataGridViewTextBoxColumn.Name = "sanbaydiDataGridViewTextBoxColumn";
            this.sanbaydiDataGridViewTextBoxColumn.Width = 120;
            // 
            // sanbaydenDataGridViewTextBoxColumn
            // 
            this.sanbaydenDataGridViewTextBoxColumn.DataPropertyName = "Sanbayden";
            this.sanbaydenDataGridViewTextBoxColumn.HeaderText = "Sanbayden";
            this.sanbaydenDataGridViewTextBoxColumn.Name = "sanbaydenDataGridViewTextBoxColumn";
            this.sanbaydenDataGridViewTextBoxColumn.Width = 120;
            // 
            // Xemchitiet
            // 
            this.Xemchitiet.HeaderText = "Xemchitiet";
            this.Xemchitiet.Name = "Xemchitiet";
            this.Xemchitiet.Text = "Xem chi tiết";
            this.Xemchitiet.UseColumnTextForButtonValue = true;
            this.Xemchitiet.Width = 120;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(QL.Customer);
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = global::QL.Properties.Resources.tải_xuống__1_2;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(443, 179);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(125, 31);
            this.gunaButton2.TabIndex = 23;
            this.gunaButton2.Text = "Xóa";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = global::QL.Properties.Resources.tải_xuống1;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(443, 132);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(125, 31);
            this.gunaButton1.TabIndex = 22;
            this.gunaButton1.Text = "Thêm";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // cbdi
            // 
            this.cbdi.BackColor = System.Drawing.Color.Transparent;
            this.cbdi.BaseColor = System.Drawing.Color.White;
            this.cbdi.BorderColor = System.Drawing.Color.Silver;
            this.cbdi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdi.FocusedColor = System.Drawing.Color.Empty;
            this.cbdi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbdi.ForeColor = System.Drawing.Color.Black;
            this.cbdi.FormattingEnabled = true;
            this.cbdi.Items.AddRange(new object[] {
            "Hà Nội",
            "Buôn Ma Thuột",
            "Đà Nẵng",
            "Vân Đồn",
            "Quy Nhơn"});
            this.cbdi.Location = new System.Drawing.Point(141, 184);
            this.cbdi.Name = "cbdi";
            this.cbdi.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbdi.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbdi.Size = new System.Drawing.Size(258, 26);
            this.cbdi.TabIndex = 5;
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
            this.txtma.Location = new System.Drawing.Point(141, 131);
            this.txtma.Name = "txtma";
            this.txtma.PasswordChar = '\0';
            this.txtma.Size = new System.Drawing.Size(259, 32);
            this.txtma.TabIndex = 4;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(21, 243);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(72, 15);
            this.gunaLabel4.TabIndex = 3;
            this.gunaLabel4.Text = "Sân Bay Đến";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(21, 195);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(62, 15);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "Sân Bay Đi";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(21, 150);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(81, 15);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Mã Tuyến Bay";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.gunaPanel1);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dttb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaComboBox cbdi;
        private Guna.UI.WinForms.GunaTextBox txtma;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.DataGridView dttb;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn matuyenbayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanbaydiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanbaydenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Xemchitiet;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaComboBox cbden;
    }
}