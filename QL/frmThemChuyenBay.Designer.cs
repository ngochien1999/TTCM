namespace QL
{
    partial class frmThemChuyenBay
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
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.duLieu = new QL.dataset.DuLieu();
            this.maybayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maybayTableAdapter = new QL.dataset.DuLieuTableAdapters.MaybayTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.duLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maybayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaComboBox1
            // 
            this.gunaComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox1.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox1.FormattingEnabled = true;
            this.gunaComboBox1.Location = new System.Drawing.Point(109, 91);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Size = new System.Drawing.Size(121, 26);
            this.gunaComboBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.maybayBindingSource;
            this.comboBox1.DisplayMember = "TenMB";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(490, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "MaMB";
            // 
            // duLieu
            // 
            this.duLieu.DataSetName = "DuLieu";
            this.duLieu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // frmThemChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.gunaComboBox1);
            this.Name = "frmThemChuyenBay";
            this.Text = "frmThemChuyenBay";
            this.Load += new System.EventHandler(this.frmThemChuyenBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.duLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maybayBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private dataset.DuLieu duLieu;
        private System.Windows.Forms.BindingSource maybayBindingSource;
        private dataset.DuLieuTableAdapters.MaybayTableAdapter maybayTableAdapter;
    }
}