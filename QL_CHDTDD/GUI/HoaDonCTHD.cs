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
    public partial class HoaDonCTHD : Form
    {
        HoaDonDAL_BLL HD = new HoaDonDAL_BLL();
        CTHDDAL_BLL CTHD = new CTHDDAL_BLL();
        KhachHangDAL_BLL KH = new KhachHangDAL_BLL();
        public int DEMHD1 { set; get; }
        public int DEMHD2 { set; get; }
        public int DEMCTHD1 { set; get; }
        public int DEMCTHD2 { set; get; }
        public int MAHD { set; get; }
        public int MANV { set; get; }
        public int index { set; get; }
        public HoaDonCTHD()
        {
            InitializeComponent();
        }
        public void LoadHD()//load hóa đơn
        {
            try
            {
                gridHD.DataSource = HD.LayHoaDon1();
                DEMHD1 = int.Parse(gvhoadon.RowCount.ToString());
                if (DEMHD1 == 0)
                    DEMHD2 = 1;
                else
                    DEMHD2 = int.Parse(gvhoadon.GetRowCellValue(DEMHD1 - 1, "MAHD").ToString()) + 1;
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadCTHD()//load chi tiết hóa đơn
        {
            try
            {

                gridCTHD.DataSource = CTHD.LayCTHD();
                DEMCTHD1 = int.Parse(gvchitiethoadon.RowCount.ToString());
                if (DEMCTHD1 == 0)
                    DEMCTHD2 = 1;
                else
                    DEMCTHD2 = int.Parse(gvchitiethoadon.GetRowCellValue(DEMCTHD1 - 1, "MACTHD").ToString()) + 1;
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DEMDONG()
        {
            DEMCTHD1 = int.Parse(gvchitiethoadon.RowCount.ToString());
            if (DEMCTHD1 == 0)
                DEMCTHD2 = 1;
            else
                DEMCTHD2 = int.Parse(gvchitiethoadon.GetRowCellValue(DEMCTHD1 - 1, "MACTHD").ToString()) + 1;
        }
        public void LoadCTHD_MAHD()//load chi tiết hóa đơn theo mã
        {
            int mahd = int.Parse(gvhoadon.GetRowCellValue(gvhoadon.FocusedRowHandle, ("MAHD")).ToString());
            try
            {
                gridCTHD.DataSource = CTHD.LayCTHD1(mahd);
                DEMDONG();
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadCTHD_MAHD1()//load chi tiết hóa đơn theo mã
        {
            int mahd = int.Parse(gvhoadon.GetRowCellValue(gvhoadon.FocusedRowHandle, ("MAHD")).ToString());
            try
            {
                gridControl1.DataSource = CTHD.LayCTHD2(mahd);
                DEMDONG();
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void HoaDonCTHD_Load(object sender, EventArgs e)
        {
            LoadHD();
            DEMDONG();
            repositoryItemLookUpEdit1.DataSource = KH.LayKhachHang();
            repositoryItemLookUpEdit1.DisplayMember = "HOTEN";
            repositoryItemLookUpEdit1.ValueMember = "MAKH";
            //LoadCTHD_MAHD();
            //repositoryItemLookUpEdit4.DataSource = KH.LayKhachHang();
            //repositoryItemLookUpEdit4.DisplayMember = "HOTEN";
            //repositoryItemLookUpEdit4.ValueMember = "MAKH";

        }

        private void tsbthemHD_Click(object sender, EventArgs e)
        {
            HoaDon frm = new HoaDon();
            frm.THEM = true;
            frm.MAHD = DEMHD2.ToString();
            frm.SOLUONG = 0;
            frm.TONGTIEN = 0;
            frm.ShowDialog();
            LoadHD();
        }

        private void gvhoadon_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

            LoadCTHD_MAHD();
            LoadCTHD_MAHD1();
            repositoryItemLookUpEdit4.DataSource = KH.LayKhachHang();
            repositoryItemLookUpEdit4.DisplayMember = "HOTEN";
            repositoryItemLookUpEdit4.ValueMember = "MAKH";      
        }

        private void tsbsuaHD_Click(object sender, EventArgs e)
        {
            HoaDon frm = new HoaDon();
            frm.THEM = false;
            if (gvhoadon.GetRowCellValue(gvhoadon.FocusedRowHandle, "MAHD") != null)
                frm.MAHD = gvhoadon.GetRowCellValue(gvhoadon.FocusedRowHandle, "MAHD").ToString();
            if (gvhoadon.GetRowCellValue(gvhoadon.FocusedRowHandle, "SOLUONG") != null)
                frm.SOLUONG = int.Parse(gvhoadon.GetRowCellValue(gvhoadon.FocusedRowHandle, "SOLUONG").ToString());
            if (gvhoadon.GetRowCellValue(gvhoadon.FocusedRowHandle, "MAKH") != null)
                frm.MAKH = gvhoadon.GetRowCellValue(gvhoadon.FocusedRowHandle, "MAKH").ToString();
            if (gvhoadon.GetRowCellValue(gvhoadon.FocusedRowHandle, "NGAYLAP") != null)
                frm.NGAYLAP = gvhoadon.GetRowCellValue(gvhoadon.FocusedRowHandle, "NGAYLAP").ToString();
            if (gvhoadon.GetRowCellValue(gvhoadon.FocusedRowHandle, "MANV") != null)
                frm.MANV = gvhoadon.GetRowCellValue(gvhoadon.FocusedRowHandle, "MANV").ToString();
            if (gvhoadon.GetRowCellValue(gvhoadon.FocusedRowHandle, "TONGTIEN") != null)
                frm.TONGTIEN = float.Parse(gvhoadon.GetRowCellValue(gvhoadon.FocusedRowHandle, "TONGTIEN").ToString());
            frm.ShowDialog();
            LoadHD();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int mahd = int.Parse(gvhoadon.GetRowCellValue(gvhoadon.FocusedRowHandle, "MAHD").ToString());
            CTHD frm = new CTHD();
            frm.THEM = true;
            frm.MAHD = mahd.ToString();
            frm.MANV = MANV.ToString();
            frm.ShowDialog();
            LoadCTHD_MAHD();
        }

        private void tsbCapNhatSL_TT_Click(object sender, EventArgs e)
        {
            int mahd = int.Parse(gvhoadon.GetRowCellValue(gvhoadon.FocusedRowHandle, "MAHD").ToString());
            try
            {
                HD.CapNhatHoaDon1(mahd);
                MessageBox.Show("Đã Cập Nhật Thành Công Số Lượng Và Tổng Tiền");
                LoadHD();
            }
            catch
            {
                MessageBox.Show("Chưa Cập Nhật Số Lượng Và Tổng Tiền");
            }
        }

        private void tsbxoaHD_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult TRALOI;
                TRALOI = MessageBox.Show("Bạn muốn xóa hóa đơn này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (TRALOI == DialogResult.Yes)
                {
                    string STRMAHD = gvhoadon.GetRowCellValue(gvhoadon.FocusedRowHandle, "MAHD").ToString();
                    CTHD.XoaCTHD_MAHD(int.Parse(STRMAHD));
                    LoadCTHD_MAHD();
                    HD.XoaHoaDon(int.Parse(STRMAHD));
                    LoadHD();
                    MessageBox.Show("Hóa đơn đã được xóa", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không xóa hóa đơn này", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được hóa đơn này.", "Lỗi");
            }
        }

        private void sbtn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult TRALOI;
                TRALOI = MessageBox.Show("Bạn muốn xóa chi tiết hóa đơn này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (TRALOI == DialogResult.Yes)
                {
                    string STRMACTHD = gvchitiethoadon.GetRowCellValue(gvchitiethoadon.FocusedRowHandle, "MACTHD").ToString();
                    CTHD.XoaCTHD(int.Parse(STRMACTHD));
                    LoadCTHD_MAHD();
                    MessageBox.Show("Chi tiết hóa đơn đã được xóa", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không xóa chi tiết hóa đơn này", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được chi tiết hóa đơn này.", "Lỗi");
            }
        }

        private void sbtn_sua_Click(object sender, EventArgs e)
        {
            CTHD frm = new CTHD();
            frm.THEM = false;
            if (gridView1.GetRowCellValue(index, "MACTHD") != null)
                frm.MACTHD = gridView1.GetRowCellValue(index, "MACTHD").ToString();
            if (gridView1.GetRowCellValue(index, "MAHD") != null)
                frm.MAHD = gridView1.GetRowCellValue(index, "MAHD").ToString();
            if (gridView1.GetRowCellValue(index, "MAMH") != null)
                frm.MAMH = gridView1.GetRowCellValue(index, "MAMH").ToString();
            if (gridView1.GetRowCellValue(index, "MANV") != null)
                frm.MANV = gridView1.GetRowCellValue(index, "MANV").ToString();
            if (gridView1.GetRowCellValue(index, "SOLUONG") != null)
                frm.SOLUONG = gridView1.GetRowCellValue(index, "SOLUONG").ToString();
            if (gridView1.GetRowCellValue(index, "THANHTIEN") != null)
                frm.THANHTIEN = float.Parse(gridView1.GetRowCellValue(index, "THANHTIEN").ToString());
            if (gridView1.GetRowCellValue(index, "DONVITINH") != null)
                frm.DONVITINH = gridView1.GetRowCellValue(index, "DONVITINH").ToString();
            if (gridView1.GetRowCellValue(index, "MAKH") != null)
                frm.MAKH = gridView1.GetRowCellValue(index, "MAKH").ToString();
            frm.ShowDialog();
            LoadCTHD_MAHD();
        }

        private void tsbrefHD_Click(object sender, EventArgs e)
        {
            LoadHD();
        }

        private void sbtn_refresh_Click(object sender, EventArgs e)
        {
            LoadCTHD_MAHD();
        }

        private void gvchitiethoadon_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
             index = gvchitiethoadon.FocusedRowHandle;

        }

        private void tsbinHD_Click(object sender, EventArgs e)
        {
            gvhoadon.ShowRibbonPrintPreview();
        }

        private void sbtn_in_Click(object sender, EventArgs e)
        {
            gvchitiethoadon.ShowRibbonPrintPreview();
        }
    }
}
