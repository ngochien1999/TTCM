namespace QL
{
    partial class Form16
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RPhoadonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLBCMBDataSet20 = new QL.QLBCMBDataSet20();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RPhoadonTableAdapter = new QL.QLBCMBDataSet20TableAdapters.RPhoadonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RPhoadonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLBCMBDataSet20)).BeginInit();
            this.SuspendLayout();
            // 
            // RPhoadonBindingSource
            // 
            this.RPhoadonBindingSource.DataMember = "RPhoadon";
            this.RPhoadonBindingSource.DataSource = this.QLBCMBDataSet20;
            // 
            // QLBCMBDataSet20
            // 
            this.QLBCMBDataSet20.DataSetName = "QLBCMBDataSet20";
            this.QLBCMBDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.RPhoadonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QL.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 11);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(908, 466);
            this.reportViewer1.TabIndex = 0;
            // 
            // RPhoadonTableAdapter
            // 
            this.RPhoadonTableAdapter.ClearBeforeFill = true;
            // 
            // Form16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 496);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form16";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form16";
            this.Load += new System.EventHandler(this.Form16_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RPhoadonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLBCMBDataSet20)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RPhoadonBindingSource;
        private QLBCMBDataSet20 QLBCMBDataSet20;
        private QLBCMBDataSet20TableAdapters.RPhoadonTableAdapter RPhoadonTableAdapter;
    }
}