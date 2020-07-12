namespace QL
{
    partial class Form18
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QLBCMBDataSet10 = new QL.QLBCMBDataSet10();
            this.MaybayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MaybayTableAdapter = new QL.QLBCMBDataSet10TableAdapters.MaybayTableAdapter();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.QLBCMBDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaybayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MaybayBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QL.RPHoaDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 218);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(754, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLBCMBDataSet10
            // 
            this.QLBCMBDataSet10.DataSetName = "QLBCMBDataSet10";
            this.QLBCMBDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MaybayBindingSource
            // 
            this.MaybayBindingSource.DataMember = "Maybay";
            this.MaybayBindingSource.DataSource = this.QLBCMBDataSet10;
            // 
            // MaybayTableAdapter
            // 
            this.MaybayTableAdapter.ClearBeforeFill = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(154, 22);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "VND";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(511, 190);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // Form18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form18";
            this.Text = "Form18";
            this.Load += new System.EventHandler(this.Form18_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLBCMBDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaybayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MaybayBindingSource;
        private QLBCMBDataSet10 QLBCMBDataSet10;
        private QLBCMBDataSet10TableAdapters.MaybayTableAdapter MaybayTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}