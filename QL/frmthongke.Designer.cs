namespace QL
{
    partial class frmthongke
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem1 = new DevExpress.XtraEditors.TileItem();
            this.tileItem2 = new DevExpress.XtraEditors.TileItem();
            this.tileItem3 = new DevExpress.XtraEditors.TileItem();
            this.tileItem4 = new DevExpress.XtraEditors.TileItem();
            this.SuspendLayout();
            // 
            // tileControl1
            // 
            this.tileControl1.BackgroundImage = global::QL.Properties.Resources._1;
            this.tileControl1.Groups.Add(this.tileGroup2);
            this.tileControl1.Location = new System.Drawing.Point(0, 2);
            this.tileControl1.MaxId = 8;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(874, 473);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "Lựa chọn thống kê";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tileItem1);
            this.tileGroup2.Items.Add(this.tileItem2);
            this.tileGroup2.Items.Add(this.tileItem3);
            this.tileGroup2.Items.Add(this.tileItem4);
            this.tileGroup2.Name = "tileGroup2";
            this.tileGroup2.Text = "Xuất EXCEL hóa đơn";
            // 
            // tileItem1
            // 
            tileItemElement1.ImageOptions.Image = global::QL.Properties.Resources.Airline_strike;
            tileItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileItemElement1.Text = "Tổng doanh thu";
            this.tileItem1.Elements.Add(tileItemElement1);
            this.tileItem1.Id = 3;
            this.tileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Large;
            this.tileItem1.Name = "tileItem1";
            this.tileItem1.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem1_ItemClick);
            // 
            // tileItem2
            // 
            tileItemElement2.ImageOptions.Image = global::QL.Properties.Resources.maybay10;
            tileItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileItemElement2.Text = "Doanh thu theo tháng";
            this.tileItem2.Elements.Add(tileItemElement2);
            this.tileItem2.Id = 4;
            this.tileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem2.Name = "tileItem2";
            this.tileItem2.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem2_ItemClick);
            // 
            // tileItem3
            // 
            tileItemElement3.ImageOptions.Image = global::QL.Properties.Resources.maybay6;
            tileItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside;
            tileItemElement3.Text = "Top 3 chuyến bay được đi nhiều nhất";
            this.tileItem3.Elements.Add(tileItemElement3);
            this.tileItem3.Id = 5;
            this.tileItem3.ItemSize = DevExpress.XtraEditors.TileItemSize.Large;
            this.tileItem3.Name = "tileItem3";
            this.tileItem3.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem3_ItemClick);
            // 
            // tileItem4
            // 
            tileItemElement4.ImageOptions.Image = global::QL.Properties.Resources.Capture7;
            tileItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement4.Text = "Doanh thu theo năm";
            this.tileItem4.Elements.Add(tileItemElement4);
            this.tileItem4.Id = 6;
            this.tileItem4.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem4.Name = "tileItem4";
            this.tileItem4.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem4_ItemClick);
            // 
            // Form18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 487);
            this.Controls.Add(this.tileControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form18";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form18";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tileItem1;
        private DevExpress.XtraEditors.TileItem tileItem2;
        private DevExpress.XtraEditors.TileItem tileItem3;
        private DevExpress.XtraEditors.TileItem tileItem4;
    }
}