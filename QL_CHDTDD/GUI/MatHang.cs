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
    public partial class MatHang : Form
    {
        public MatHang()
        {
            InitializeComponent();
        }
        MatHangDAL_BLL MH = new MatHangDAL_BLL();
        TimKiemDAL_BLL TK = new TimKiemDAL_BLL();
        public string QUYEN { set; get; }
        public int DEM1 { set; get; }
        public int DEM2 { set; get; }
        void DEMDONG()
        {
            DEM1 = int.Parse(gridView1.RowCount.ToString());
            if (DEM1 == 0)
                DEM2 = 1;
            else
                DEM2 = int.Parse(gridView1.GetRowCellValue(DEM1 - 1, "MAMH").ToString()) + 1;
        }
        public void loadMatHang()
        {
            try
            {
                gridMatHang.DataSource = MH.laymathang();
                DEMDONG();
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu từ bảng mặt hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void LoadLoaiMatHang()
        {
            gridLoaiMH.DataSource = MH.laymathang1();
            int b = int.Parse(gridView2.RowCount.ToString());
            trvTimkiem.Nodes.Add("Tất cả");
            for (int i = 0; i < b; i++)
            {
                trvTimkiem.Nodes.Add(gridView2.GetRowCellValue(i, "lOAIMH").ToString());
            }
        }
        private void MatHang_Load(object sender, EventArgs e)
        {
            loadMatHang();
            LoadLoaiMatHang();
            if (QUYEN == "1" || QUYEN == "3")
            {
                tsbin.Visible = false;
                tsbthem.Visible = false;
                tsbxoa.Visible = false;
                tsbsua.Visible = false;
                toolStripSeparator2.Visible = false;
                toolStripSeparator1.Visible = false;
            }
        }

        private void trvTimkiem_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode thenode = this.trvTimkiem.SelectedNode;
            if (thenode.Text == "Tất cả")
            {
                loadMatHang();
            }
            else
            {
                if (txtTimkiem.Text == "")
                    gridMatHang.DataSource = TK.TKmaThangLoaiMH(thenode.Text);
                else
                    gridMatHang.DataSource = TK.TKmaThang(txtTimkiem.Text, thenode.Text);
            }
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            TreeNode thenode = this.trvTimkiem.SelectedNode;
            if (txtTimkiem.Text == "")
            {
                if (thenode.Text == "Tất cả")
                    loadMatHang();
                else
                    gridMatHang.DataSource = TK.TKmaThangLoaiMH(thenode.Text);
            }
            else
            {
                if (thenode.Text == "Tất cả")
                    gridMatHang.DataSource = TK.TKmaThang_TenMH(txtTimkiem.Text);
                else
                    gridMatHang.DataSource = TK.TKmaThang(txtTimkiem.Text, thenode.Text);
            }
        }

        private void tsbin_Click(object sender, EventArgs e)
        {
            gridMatHang.ShowRibbonPrintPreview();
        }

        private void tsbref_Click(object sender, EventArgs e)
        {
            loadMatHang();
        }

        private void tsbthem_Click(object sender, EventArgs e)
        {
            MatHang1 f = new MatHang1();
            f.THEM = true;
            f.MAMH = DEM2.ToString();
            f.SOLUONG = "0";
            f.ShowDialog();
        }

        private void tsbsua_Click(object sender, EventArgs e)
        {
            MatHang1 frm = new MatHang1();
            frm.THEM = false;
            if (DEM1 == 0)
            {
                MessageBox.Show("Bạn chưa chọn mặt hàng để cập nhật thông tin mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, ("MAMH")) != null)
                    frm.MAMH = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, ("MAMH")).ToString();
                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, ("SOLUONG")) != null)
                    frm.SOLUONG = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, ("SOLUONG")).ToString();
                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, ("DONVITINH")) != null)
                    frm.DONVITINH = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, ("DONVITINH")).ToString();
                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, ("TENMH")) != null)
                    frm.TENMH = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, ("TENMH")).ToString();
                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, ("HANGSX")) != null)
                    frm.HANGSX = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, ("HANGSX")).ToString();
                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, ("MAKM")) != null)
                    frm.KHUYENMAI = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, ("MAKM")).ToString();
                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, ("DACDIEM")) != null)
                    frm.DACDIEM = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, ("DACDIEM")).ToString();
                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, ("GIAMUA")) != null)
                    frm.GIAMUA = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, ("GIAMUA")).ToString();
                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, ("GIABAN")) != null)
                    frm.GIABAN = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, ("GIABAN")).ToString();
                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, ("LOAIMH")) != null)
                    frm.LOAIMH = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, ("LOAIMH")).ToString();
                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, ("GHICHU")) != null)
                    frm.GHICHU = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, ("GHICHU")).ToString();
                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, ("BAOHANH")) != null)
                    frm.BAOHANH = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, ("BAOHANH")).ToString());

                //MessageBox.Show(frm.LOAIMH);
                frm.ShowDialog();
            }
            loadMatHang();
        }

        private void tsbxoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult TRALOI;
                TRALOI = MessageBox.Show("Bạn muốn xóa mặt hàng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (TRALOI == DialogResult.Yes)
                {

                    string strMAMH = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAMH").ToString();
                    MH.XoaKhuyenMai(int.Parse(strMAMH));
                    loadMatHang();
                    MessageBox.Show("Mặt hàng đã được xóa", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không xóa mặt hàng này", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được mặt hàng này.", "Lỗi");
            }
        }
    }
}
