namespace QL
{
    partial class Form20
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rptChuyenBayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Datareport = new QL.Datareport();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rptChuyenBayTableAdapter = new QL.DatareportTableAdapters.rptChuyenBayTableAdapter();
            this.SettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rptChuyenBayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datareport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptChuyenBayBindingSource
            // 
            this.rptChuyenBayBindingSource.DataMember = "rptChuyenBay";
            this.rptChuyenBayBindingSource.DataSource = this.Datareport;
            // 
            // Datareport
            // 
            this.Datareport.DataSetName = "Datareport";
            this.Datareport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.SettingsBindingSource;
            reportDataSource4.Name = "DataSet2";
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QL.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(968, 509);
            this.reportViewer1.TabIndex = 0;
            // 
            // rptChuyenBayTableAdapter
            // 
            this.rptChuyenBayTableAdapter.ClearBeforeFill = true;
            // 
            // SettingsBindingSource
            // 
            this.SettingsBindingSource.DataSource = typeof(QL.Properties.Settings);
            // 
            // Form20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 509);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form20";
            this.Text = "Form20";
            this.Load += new System.EventHandler(this.Form20_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rptChuyenBayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datareport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rptChuyenBayBindingSource;
        private Datareport Datareport;
        private DatareportTableAdapters.rptChuyenBayTableAdapter rptChuyenBayTableAdapter;
        private System.Windows.Forms.BindingSource SettingsBindingSource;
    }
}