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
    public partial class NhaCungCap : Form
    {
        NhaCungCapDAL_BLL NCC = new NhaCungCapDAL_BLL();
        TimKiemDAL_BLL TK = new TimKiemDAL_BLL();
        public NhaCungCap()
        {
            InitializeComponent();
        }
        public int DEM1 { set; get; }
        public int DEM2 { set; get; }
        void LoadData()
        {
            try
            {
                gridNhaCC.DataSource = NCC.LayNhaCC();
                DEM1 = int.Parse(gridView1.RowCount.ToString());
                if (DEM1 == 0)
                    DEM2 = 1;
                else
                    DEM2 = int.Parse(gridView1.GetRowCellValue(DEM1 - 1, "MANCC").ToString()) + 1;
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu từ bảng nhà cung cấp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtTenNCC_TextChanged(object sender, EventArgs e)
        {
            if (txtTenNCC.Text == "")
            {
                LoadData();
            }
            else
            {
                gridNhaCC.DataSource = TK.TKnhacungcap(txtTenNCC.Text);
                DEM1 = int.Parse(gridView1.RowCount.ToString());
            }
        }

        private void tsbxoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult TRALOI;
                TRALOI = MessageBox.Show("Bạn muốn xóa nhà cung cấp này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (TRALOI == DialogResult.Yes)
                {
                    string STRMANCC = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MANCC").ToString();
                    NCC.XoaNhaCC(int.Parse(STRMANCC));
                    LoadData();
                    MessageBox.Show("Nhà cung cấp đã được xóa", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không xóa nhà cung cấp này", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được nhà cung cấp này.", "Lỗi");
            }
        }

        private void tsbSua_Click(object sender, EventArgs e)
        {
            NhaCungCap1 frm = new NhaCungCap1();
            frm.THEM = false;
            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MANCC") != null)
                frm.MANCC = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MANCC").ToString();
            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TENNCC") != null)
                frm.TENNCC = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TENNCC").ToString();
            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DIACHI") != null)
                frm.DIACHI = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DIACHI").ToString();
            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SDT") != null)
                frm.SDT = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SDT").ToString();
            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GHICHU") != null)
                frm.GHICHU = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GHICHU").ToString();
            frm.ShowDialog();
            LoadData();
        }

        private void tsbIn_Click(object sender, EventArgs e)
        {
            gridNhaCC.ShowRibbonPrintPreview();
        }

        private void tsbthem_Click(object sender, EventArgs e)
        {
            NhaCungCap1 frm = new NhaCungCap1();
            frm.THEM = true;
            frm.MANCC = DEM2.ToString();
            frm.ShowDialog();
            LoadData();
        }

        private void tsbRef_Click(object sender, EventArgs e)
        {
            LoadData();
            txtTenNCC.ResetText();
        }
    }
}
