namespace GUI
{
    partial class MatHang1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cb_loaiMH = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.txt_ghichu = new System.Windows.Forms.TextBox();
            this.txt_dacdiem = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_donvitinh = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_baohanh = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_giamua = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_giaban = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnlayhinh = new System.Windows.Forms.Button();
            this.picHINH = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_hangsanxuat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tenmathang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mamathang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.luekhuyenmai = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHINH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luekhuyenmai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 44);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mặt hàng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.iphone;
            this.pictureBox1.Location = new System.Drawing.Point(22, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cb_loaiMH
            // 
            this.cb_loaiMH.FormattingEnabled = true;
            this.cb_loaiMH.Items.AddRange(new object[] {
            "Điện thoại",
            "Tai phone",
            "Bàn phím",
            "Cục sạc"});
            this.cb_loaiMH.Location = new System.Drawing.Point(353, 290);
            this.cb_loaiMH.Name = "cb_loaiMH";
            this.cb_loaiMH.Size = new System.Drawing.Size(137, 21);
            this.cb_loaiMH.TabIndex = 132;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(250, 290);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 17);
            this.label14.TabIndex = 131;
            this.label14.Text = "Loại MH:";
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.White;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(341, 393);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(74, 28);
            this.btnthoat.TabIndex = 130;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.BackColor = System.Drawing.Color.White;
            this.btnhuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.Location = new System.Drawing.Point(229, 393);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(69, 28);
            this.btnhuy.TabIndex = 129;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = false;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.Color.White;
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Location = new System.Drawing.Point(113, 393);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(83, 28);
            this.btnluu.TabIndex = 128;
            this.btnluu.Text = "Lưu dữ liệu";
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ghichu.Location = new System.Drawing.Point(87, 322);
            this.txt_ghichu.Multiline = true;
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(403, 60);
            this.txt_ghichu.TabIndex = 127;
            // 
            // txt_dacdiem
            // 
            this.txt_dacdiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dacdiem.Location = new System.Drawing.Point(87, 213);
            this.txt_dacdiem.Multiline = true;
            this.txt_dacdiem.Name = "txt_dacdiem";
            this.txt_dacdiem.Size = new System.Drawing.Size(149, 99);
            this.txt_dacdiem.TabIndex = 126;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 334);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 17);
            this.label13.TabIndex = 125;
            this.label13.Text = "Ghi Chú:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 124;
            this.label7.Text = "Đặc điểm:";
            // 
            // txt_soluong
            // 
            this.txt_soluong.Enabled = false;
            this.txt_soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soluong.Location = new System.Drawing.Point(353, 263);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(137, 21);
            this.txt_soluong.TabIndex = 123;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(250, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 122;
            this.label5.Text = "Số lượng:";
            // 
            // cb_donvitinh
            // 
            this.cb_donvitinh.FormattingEnabled = true;
            this.cb_donvitinh.Items.AddRange(new object[] {
            "Cái",
            "Chiếc"});
            this.cb_donvitinh.Location = new System.Drawing.Point(353, 239);
            this.cb_donvitinh.Name = "cb_donvitinh";
            this.cb_donvitinh.Size = new System.Drawing.Size(137, 21);
            this.cb_donvitinh.TabIndex = 121;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(250, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 17);
            this.label12.TabIndex = 120;
            this.label12.Text = "Khuyến mãi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(250, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 17);
            this.label10.TabIndex = 119;
            this.label10.Text = "Đơn vị tính:";
            // 
            // txt_baohanh
            // 
            this.txt_baohanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_baohanh.Location = new System.Drawing.Point(353, 185);
            this.txt_baohanh.Name = "txt_baohanh";
            this.txt_baohanh.Size = new System.Drawing.Size(137, 21);
            this.txt_baohanh.TabIndex = 118;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(250, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 17);
            this.label11.TabIndex = 117;
            this.label11.Text = "bảo hành:";
            // 
            // txt_giamua
            // 
            this.txt_giamua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giamua.Location = new System.Drawing.Point(353, 158);
            this.txt_giamua.Name = "txt_giamua";
            this.txt_giamua.Size = new System.Drawing.Size(137, 21);
            this.txt_giamua.TabIndex = 116;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(250, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 115;
            this.label9.Text = "Giá mua:";
            // 
            // txt_giaban
            // 
            this.txt_giaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giaban.Location = new System.Drawing.Point(353, 131);
            this.txt_giaban.Name = "txt_giaban";
            this.txt_giaban.Size = new System.Drawing.Size(139, 21);
            this.txt_giaban.TabIndex = 114;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(250, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 113;
            this.label6.Text = "Giá bán:";
            // 
            // btnlayhinh
            // 
            this.btnlayhinh.BackColor = System.Drawing.Color.White;
            this.btnlayhinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlayhinh.Location = new System.Drawing.Point(10, 70);
            this.btnlayhinh.Name = "btnlayhinh";
            this.btnlayhinh.Size = new System.Drawing.Size(70, 28);
            this.btnlayhinh.TabIndex = 112;
            this.btnlayhinh.Text = "Lấy hình";
            this.btnlayhinh.UseVisualStyleBackColor = false;
            this.btnlayhinh.Click += new System.EventHandler(this.btnlayhinh_Click);
            // 
            // picHINH
            // 
            this.picHINH.BackColor = System.Drawing.Color.White;
            this.picHINH.Location = new System.Drawing.Point(90, 50);
            this.picHINH.Name = "picHINH";
            this.picHINH.Size = new System.Drawing.Size(146, 155);
            this.picHINH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHINH.TabIndex = 111;
            this.picHINH.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 110;
            this.label8.Text = "Hình:";
            // 
            // txt_hangsanxuat
            // 
            this.txt_hangsanxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hangsanxuat.Location = new System.Drawing.Point(353, 104);
            this.txt_hangsanxuat.Name = "txt_hangsanxuat";
            this.txt_hangsanxuat.Size = new System.Drawing.Size(139, 21);
            this.txt_hangsanxuat.TabIndex = 109;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(250, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 108;
            this.label4.Text = "Hãng sản xuất:";
            // 
            // txt_tenmathang
            // 
            this.txt_tenmathang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenmathang.Location = new System.Drawing.Point(353, 77);
            this.txt_tenmathang.Name = "txt_tenmathang";
            this.txt_tenmathang.Size = new System.Drawing.Size(139, 21);
            this.txt_tenmathang.TabIndex = 107;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 106;
            this.label3.Text = "Tên mặt hàng:";
            // 
            // txt_mamathang
            // 
            this.txt_mamathang.Enabled = false;
            this.txt_mamathang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mamathang.Location = new System.Drawing.Point(353, 50);
            this.txt_mamathang.Name = "txt_mamathang";
            this.txt_mamathang.Size = new System.Drawing.Size(139, 21);
            this.txt_mamathang.TabIndex = 105;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 104;
            this.label2.Text = "Mã mặt hàng:";
            // 
            // luekhuyenmai
            // 
            this.luekhuyenmai.Location = new System.Drawing.Point(353, 212);
            this.luekhuyenmai.Name = "luekhuyenmai";
            this.luekhuyenmai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.luekhuyenmai.Properties.DisplayMember = "MAKM";
            this.luekhuyenmai.Properties.NullText = "";
            this.luekhuyenmai.Properties.PopupView = this.searchLookUpEdit1View;
            this.luekhuyenmai.Properties.ShowClearButton = false;
            this.luekhuyenmai.Properties.ValueMember = "MAKM";
            this.luekhuyenmai.Size = new System.Drawing.Size(137, 20);
            this.luekhuyenmai.TabIndex = 134;
            this.luekhuyenmai.EditValueChanged += new System.EventHandler(this.luekhuyenmai_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // MatHang1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(526, 438);
            this.Controls.Add(this.luekhuyenmai);
            this.Controls.Add(this.cb_loaiMH);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.txt_ghichu);
            this.Controls.Add(this.txt_dacdiem);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_donvitinh);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_baohanh);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_giamua);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_giaban);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnlayhinh);
            this.Controls.Add(this.picHINH);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_hangsanxuat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tenmathang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_mamathang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MatHang1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mặt Hàng";
            this.Load += new System.EventHandler(this.MatHang1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHINH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luekhuyenmai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cb_loaiMH;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.TextBox txt_ghichu;
        private System.Windows.Forms.TextBox txt_dacdiem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_donvitinh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_baohanh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_giamua;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_giaban;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnlayhinh;
        private System.Windows.Forms.PictureBox picHINH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_hangsanxuat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tenmathang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_mamathang;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SearchLookUpEdit luekhuyenmai;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
    }
}