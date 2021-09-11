using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
namespace GUI
{
    public partial class PhieuThu1 : Form
    {
        PhieuThuDAL_BLL PT = new PhieuThuDAL_BLL();
        NhanVienDAL_BLL nv = new NhanVienDAL_BLL();
        public PhieuThu1()
        {
            InitializeComponent();
        }
        public string MAPT { set; get; }
        public string LYDOTHU { set; get; }
        public string NGUOINOPTIEN { set; get; }
        public string SOTIEN { set; get; }
        public string GHICHU { set; get; }
        public string NGAY { set; get; }
        public bool THEM { set; get; }
        private void PhieuThu1_Load(object sender, EventArgs e)
        {
            loaddata();
            txtMapt.Text = MAPT;
            txtlydothu.Text = LYDOTHU;
            lueNguoinop.EditValue= NGUOINOPTIEN;
            txtsotien.Text = SOTIEN;
            txtGhichu.Text = GHICHU;
            dtpNgay.Text = NGAY;
          
        }
        public bool DEM { set; get; }
        public void loaddata()
        {
            int mq = int.Parse(DangNhap.MAQUYEN);
            if (mq == 3)
            {
                lueNguoinop.Properties.DataSource = nv.LayNhanVien2(mq);
                lueNguoinop.Properties.DisplayMember = "HOTEN";
                lueNguoinop.Properties.ValueMember = "MANV";
            }
            else
            {
                lueNguoinop.Properties.DataSource = nv.LayNhanVien();
                lueNguoinop.Properties.DisplayMember = "HOTEN";
                lueNguoinop.Properties.ValueMember = "MANV";
            }
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            if (THEM)
            {
                try
                {
                    PT.ThemPhieuThu(int.Parse(txtMapt.Text.Trim()), txtlydothu.Text.Trim(), int.Parse(lueNguoinop.EditValue.ToString()), float.Parse(txtsotien.Text.Trim()), DateTime.Parse(dtpNgay.Text.Trim()), txtGhichu.Text.Trim());
                    MessageBox.Show("Thêm phiếu thu mới thành công", "Thông báo");
                    DEM = true;
                }
                catch
                {
                    MessageBox.Show("Không thêm được phiếu thu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (!THEM)
            {
                try
                {
                    PT.CapNhatPhieuThu(int.Parse(txtMapt.Text.Trim()), txtlydothu.Text.Trim(), int.Parse(lueNguoinop.EditValue.ToString()), float.Parse(txtsotien.Text.Trim()), DateTime.Parse(dtpNgay.Text.Trim()), txtGhichu.Text.Trim());
                    MessageBox.Show("Đã cập nhật phiếu thu mới", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Không cập nhật được phiếu thu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (DEM == true)
            {
                int DEM2 = int.Parse(txtMapt.Text) + 1;
                txtMapt.Text = DEM2.ToString();
                DEM = false;
            }
            txtlydothu.ResetText();
            txtGhichu.ResetText();
            lueNguoinop.ResetText();
            txtsotien.ResetText();
            txtlydothu.Focus();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
