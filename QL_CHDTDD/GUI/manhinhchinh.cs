using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class manhinhchinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public manhinhchinh()
        {
            InitializeComponent();
        }
        public string MAQUYEN { set; get; }
        private Form isActive(Type type)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType() == type)
                    return item;
            }
            return null;
        }
        private void manhinhchinh_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            MAQUYEN = DangNhap.MAQUYEN;
            if (MAQUYEN == "1")//BÁN HÀNG
            {
                rbp_Hethong.Visible = true;
                rbp_Banhang.Visible = true;
                rbp_KhoHang.Visible = false;
                rbp_KyThuat.Visible = false;
                rbp_NhanSu.Visible = false;
                rbp_QuanTri.Visible = false;
                rbp_Quy.Visible = false;
                rbp_TraGop.Visible = false;
                rbp_TroGiup.Visible = true;
                sbtn_BaoCao.Visible = true;
                sbtn_MatHang.Visible = true;
                sbtn_KhachHang.Visible = true;
                sbtn_KhuyenMai.Visible = true;
                sbtn_ThongKe.Visible = false;
            }
            if(MAQUYEN=="2")//KỸ THUẬT
            {
                rbp_Hethong.Visible = true;
                rbp_Banhang.Visible = false;
                rbp_KhoHang.Visible = false;
                rbp_KyThuat.Visible = true;
                rbp_NhanSu.Visible = false;
                rbp_QuanTri.Visible = false;
                rbp_Quy.Visible = false;
                rbp_TraGop.Visible = false;
                rbp_TroGiup.Visible = true;
                sbtn_BaoCao.Visible = true;
                sbtn_MatHang.Visible = false;
                sbtn_KhachHang.Visible = false;
                sbtn_KhuyenMai.Visible = false;
                sbtn_ThongKe.Visible = false;
            }
            if(MAQUYEN=="3")//TRẢ GÓP
            {
                rbp_Hethong.Visible = true;
                rbp_Banhang.Visible = false;
                rbp_KhoHang.Visible = false;
                rbp_KyThuat.Visible = false;
                rbp_NhanSu.Visible = false;
                rbp_QuanTri.Visible = false;
                rbp_Quy.Visible = false;
                rbp_TraGop.Visible = true;
                rbp_TroGiup.Visible = true;
                sbtn_BaoCao.Visible = true;
                sbtn_MatHang.Visible = true;
                sbtn_KhachHang.Visible = true;
                sbtn_KhuyenMai.Visible = false;
                sbtn_ThongKe.Visible = false;

            }
            if(MAQUYEN=="4")//KHO
            {
                rbp_Hethong.Visible = true;
                rbp_Banhang.Visible = false;
                rbp_KhoHang.Visible = true;
                rbp_KyThuat.Visible = false;
                rbp_NhanSu.Visible = false;
                rbp_QuanTri.Visible = false;
                rbp_Quy.Visible = false;
                rbp_TraGop.Visible = false;
                rbp_TroGiup.Visible = true;
                sbtn_BaoCao.Visible = true;
                sbtn_MatHang.Visible = true;
                sbtn_KhachHang.Visible = false;
                sbtn_KhuyenMai.Visible = false;
                sbtn_ThongKe.Visible = false;
            }
            if (MAQUYEN == "5")//ADMIN
            {
                rbp_Hethong.Visible = true;
                rbp_Banhang.Visible = false;
                rbp_KhoHang.Visible = false;
                rbp_KyThuat.Visible = false;
                rbp_NhanSu.Visible = true;
                rbp_QuanTri.Visible = true;
                rbp_Quy.Visible = false;
                rbp_TraGop.Visible = false;
                rbp_TroGiup.Visible = true;
                sbtn_BaoCao.Visible = true;
                sbtn_MatHang.Visible = false;
                sbtn_KhachHang.Visible = false;
                sbtn_KhuyenMai.Visible = false;
                sbtn_ThongKe.Visible = false;
            }
            if (MAQUYEN == "6")//QUỶ
            {
                rbp_Hethong.Visible = true;
                rbp_Banhang.Visible = false;
                rbp_KhoHang.Visible = false;
                rbp_KyThuat.Visible = false;
                rbp_NhanSu.Visible = false;
                rbp_QuanTri.Visible = false;
                rbp_Quy.Visible = true;
                rbp_TraGop.Visible = false;
                rbp_TroGiup.Visible = true;
                sbtn_BaoCao.Visible = true;
                sbtn_MatHang.Visible = false;
                sbtn_KhachHang.Visible = false;
                sbtn_KhuyenMai.Visible = false;
                sbtn_ThongKe.Visible = true;
            }
            if(MAQUYEN=="7")//DEMO
            {
                rbp_Hethong.Visible = true;
                rbp_Banhang.Visible = true;
                rbp_KhoHang.Visible = true;
                rbp_KyThuat.Visible = true;
                rbp_NhanSu.Visible = true;
                rbp_QuanTri.Visible = true;
                rbp_Quy.Visible = true;
                rbp_TraGop.Visible = true;
                rbp_TroGiup.Visible = true;
                sbtn_BaoCao.Visible = true;
                sbtn_MatHang.Visible = true;
                sbtn_KhachHang.Visible = true;
                sbtn_KhuyenMai.Visible = true;
                sbtn_ThongKe.Visible = true;
            }
        }


        private void sbtn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn Có Muốn Thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_doimatkhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DoiMatKhau dmk = new DoiMatKhau();
            dmk.Show();
        }

        private void btn_dangxuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn Có Muốn Đăng Xuất", "Đăng Xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
                DangNhap dn = new DangNhap();
                dn.Show();
            }

                
        }

        private void btn_thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn Có Muốn Thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                Application.Exit();
        }

        private void mathang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = isActive(typeof(MatHang));
            if (form == null)
            {
                MatHang f = new MatHang();
                f.MdiParent = this;
                f.QUYEN = MAQUYEN;
                f.Show();
            }
            else
                form.Activate();
        }

        private void btn_qlhoadon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = isActive(typeof(HoaDonCTHD));
            if (form == null)
            {
                HoaDonCTHD f = new HoaDonCTHD();
                f.MdiParent = this;
                f.Show();
            }
            else
                form.Activate();
        }

        private void btn_danhmuckhachhang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = isActive(typeof(KhachHang));
            if (form == null)
            {
                KhachHang f = new KhachHang();
                f.MdiParent = this;
                f.Show();
            }
            else
                form.Activate();
        }

        private void btn_nhacungcap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = isActive(typeof(NhaCungCap));
            if (form == null)
            {
                NhaCungCap f = new NhaCungCap();
                f.MdiParent = this;
                f.Show();
            }
            else
                form.Activate();
        }

        private void btn_nhapkho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = isActive(typeof(NhapKho));
            if (form == null)
            {
                NhapKho f = new NhapKho();
                f.MdiParent = this;
                f.Show();
            }
            else
                form.Activate();
        }

        private void btn_xuatkho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = isActive(typeof(XuatKho));
            if (form == null)
            {
                XuatKho f = new XuatKho();
                f.MdiParent = this;
                f.Show();
            }
            else
                form.Activate();
        }

        private void btn_tonkho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = isActive(typeof(TonKho));
            if (form == null)
            {
                TonKho f = new TonKho();
                f.MdiParent = this;
                f.Show();
            }
            else
                form.Activate();
        }

        private void btn_phieudathang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = isActive(typeof(PhieuDatHang));
            if (form == null)
            {
                PhieuDatHang f = new PhieuDatHang();
                f.MdiParent = this;
                f.Show();
            }
            else
                form.Activate();
        }

        private void btn_qltragop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = isActive(typeof(BienLaiTraGop));
            if (form == null)
            {
                BienLaiTraGop f = new BienLaiTraGop();
                f.MdiParent = this;
                f.Show();
            }
            else
                form.Activate();
        }

        private void btn_tbtragop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Form form = isActive(typeof(ThongBaoTraGop));
            //if (form == null)
            //{
            //    ThongBaoTraGop f = new ThongBaoTraGop();
            //    f.MdiParent = this;
            //    f.Show();
            //}
            //else
            //    form.Activate();
        }

        private void btn_phieuthuphieuchi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = isActive(typeof(DanhMucPhieuThuChi));
            if (form == null)
            {
                DanhMucPhieuThuChi f = new DanhMucPhieuThuChi();
                f.MdiParent = this;
                f.Show();
            }
            else
                form.Activate();
        }

        private void btn_nhanvien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = isActive(typeof(NhanVien));
            if (form == null)
            {
                NhanVien f = new NhanVien();
                f.MdiParent = this;
                f.Show();
            }
            else
                form.Activate();
        }

        private void btn_bophan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = isActive(typeof(BoPhan));
            if (form == null)
            {
                BoPhan f = new BoPhan();
                f.MdiParent = this;
                f.Show();
            }
            else
                form.Activate();
        }

        private void btn_qlbaohanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = isActive(typeof(BaoHanh));
            if (form == null)
            {
                BaoHanh f = new BaoHanh();
                f.MdiParent = this;
                f.Show();
            }
            else
                form.Activate();
        }

        private void btn_quanlytaikhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = isActive(typeof(QuanlyTaiKhoan));
            if (form == null)
            {
                QuanlyTaiKhoan f = new QuanlyTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
            else
                form.Activate();
        }

        private void sbtn_KhuyenMai_Click(object sender, EventArgs e)
        {
            Form form = isActive(typeof(KhuyenMai));
            if (form == null)
            {
                KhuyenMai f = new KhuyenMai();
                f.MdiParent = this;
                f.Show();
            }
            else
                form.Activate();
        }

        private void sbtn_ThongKe_Click(object sender, EventArgs e)
        {

            Form form = isActive(typeof(ThongKe));
            if (form == null)
            {
                ThongKe f = new ThongKe();
                f.MdiParent = this;
                f.Show();
            }
            else
                form.Activate();
        }

        private void sbtn_MatHang_Click(object sender, EventArgs e)
        {
            Form form = isActive(typeof(MatHang));
            if (form == null)
            {
                MatHang f = new MatHang();
                f.MdiParent = this;
                f.Show();
            }
            else
                form.Activate();
        }

        private void sbtn_KhachHang_Click(object sender, EventArgs e)
        {
            Form form = isActive(typeof(KhachHang));
            if (form == null)
            {
                KhachHang f = new KhachHang();
                f.MdiParent = this;
                f.Show();
            }
            else
                form.Activate();
        }
    }
}
