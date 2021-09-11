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
    public partial class HoaDon : Form
    {
        NhanVienDAL_BLL NV = new NhanVienDAL_BLL();
        KhachHangDAL_BLL KH = new KhachHangDAL_BLL();
        HoaDonDAL_BLL HD = new HoaDonDAL_BLL();
        public HoaDon()
        {
            InitializeComponent();
        }
        public string MAHD { set; get; }
        public int SOLUONG { set; get; }
        public string MAKH { set; get; }
        public string NGAYLAP { set; get; }
        public string MANV { set; get; }
        public float TONGTIEN { set; get; }
        public bool THEM { set; get; }
        public bool DEM { set; get; }
        public void Loaddata()
        {
            int mq = int.Parse(DangNhap.MAQUYEN);

            lueKH.Properties.DataSource = KH.LayKhachHang();
            lueKH.Properties.DisplayMember = "HOTEN";
            lueKH.Properties.ValueMember = "MAKH";

            if(mq==1)
            {
                lueNV.Properties.DataSource = NV.LayNhanVien2(mq);
                lueNV.Properties.DisplayMember = "HOTEN";
                lueNV.Properties.ValueMember = "MANV";
            }
            else
            {
                lueNV.Properties.DataSource = NV.LayNhanVien();
                lueNV.Properties.DisplayMember = "HOTEN";
                lueNV.Properties.ValueMember = "MANV";
            }
        }
        private void HoaDon_Load(object sender, EventArgs e)
        {
            if (THEM == false)
            {
                txtMaHD.Text = MAHD;
                txtSL.Text = SOLUONG.ToString();
                lueKH.EditValue = MAKH;
                dtpNgayLap.Enabled = true;
                dtpNgayLap.Text = NGAYLAP;
                lueNV.EditValue= MANV;
                txtTongTien.Text = TONGTIEN.ToString();
            }
            else
            {
                txtMaHD.Text = MAHD;
                txtSL.Text = SOLUONG.ToString();
                dtpNgayLap.Enabled = false;
                dtpNgayLap.Text = DateTime.Now.ToShortDateString();
                txtTongTien.Text = TONGTIEN.ToString();
            }
            Loaddata();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (THEM)
            {
                try
                {
                    HD.ThemHoaDon(int.Parse(txtMaHD.Text.Trim()), txtSL.Text.Trim(), int.Parse(lueKH.EditValue.ToString()), DateTime.Parse(dtpNgayLap.Text.Trim()), int.Parse(lueNV.EditValue.ToString()), txtTongTien.Text.Trim());
                    MessageBox.Show("Thêm hóa đơn mới thành công", "Thông báo");
                    MANV = lueNV.EditValue.ToString();
                    DEM = true;
                }
                catch
                {
                    MessageBox.Show("Không thêm được hóa đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (!THEM)
            {
                try
                {
                    HD.CapNhatHoaDon(int.Parse(txtMaHD.Text), int.Parse(txtSL.Text), int.Parse(lueKH.EditValue.ToString()), DateTime.Parse(dtpNgayLap.Text), int.Parse(lueNV.EditValue.ToString()), float.Parse(txtTongTien.Text));
                    MessageBox.Show("Đã cập nhật hóa đơn mới", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Không cập nhật được hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            if (DEM == true)
            {
                int DEM2 = int.Parse(txtMaHD.Text) + 1;
                txtMaHD.Text = DEM2.ToString();
                DEM = false;
            }
            lueKH.ResetText();
            lueNV.ResetText();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn Có Muốn Thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}
