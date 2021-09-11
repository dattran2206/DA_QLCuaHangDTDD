namespace GUI
{
    partial class BaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaoCao));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnloc2 = new System.Windows.Forms.Button();
            this.btnloc1 = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.dtpDenngay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTungay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tooTragop = new System.Windows.Forms.ToolStrip();
            this.tsbNhapkho = new System.Windows.Forms.ToolStripButton();
            this.tsbXuatkho = new System.Windows.Forms.ToolStripButton();
            this.tsbTonkho = new System.Windows.Forms.ToolStripButton();
            this.tsbthu = new System.Windows.Forms.ToolStripButton();
            this.tsbchi = new System.Windows.Forms.ToolStripButton();
            this.panel2.SuspendLayout();
            this.tooTragop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel2.Controls.Add(this.btnloc2);
            this.panel2.Controls.Add(this.btnloc1);
            this.panel2.Controls.Add(this.btnLoc);
            this.panel2.Controls.Add(this.dtpDenngay);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dtpTungay);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1524, 69);
            this.panel2.TabIndex = 2;
            // 
            // btnloc2
            // 
            this.btnloc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloc2.Location = new System.Drawing.Point(567, 16);
            this.btnloc2.Name = "btnloc2";
            this.btnloc2.Size = new System.Drawing.Size(75, 34);
            this.btnloc2.TabIndex = 8;
            this.btnloc2.Text = "Lọc";
            this.btnloc2.UseVisualStyleBackColor = true;
            // 
            // btnloc1
            // 
            this.btnloc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloc1.Location = new System.Drawing.Point(567, 16);
            this.btnloc1.Name = "btnloc1";
            this.btnloc1.Size = new System.Drawing.Size(75, 34);
            this.btnloc1.TabIndex = 7;
            this.btnloc1.Text = "Lọc";
            this.btnloc1.UseVisualStyleBackColor = true;
            // 
            // btnLoc
            // 
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.Location = new System.Drawing.Point(567, 18);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(75, 34);
            this.btnLoc.TabIndex = 6;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            // 
            // dtpDenngay
            // 
            this.dtpDenngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenngay.Location = new System.Drawing.Point(337, 39);
            this.dtpDenngay.Name = "dtpDenngay";
            this.dtpDenngay.Size = new System.Drawing.Size(136, 20);
            this.dtpDenngay.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đến Ngày:";
            // 
            // dtpTungay
            // 
            this.dtpTungay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTungay.Location = new System.Drawing.Point(337, 13);
            this.dtpTungay.Name = "dtpTungay";
            this.dtpTungay.Size = new System.Drawing.Size(136, 20);
            this.dtpTungay.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Từ Ngày:";
            // 
            // tooTragop
            // 
            this.tooTragop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tooTragop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNhapkho,
            this.tsbXuatkho,
            this.tsbTonkho,
            this.tsbthu,
            this.tsbchi});
            this.tooTragop.Location = new System.Drawing.Point(0, 69);
            this.tooTragop.Name = "tooTragop";
            this.tooTragop.Size = new System.Drawing.Size(1524, 25);
            this.tooTragop.TabIndex = 3;
            this.tooTragop.Text = "toolStrip1";
            // 
            // tsbNhapkho
            // 
            this.tsbNhapkho.Image = ((System.Drawing.Image)(resources.GetObject("tsbNhapkho.Image")));
            this.tsbNhapkho.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNhapkho.Name = "tsbNhapkho";
            this.tsbNhapkho.Size = new System.Drawing.Size(80, 22);
            this.tsbNhapkho.Text = "Nhập Kho";
            this.tsbNhapkho.Click += new System.EventHandler(this.tsbNhapkho_Click);
            // 
            // tsbXuatkho
            // 
            this.tsbXuatkho.Image = ((System.Drawing.Image)(resources.GetObject("tsbXuatkho.Image")));
            this.tsbXuatkho.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbXuatkho.Name = "tsbXuatkho";
            this.tsbXuatkho.Size = new System.Drawing.Size(75, 22);
            this.tsbXuatkho.Text = "Xuất Kho";
            // 
            // tsbTonkho
            // 
            this.tsbTonkho.Image = ((System.Drawing.Image)(resources.GetObject("tsbTonkho.Image")));
            this.tsbTonkho.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTonkho.Name = "tsbTonkho";
            this.tsbTonkho.Size = new System.Drawing.Size(71, 22);
            this.tsbTonkho.Text = "Tồn Kho";
            // 
            // tsbthu
            // 
            this.tsbthu.Image = ((System.Drawing.Image)(resources.GetObject("tsbthu.Image")));
            this.tsbthu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbthu.Name = "tsbthu";
            this.tsbthu.Size = new System.Drawing.Size(72, 22);
            this.tsbthu.Text = "Quỹ Thu";
            // 
            // tsbchi
            // 
            this.tsbchi.Image = ((System.Drawing.Image)(resources.GetObject("tsbchi.Image")));
            this.tsbchi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbchi.Name = "tsbchi";
            this.tsbchi.Size = new System.Drawing.Size(70, 22);
            this.tsbchi.Text = "Quỹ Chi";
            // 
            // BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 764);
            this.Controls.Add(this.tooTragop);
            this.Controls.Add(this.panel2);
            this.Name = "BaoCao";
            this.Text = "Báo Cáo";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tooTragop.ResumeLayout(false);
            this.tooTragop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnloc2;
        private System.Windows.Forms.Button btnloc1;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.DateTimePicker dtpDenngay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTungay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip tooTragop;
        private System.Windows.Forms.ToolStripButton tsbNhapkho;
        private System.Windows.Forms.ToolStripButton tsbXuatkho;
        private System.Windows.Forms.ToolStripButton tsbTonkho;
        private System.Windows.Forms.ToolStripButton tsbthu;
        private System.Windows.Forms.ToolStripButton tsbchi;
    }
}