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
    public partial class KhachHang : Form
    {
        KhachHangDAL_BLL KH = new KhachHangDAL_BLL();
        TimKiemDAL_BLL TK = new TimKiemDAL_BLL();
        public KhachHang()
        {
            InitializeComponent();
        }
        public int DEM1 { set; get; }
        public int DEM2 { set; get; }
        void DemDong()
        {
            DEM1 = int.Parse(gridView1.RowCount.ToString());
            if (DEM1 == 0)
                DEM2 = 1;
            else
                DEM2 = int.Parse(gridView1.GetRowCellValue(DEM1 - 1, "MAKH").ToString()) + 1;
        }
        void LoadData()
        {
            try
            {
                gridKH.DataSource =KH.LayKhachHang();
                DemDong();
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu từ cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void KhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            TreeNode thenode = this.trvtimkiem.SelectedNode;
            if (txtTimkiem.Text == "")
            {
                if (thenode.Text == "Trả góp")
                    gridKH.DataSource = TK.TKkhachhang_tenkhtragop(txtTimkiem.Text);
                else if (thenode.Text == "Tất cả")
                    LoadData();
                else
                    gridKH.DataSource = TK.TKkhachhang_tenkhkhongtragop(txtTimkiem.Text);
            }
            else
            {
                if (thenode.Text == "Tất cả")
                    gridKH.DataSource = TK.TKkhachhang_tenkh(txtTimkiem.Text);
                else if (thenode.Text == "Trả góp")
                    gridKH.DataSource = TK.TKkhachhang_tenkhtragop(txtTimkiem.Text);
                else
                    gridKH.DataSource = TK.TKkhachhang_tenkhkhongtragop(txtTimkiem.Text);
            }
            //DemDong();
        }

        private void trvtimkiem_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode thenode = this.trvtimkiem.SelectedNode;
            if (thenode.Text == "Tất cả")
            {
                gridKH.DataSource = KH.LayKhachHang();
            }
            else if (thenode.Text == "Trả góp")
            {
                gridKH.DataSource = TK.TKkhachhang_tenkhtragop(txtTimkiem.Text);
            }
            else
            {
                gridKH.DataSource = TK.TKkhachhang_tenkhkhongtragop(txtTimkiem.Text);
            }
            //DemDong();
        }

        private void tsbthem_Click(object sender, EventArgs e)
        {
            KhachHang1 frm = new KhachHang1();
            frm.THEM = true;
            frm.MAKH = DEM2.ToString();
            frm.ShowDialog();
            LoadData();
        }

        private void tsbxoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult TRALOI;
                TRALOI = MessageBox.Show("Bạn muốn xóa khách hàng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (TRALOI == DialogResult.Yes)
                {
                    string STRMAKH = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAKH").ToString();
                    KH.XoaKhachHang(int.Parse(STRMAKH));
                    LoadData();
                    MessageBox.Show("Khách hàng đã được xóa", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không xóa khách hàng này", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được khách hàng này.", "Lỗi");
            }
        }

        private void tsbref_Click(object sender, EventArgs e)
        {
            LoadData();
            txtTimkiem.ResetText();
        }

        private void tsbsua_Click(object sender, EventArgs e)
        {
            KhachHang1 frm = new KhachHang1();
            frm.THEM = false;
            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAKH") != null)
                frm.MAKH = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAKH").ToString();
            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HOTEN") != null)
                frm.TENKH = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HOTEN").ToString();
            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DIACHI") != null)
                frm.DIACHI = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DIACHI").ToString();
            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GIOITINH") != null)
                frm.GIOITINH = bool.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GIOITINH").ToString());
            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SDT") != null)
                frm.SDT = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SDT").ToString();
            frm.ShowDialog();
            LoadData();
        }

        private void tsbin_Click(object sender, EventArgs e)
        {
            gridKH.ShowRibbonPrintPreview();
        }
    }
}
