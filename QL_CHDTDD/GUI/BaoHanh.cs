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
    public partial class BaoHanh : Form
    {
        BaoHanhDAL_BLL bh = new BaoHanhDAL_BLL();
        ThongKeDAL_BLL tk = new ThongKeDAL_BLL();
        NhanVienDAL_BLL nv = new NhanVienDAL_BLL();
        MatHangDAL_BLL mh = new MatHangDAL_BLL();
        TimKiemDAL_BLL TK = new TimKiemDAL_BLL();
        public int DEM1 { set; get; }
        public int DEM2 { set; get; }
        public BaoHanh()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            lueMaMHKT.Properties.DataSource = bh.LayMHBH();
            lueMaKH.Properties.DataSource = bh.LayKHBH();
        }
        void LoadDataTTBH()
        {
            try
            {
                gridKT.DataSource = tk.Laythongtinbaohanh();
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void LoadDataTP()
        {
            try
            {
                gridLapphieu.DataSource = bh.LayBaoHanh();
                DEM1 = int.Parse(gridView2.RowCount.ToString());
                if (DEM1 == 0)
                    DEM2 = 1;
                else
                    DEM2 = int.Parse(gridView2.GetRowCellValue(DEM1 - 1, "MABAOHANH").ToString()) + 1;
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BaoHanh_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadDataTTBH();
            LoadDataTP();
        }

        private void lueMaMHKT_EditValueChanged(object sender, EventArgs e)
        {
            if (lueMaMHKT.Text == "Chọn mã mặt hàng")
            {
                if (lueMaKH.Text == "Chọn mã khách hàng")
                    gridKT.DataSource = tk.Laythongtinbaohanh();
                else
                    gridKT.DataSource = TK.TKTTBH_KH(lueMaKH.Text);
            }
            else
            {
                if (lueMaKH.Text == "Chọn mã khách hàng")
                    gridKT.DataSource = TK.TKTTBH_MH(lueMaMHKT.Text);
                else
                    gridKT.DataSource = TK.TKTTBH(lueMaKH.Text, lueMaMHKT.Text);
            }
        }

        private void lueMaKH_EditValueChanged(object sender, EventArgs e)
        {
            if (lueMaKH.Text == "Chọn mã khách hàng")
            {
                if (lueMaMHKT.Text == "Chọn mã mặt hàng")
                    gridKT.DataSource = tk.Laythongtinbaohanh();
                else
                    gridKT.DataSource = TK.TKTTBH_MH(lueMaMHKT.Text);
            }
            else
            {
                if (lueMaMHKT.Text == "Chọn mã mặt hàng")
                    gridKT.DataSource = TK.TKTTBH_KH(lueMaKH.Text);
                else
                    gridKT.DataSource = TK.TKTTBH(lueMaKH.Text, lueMaMHKT.Text);
            }
        }

        private void lueMaMHKT_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                lueMaMHKT.EditValue = null;
                lueMaMHKT.Properties.NullText = "Chọn mã mặt hàng";
            }
        }

        private void lueMaKH_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                lueMaKH.EditValue = null;
                lueMaKH.Properties.NullText = "Chọn mã khách hàng";
            }
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            TreeNode thenode = this.treeView1.SelectedNode;
            if (txtTimkiem.Text == "")
            {
                if (thenode.Text == "Tất cả")
                    LoadDataTP();
                else if (thenode.Text == "Đã trả")
                {
                    bool DATRA = true;
                    gridLapphieu.DataSource = TK.TKBHDT(DATRA);
                }
                else
                {
                    bool DATRA = false;
                    gridLapphieu.DataSource = TK.TKBHDT(DATRA);
                }
            }
            else
            {
                if (thenode.Text == "Tất cả")
                    gridLapphieu.DataSource = TK.TKBH_TENKH(txtTimkiem.Text);
                else if (thenode.Text == "Đã trả")
                {
                    bool DATRA = true;
                    gridLapphieu.DataSource = TK.TKBH(txtTimkiem.Text, DATRA);
                }
                else if (thenode.Text == "Còn nợ")
                {
                    bool DATRA = false;
                    gridLapphieu.DataSource = TK.TKBH(txtTimkiem.Text, DATRA);
                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode thenode = this.treeView1.SelectedNode;
            if (thenode.Text == "Tất cả")
            {
                gridLapphieu.DataSource = bh.LayBaoHanh();
            }
            else if (thenode.Text == "Đã trả")
            {
                if (txtTimkiem.Text == "")
                {
                    bool DATRA = true;
                    gridLapphieu.DataSource = TK.TKBHDT(DATRA);
                }
                else
                {
                    bool DATRA = true;
                    gridLapphieu.DataSource = TK.TKBH(txtTimkiem.Text, DATRA);
                }
            }
            else
            {
                if (txtTimkiem.Text == "")
                {
                    bool DATRA = false;
                    gridLapphieu.DataSource = TK.TKBHDT(DATRA);
                }
                else
                {
                    bool DATRA = false;
                    gridLapphieu.DataSource = TK.TKBH(txtTimkiem.Text, DATRA);
                }
            }
        }

        private void tsbThem_Click(object sender, EventArgs e)
        {
            BaoHanh1 frm = new BaoHanh1();
            frm.THEM = true;
            frm.MABH = DEM2.ToString();
            frm.ShowDialog();
            LoadDataTP();
        }

        private void tsbsua_Click(object sender, EventArgs e)
        {
            BaoHanh1 frm = new BaoHanh1();
            frm.THEM = false;
            if (DEM1 == 0)
            {
                MessageBox.Show("Bạn chưa chọn bao hành để cập nhật thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frm.MABH = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MABAOHANH").ToString();
                if (gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "TENKH") != null)
                {
                    frm.TENKH = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "TENKH").ToString();
                }
                if (gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "NGAYNHAN") != null)
                {
                    frm.NGAYNHAN = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "NGAYNHAN").ToString();
                }
                if (gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "NGAYTRADK") != null)
                {
                    frm.NGAYTRA = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "NGAYTRADK").ToString();
                }
                if (gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "YECAU") != null)
                {
                    frm.YEUCAU = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "YECAU").ToString();
                }
                if (gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "GHICHU") != null)
                {
                    frm.GHICHHU = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "GHICHU").ToString();
                }
                if (gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "DIENTHOAI") != null)
                {
                    frm.DIENTHOAI = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "DIENTHOAI").ToString();
                }
                frm.MAMH = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MAMH").ToString();
                frm.MANV = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MANV").ToString();
                if (gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "DATRA") != null)
                {
                    frm.DATRA = bool.Parse(gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "DATRA").ToString());
                }
                frm.ShowDialog();
            }
            LoadDataTP();
        }

        private void tsbxoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult TRALOI;
                TRALOI = MessageBox.Show("Bạn muốn xóa phiếu bảo hành này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (TRALOI == DialogResult.Yes)
                {
                    string STRMABH = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MABAOHANH").ToString();
                    bh.XoaBaoHanh(int.Parse(STRMABH));
                    LoadDataTP();
                    MessageBox.Show("Phiếu bảo hành đã được xóa", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không xóa phiếu bảo hành này", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được phiếu bảo hành này.", "Lỗi");
            }
        }

        private void tsbIn_Click(object sender, EventArgs e)
        {
            gridLapphieu.ShowRibbonPrintPreview();
        }

        private void tsbref_Click(object sender, EventArgs e)
        {
            LoadDataTP();
            txtTimkiem.ResetText();
        }
    }
}
