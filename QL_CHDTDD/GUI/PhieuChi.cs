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
    public partial class PhieuChi : Form
    {
        PhieuChiDAL_BLL PC = new PhieuChiDAL_BLL();
        NhanVienDAL_BLL nv = new NhanVienDAL_BLL();
        public PhieuChi()
        {
            InitializeComponent();
        }
        public void loaddata()
        {
            int mq = int.Parse(DangNhap.MAQUYEN);
            if (mq == 3)
            { 
                lueNguoinhan.Properties.DataSource = nv.LayNhanVien2(mq);
                lueNguoinhan.Properties.DisplayMember = "HOTEN";
                lueNguoinhan.Properties.ValueMember = "MANV";
            }
            else
            {
                lueNguoinhan.Properties.DataSource = nv.LayNhanVien();
                lueNguoinhan.Properties.DisplayMember = "HOTEN";
                lueNguoinhan.Properties.ValueMember = "MANV";
            }
        }
        public string MAPC { set; get; }
        public string LYDOCHI { set; get; }
        public string NGUOINHAN { set; get; }
        public string SOTIEN1 { set; get; }
        public string GHICHU1 { set; get; }
        public string NGAY1 { set; get; }
        public bool THEM1 { set; get; }
        public bool DEM { set; get; }
        private void btnluu_Click(object sender, EventArgs e)
        {
            if (THEM1)
            {
                try
                {
                    PC.ThemPhieuChi(int.Parse(txtMapc.Text.Trim()), txtlydochi.Text.Trim(), int.Parse(lueNguoinhan.EditValue.ToString()), float.Parse(txtsotien.Text.Trim()), DateTime.Parse(dtpNgay.Text.Trim()), txtGhichu.Text.Trim());
                    MessageBox.Show("Thêm phiếu chi mới thành công", "Thông báo");
                    DEM = true;
                }
                catch
                {
                    MessageBox.Show("Không thêm được phiếu chi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (!THEM1)
            {
                try
                {
                    PC.CapNhatPhieuChi(int.Parse(txtMapc.Text.Trim()), txtlydochi.Text.Trim(), int.Parse(lueNguoinhan.EditValue.ToString()), float.Parse(txtsotien.Text.Trim()), DateTime.Parse(dtpNgay.Text.Trim()), txtGhichu.Text.Trim());
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
                int DEM2 = int.Parse(txtMapc.Text) + 1;
                txtMapc.Text = DEM2.ToString();
                DEM = false;
            }
            txtlydochi.ResetText();
            txtGhichu.ResetText();
            txtsotien.ResetText();
            lueNguoinhan.ResetText();
            txtlydochi.Focus();
        }

        private void PhieuChi_Load(object sender, EventArgs e)
        {
            loaddata();
            txtMapc.Text = MAPC;
            txtlydochi.Text = LYDOCHI;
            lueNguoinhan.EditValue = NGUOINHAN;
            txtsotien.Text = SOTIEN1;
            dtpNgay.Text = NGAY1;
            txtGhichu.Text = GHICHU1;
        }
    }
}
