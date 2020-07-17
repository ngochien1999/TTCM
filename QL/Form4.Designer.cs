namespace QL
{
    partial class Form4
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QLBCMBDataSet19 = new QL.QLBCMBDataSet19();
            this.NhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NhanvienTableAdapter = new QL.QLBCMBDataSet19TableAdapters.NhanvienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLBCMBDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanvienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.NhanvienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QL.Nhanvien.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(719, 532);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLBCMBDataSet19
            // 
            this.QLBCMBDataSet19.DataSetName = "QLBCMBDataSet19";
            this.QLBCMBDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NhanvienBindingSource
            // 
            this.NhanvienBindingSource.DataMember = "Nhanvien";
            this.NhanvienBindingSource.DataSource = this.QLBCMBDataSet19;
            // 
            // NhanvienTableAdapter
            // 
            this.NhanvienTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 545);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLBCMBDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanvienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource NhanvienBindingSource;
        private QLBCMBDataSet19 QLBCMBDataSet19;
        private QLBCMBDataSet19TableAdapters.NhanvienTableAdapter NhanvienTableAdapter;
    }
}