namespace QL
{
    partial class frmtop3
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.banchayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet4 = new QL.DataSet4();
            this.banchayTableAdapter = new QL.DataSet4TableAdapters.banchayTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.banchayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // banchayBindingSource
            // 
            this.banchayBindingSource.DataMember = "banchay";
            this.banchayBindingSource.DataSource = this.DataSet4;
            // 
            // DataSet4
            // 
            this.DataSet4.DataSetName = "DataSet4";
            this.DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // banchayTableAdapter
            // 
            this.banchayTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.banchayBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QL.Report6.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(6, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(776, 397);
            this.reportViewer1.TabIndex = 0;
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Aqua;
            this.gunaButton2.BaseColor = System.Drawing.Color.LightSeaGreen;
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = global::QL.Properties.Resources.exit2;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(740, 3);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(42, 46);
            this.gunaButton2.TabIndex = 2;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // frmtop3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 401);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmtop3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmtop3";
            this.Load += new System.EventHandler(this.frmtop3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banchayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource banchayBindingSource;
        private DataSet4 DataSet4;
        private DataSet4TableAdapters.banchayTableAdapter banchayTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
    }
}