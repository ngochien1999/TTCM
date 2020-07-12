namespace QL
{
    partial class Form14
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.qLBCMBDataSet17 = new QL.QLBCMBDataSet17();
            this.maybayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maybayTableAdapter = new QL.QLBCMBDataSet17TableAdapters.MaybayTableAdapter();
            this.maMBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gheloai1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gheloai2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBCMBDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maybayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maMBDataGridViewTextBoxColumn,
            this.tenMBDataGridViewTextBoxColumn,
            this.hangDataGridViewTextBoxColumn,
            this.gheloai1DataGridViewTextBoxColumn,
            this.gheloai2DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.maybayBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(149, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(635, 290);
            this.dataGridView1.TabIndex = 0;
            // 
            // qLBCMBDataSet17
            // 
            this.qLBCMBDataSet17.DataSetName = "QLBCMBDataSet17";
            this.qLBCMBDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maybayBindingSource
            // 
            this.maybayBindingSource.DataMember = "Maybay";
            this.maybayBindingSource.DataSource = this.qLBCMBDataSet17;
            // 
            // maybayTableAdapter
            // 
            this.maybayTableAdapter.ClearBeforeFill = true;
            // 
            // maMBDataGridViewTextBoxColumn
            // 
            this.maMBDataGridViewTextBoxColumn.DataPropertyName = "MaMB";
            this.maMBDataGridViewTextBoxColumn.HeaderText = "MaMB";
            this.maMBDataGridViewTextBoxColumn.Name = "maMBDataGridViewTextBoxColumn";
            // 
            // tenMBDataGridViewTextBoxColumn
            // 
            this.tenMBDataGridViewTextBoxColumn.DataPropertyName = "TenMB";
            this.tenMBDataGridViewTextBoxColumn.HeaderText = "TenMB";
            this.tenMBDataGridViewTextBoxColumn.Name = "tenMBDataGridViewTextBoxColumn";
            // 
            // hangDataGridViewTextBoxColumn
            // 
            this.hangDataGridViewTextBoxColumn.DataPropertyName = "Hang";
            this.hangDataGridViewTextBoxColumn.HeaderText = "Hang";
            this.hangDataGridViewTextBoxColumn.Name = "hangDataGridViewTextBoxColumn";
            // 
            // gheloai1DataGridViewTextBoxColumn
            // 
            this.gheloai1DataGridViewTextBoxColumn.DataPropertyName = "Gheloai1";
            this.gheloai1DataGridViewTextBoxColumn.HeaderText = "Gheloai1";
            this.gheloai1DataGridViewTextBoxColumn.Name = "gheloai1DataGridViewTextBoxColumn";
            // 
            // gheloai2DataGridViewTextBoxColumn
            // 
            this.gheloai2DataGridViewTextBoxColumn.DataPropertyName = "Gheloai2";
            this.gheloai2DataGridViewTextBoxColumn.HeaderText = "Gheloai2";
            this.gheloai2DataGridViewTextBoxColumn.Name = "gheloai2DataGridViewTextBoxColumn";
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form14";
            this.Text = "Form14";
            this.Load += new System.EventHandler(this.Form14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBCMBDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maybayBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private QLBCMBDataSet17 qLBCMBDataSet17;
        private System.Windows.Forms.BindingSource maybayBindingSource;
        private QLBCMBDataSet17TableAdapters.MaybayTableAdapter maybayTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gheloai1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gheloai2DataGridViewTextBoxColumn;
    }
}