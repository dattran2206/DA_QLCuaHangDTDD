namespace GUI
{
    partial class BaoHanh1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaoHanh1));
            this.luenhanvien = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.luemathang = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.chkdatra = new DevExpress.XtraEditors.CheckEdit();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpngaytra = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpngaynhan = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtyeucau = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdienthoai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttenbh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmabh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.MANV1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SDT2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAMH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DACDIEM1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HINH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.luenhanvien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luemathang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkdatra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // luenhanvien
            // 
            this.luenhanvien.Location = new System.Drawing.Point(122, 175);
            this.luenhanvien.Name = "luenhanvien";
            this.luenhanvien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luenhanvien.Properties.DisplayMember = "MANV";
            this.luenhanvien.Properties.NullText = "";
            this.luenhanvien.Properties.PopupView = this.gridView1;
            this.luenhanvien.Properties.ShowClearButton = false;
            this.luenhanvien.Properties.ValueMember = "MANV";
            this.luenhanvien.Size = new System.Drawing.Size(322, 20);
            this.luenhanvien.TabIndex = 93;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MANV1,
            this.TEN1,
            this.SDT2,
            this.BP});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // luemathang
            // 
            this.luemathang.Location = new System.Drawing.Point(122, 147);
            this.luemathang.Name = "luemathang";
            this.luemathang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luemathang.Properties.DisplayMember = "MAMH";
            this.luemathang.Properties.NullText = "";
            this.luemathang.Properties.PopupView = this.searchLookUpEdit1View;
            this.luemathang.Properties.ShowClearButton = false;
            this.luemathang.Properties.ValueMember = "MAMH";
            this.luemathang.Size = new System.Drawing.Size(322, 20);
            this.luemathang.TabIndex = 92;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAMH1,
            this.TEN,
            this.DACDIEM1,
            this.HINH1});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // chkdatra
            // 
            this.chkdatra.Location = new System.Drawing.Point(120, 341);
            this.chkdatra.Name = "chkdatra";
            this.chkdatra.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.chkdatra.Properties.Appearance.Options.UseFont = true;
            this.chkdatra.Properties.Caption = "Đã trả";
            this.chkdatra.Size = new System.Drawing.Size(75, 21);
            this.chkdatra.TabIndex = 88;
            // 
            // txtghichu
            // 
            this.txtghichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtghichu.Location = new System.Drawing.Point(122, 286);
            this.txtghichu.Multiline = true;
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(322, 49);
            this.txtghichu.TabIndex = 87;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 86;
            this.label10.Text = "Ghi chú:";
            // 
            // dtpngaytra
            // 
            this.dtpngaytra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaytra.Location = new System.Drawing.Point(347, 260);
            this.dtpngaytra.Name = "dtpngaytra";
            this.dtpngaytra.Size = new System.Drawing.Size(97, 20);
            this.dtpngaytra.TabIndex = 85;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(241, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 84;
            this.label9.Text = "Ngày trả dk:";
            // 
            // dtpngaynhan
            // 
            this.dtpngaynhan.Enabled = false;
            this.dtpngaynhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaynhan.Location = new System.Drawing.Point(122, 260);
            this.dtpngaynhan.Name = "dtpngaynhan";
            this.dtpngaynhan.Size = new System.Drawing.Size(97, 20);
            this.dtpngaynhan.TabIndex = 83;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 82;
            this.label8.Text = "Ngày nhận:";
            // 
            // txtyeucau
            // 
            this.txtyeucau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtyeucau.Location = new System.Drawing.Point(122, 199);
            this.txtyeucau.Multiline = true;
            this.txtyeucau.Name = "txtyeucau";
            this.txtyeucau.Size = new System.Drawing.Size(322, 51);
            this.txtyeucau.TabIndex = 81;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 80;
            this.label7.Text = "Yêu cầu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 79;
            this.label6.Text = "Nhân viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 78;
            this.label5.Text = "Mặt hàng:";
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdienthoai.Location = new System.Drawing.Point(122, 119);
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Size = new System.Drawing.Size(322, 21);
            this.txtdienthoai.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 76;
            this.label4.Text = "Điện thoại:";
            // 
            // txttenbh
            // 
            this.txttenbh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenbh.Location = new System.Drawing.Point(122, 92);
            this.txttenbh.Name = "txttenbh";
            this.txttenbh.Size = new System.Drawing.Size(322, 21);
            this.txttenbh.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 74;
            this.label2.Text = "Tên KH:";
            // 
            // txtmabh
            // 
            this.txtmabh.Enabled = false;
            this.txtmabh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmabh.Location = new System.Drawing.Point(122, 65);
            this.txtmabh.Name = "txtmabh";
            this.txtmabh.Size = new System.Drawing.Size(322, 21);
            this.txtmabh.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 72;
            this.label1.Text = "Mã Bảo hành:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PowderBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 20);
            this.label3.TabIndex = 96;
            this.label3.Text = "Lập phiếu bảo hành";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(10, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 95;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(491, 51);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 94;
            this.pictureBox4.TabStop = false;
            // 
            // MANV1
            // 
            this.MANV1.Caption = "MA NV";
            this.MANV1.FieldName = "MANV";
            this.MANV1.Name = "MANV1";
            this.MANV1.Visible = true;
            this.MANV1.VisibleIndex = 0;
            // 
            // TEN1
            // 
            this.TEN1.Caption = "HO TEN";
            this.TEN1.FieldName = "HOTEN";
            this.TEN1.Name = "TEN1";
            this.TEN1.Visible = true;
            this.TEN1.VisibleIndex = 1;
            // 
            // SDT2
            // 
            this.SDT2.Caption = "DIEN THOAI";
            this.SDT2.FieldName = "SDT";
            this.SDT2.Name = "SDT2";
            this.SDT2.Visible = true;
            this.SDT2.VisibleIndex = 2;
            // 
            // BP
            // 
            this.BP.Caption = "MA BP";
            this.BP.FieldName = "MABP";
            this.BP.Name = "BP";
            this.BP.Visible = true;
            this.BP.VisibleIndex = 3;
            // 
            // MAMH1
            // 
            this.MAMH1.Caption = "MAMH";
            this.MAMH1.FieldName = "MAMH";
            this.MAMH1.Name = "MAMH1";
            this.MAMH1.Visible = true;
            this.MAMH1.VisibleIndex = 0;
            // 
            // TEN
            // 
            this.TEN.Caption = "TEN MH";
            this.TEN.FieldName = "TENMH";
            this.TEN.Name = "TEN";
            this.TEN.Visible = true;
            this.TEN.VisibleIndex = 1;
            // 
            // DACDIEM1
            // 
            this.DACDIEM1.Caption = "DAC DIEM";
            this.DACDIEM1.FieldName = "DACDIEM";
            this.DACDIEM1.Name = "DACDIEM1";
            this.DACDIEM1.Visible = true;
            this.DACDIEM1.VisibleIndex = 2;
            // 
            // HINH1
            // 
            this.HINH1.Caption = "HINH";
            this.HINH1.FieldName = "HINH";
            this.HINH1.Name = "HINH1";
            this.HINH1.Visible = true;
            this.HINH1.VisibleIndex = 3;
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.Location = new System.Drawing.Point(371, 368);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(73, 34);
            this.btnthoat.TabIndex = 91;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(254, 368);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(72, 34);
            this.btnHuy.TabIndex = 90;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.Location = new System.Drawing.Point(110, 368);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(100, 34);
            this.btnluu.TabIndex = 89;
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(491, 459);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(491, 459);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 70;
            this.pictureBox2.TabStop = false;
            // 
            // BaoHanh1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 459);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.luenhanvien);
            this.Controls.Add(this.luemathang);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.chkdatra);
            this.Controls.Add(this.txtghichu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpngaytra);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpngaynhan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtyeucau);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdienthoai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttenbh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmabh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "BaoHanh1";
            this.Text = "Bảo Hành";
            this.Load += new System.EventHandler(this.BaoHanh1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.luenhanvien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luemathang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkdatra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit luenhanvien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MANV1;
        private DevExpress.XtraGrid.Columns.GridColumn TEN1;
        private DevExpress.XtraGrid.Columns.GridColumn SDT2;
        private DevExpress.XtraGrid.Columns.GridColumn BP;
        private DevExpress.XtraEditors.SearchLookUpEdit luemathang;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn MAMH1;
        private DevExpress.XtraGrid.Columns.GridColumn TEN;
        private DevExpress.XtraGrid.Columns.GridColumn DACDIEM1;
        private DevExpress.XtraGrid.Columns.GridColumn HINH1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnluu;
        private DevExpress.XtraEditors.CheckEdit chkdatra;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpngaytra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpngaynhan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtyeucau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdienthoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttenbh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmabh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}