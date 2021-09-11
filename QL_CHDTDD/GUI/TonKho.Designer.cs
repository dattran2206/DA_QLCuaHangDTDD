namespace GUI
{
    partial class TonKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TonKho));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trvtimkiem = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.luutimkiem = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.luetimkiem = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAMH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DACDIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbREf = new System.Windows.Forms.ToolStripButton();
            this.gridTonkho = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SLNHAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SLBAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SLCON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridLoaiMH = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luutimkiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luetimkiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTonkho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoaiMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 48);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xem kho hàng";
            // 
            // trvtimkiem
            // 
            this.trvtimkiem.BackColor = System.Drawing.Color.White;
            this.trvtimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvtimkiem.ImageIndex = 0;
            this.trvtimkiem.ImageList = this.imageList1;
            this.trvtimkiem.Location = new System.Drawing.Point(0, 88);
            this.trvtimkiem.Name = "trvtimkiem";
            this.trvtimkiem.SelectedImageIndex = 0;
            this.trvtimkiem.Size = new System.Drawing.Size(207, 382);
            this.trvtimkiem.TabIndex = 4;
            this.trvtimkiem.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvtimkiem_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "color-circle.png");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 43);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhóm mặt hàng";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.luetimkiem);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(208, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(592, 38);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.luutimkiem);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(592, 38);
            this.panel4.TabIndex = 3;
            // 
            // luutimkiem
            // 
            this.luutimkiem.Location = new System.Drawing.Point(74, 9);
            this.luutimkiem.Name = "luutimkiem";
            this.luutimkiem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.luutimkiem.Properties.DisplayMember = "MAMH";
            this.luutimkiem.Properties.NullText = "Chọn mã mặt hàng";
            this.luutimkiem.Properties.PopupView = this.gridView1;
            this.luutimkiem.Properties.ShowClearButton = false;
            this.luutimkiem.Properties.ValueMember = "MAMH";
            this.luutimkiem.Size = new System.Drawing.Size(192, 20);
            this.luutimkiem.TabIndex = 2;
            this.luutimkiem.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.luutimkiem_ButtonClick);
            this.luutimkiem.EditValueChanged += new System.EventHandler(this.luutimkiem_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã MH";
            this.gridColumn1.FieldName = "MAMH";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên MH";
            this.gridColumn2.FieldName = "TENMH";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Hình";
            this.gridColumn3.FieldName = "HINH";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Đặc điểm";
            this.gridColumn4.FieldName = "DACDIEM";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tìm:";
            // 
            // luetimkiem
            // 
            this.luetimkiem.Location = new System.Drawing.Point(74, 9);
            this.luetimkiem.Name = "luetimkiem";
            this.luetimkiem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.luetimkiem.Properties.DisplayMember = "MAMH";
            this.luetimkiem.Properties.NullText = "Chọn mã mặt hàng";
            this.luetimkiem.Properties.PopupView = this.searchLookUpEdit1View;
            this.luetimkiem.Properties.ShowClearButton = false;
            this.luetimkiem.Properties.ValueMember = "MAMH";
            this.luetimkiem.Size = new System.Drawing.Size(192, 20);
            this.luetimkiem.TabIndex = 2;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAMH1,
            this.TENMH,
            this.HINH,
            this.DACDIEM});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // MAMH1
            // 
            this.MAMH1.Caption = "Mã MH";
            this.MAMH1.FieldName = "MAMH";
            this.MAMH1.Name = "MAMH1";
            this.MAMH1.Visible = true;
            this.MAMH1.VisibleIndex = 0;
            // 
            // TENMH
            // 
            this.TENMH.Caption = "Tên MH";
            this.TENMH.FieldName = "TENMH";
            this.TENMH.Name = "TENMH";
            this.TENMH.Visible = true;
            this.TENMH.VisibleIndex = 1;
            // 
            // HINH
            // 
            this.HINH.Caption = "Hình";
            this.HINH.FieldName = "HINH";
            this.HINH.Name = "HINH";
            this.HINH.Visible = true;
            this.HINH.VisibleIndex = 2;
            // 
            // DACDIEM
            // 
            this.DACDIEM.Caption = "Đặc điểm";
            this.DACDIEM.FieldName = "DACDIEM";
            this.DACDIEM.Name = "DACDIEM";
            this.DACDIEM.Visible = true;
            this.DACDIEM.VisibleIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tìm:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbREf});
            this.toolStrip1.Location = new System.Drawing.Point(209, 88);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(78, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbREf
            // 
            this.tsbREf.Image = ((System.Drawing.Image)(resources.GetObject("tsbREf.Image")));
            this.tsbREf.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbREf.Name = "tsbREf";
            this.tsbREf.Size = new System.Drawing.Size(66, 22);
            this.tsbREf.Text = "Refresh";
            this.tsbREf.Click += new System.EventHandler(this.tsbREf_Click);
            // 
            // gridTonkho
            // 
            this.gridTonkho.Location = new System.Drawing.Point(208, 116);
            this.gridTonkho.MainView = this.gridView2;
            this.gridTonkho.Name = "gridTonkho";
            this.gridTonkho.Size = new System.Drawing.Size(592, 354);
            this.gridTonkho.TabIndex = 6;
            this.gridTonkho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAMH,
            this.SLNHAP,
            this.SLBAN,
            this.SLCON});
            this.gridView2.GridControl = this.gridTonkho;
            this.gridView2.Name = "gridView2";
            // 
            // MAMH
            // 
            this.MAMH.Caption = "Mã MH";
            this.MAMH.FieldName = "MAMH";
            this.MAMH.Name = "MAMH";
            this.MAMH.Visible = true;
            this.MAMH.VisibleIndex = 0;
            // 
            // SLNHAP
            // 
            this.SLNHAP.Caption = "Số lượng nhập";
            this.SLNHAP.FieldName = "SLNHAP";
            this.SLNHAP.Name = "SLNHAP";
            this.SLNHAP.Visible = true;
            this.SLNHAP.VisibleIndex = 1;
            // 
            // SLBAN
            // 
            this.SLBAN.Caption = "Số lượng bán";
            this.SLBAN.FieldName = "SLBAN";
            this.SLBAN.Name = "SLBAN";
            this.SLBAN.Visible = true;
            this.SLBAN.VisibleIndex = 2;
            // 
            // SLCON
            // 
            this.SLCON.Caption = "Số lượng còn";
            this.SLCON.FieldName = "SLCON";
            this.SLCON.Name = "SLCON";
            this.SLCON.Visible = true;
            this.SLCON.VisibleIndex = 3;
            // 
            // gridLoaiMH
            // 
            this.gridLoaiMH.Location = new System.Drawing.Point(434, 476);
            this.gridLoaiMH.MainView = this.gridView3;
            this.gridLoaiMH.Name = "gridLoaiMH";
            this.gridLoaiMH.Size = new System.Drawing.Size(40, 38);
            this.gridLoaiMH.TabIndex = 7;
            this.gridLoaiMH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridLoaiMH;
            this.gridView3.Name = "gridView3";
            // 
            // TonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.gridLoaiMH);
            this.Controls.Add(this.gridTonkho);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.trvtimkiem);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TonKho";
            this.Text = "Tồn Kho";
            this.Load += new System.EventHandler(this.TonKho_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luutimkiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luetimkiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTonkho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoaiMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView trvtimkiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SearchLookUpEdit luetimkiem;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn MAMH1;
        private DevExpress.XtraGrid.Columns.GridColumn TENMH;
        private DevExpress.XtraGrid.Columns.GridColumn HINH;
        private DevExpress.XtraGrid.Columns.GridColumn DACDIEM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SearchLookUpEdit luutimkiem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbREf;
        private DevExpress.XtraGrid.GridControl gridTonkho;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn MAMH;
        private DevExpress.XtraGrid.Columns.GridColumn SLNHAP;
        private DevExpress.XtraGrid.Columns.GridColumn SLBAN;
        private DevExpress.XtraGrid.Columns.GridColumn SLCON;
        private DevExpress.XtraGrid.GridControl gridLoaiMH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.ImageList imageList1;
    }
}