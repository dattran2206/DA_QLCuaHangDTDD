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
    public partial class BienLaiTraGop : Form
    {
        KhachHangDAL_BLL Kh = new KhachHangDAL_BLL();
        BienLaiTraGopDAL_BLL bl = new BienLaiTraGopDAL_BLL();
        PhieuTraGopDAL_BLL ptg = new PhieuTraGopDAL_BLL();
        public BienLaiTraGop()
        {
            InitializeComponent();
        }
        public int DEMBL1 { set; get; }
        public int DEMBL2 { set; get; }
        public int DEMTG1 { set; get; }
        public int DEMTG2 { set; get; }
        public int c { set; get; }
        public int c1 { set; get; }
        int c2 = 0;
        void Tongtien()
        {
            c = 0;
            c = c + int.Parse(gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "TONGTIEN").ToString());
            lbltongtien.Text = c.ToString();
            int c2 = c - c1;
            lblconno.Text = c2.ToString();
        }
        void Datra()
        {
            int b1 = int.Parse(gvBienlai.RowCount.ToString());
            c1 = 0;
            for (int i = 0; i < b1; i++)
            {
                c1 = c1 + int.Parse(gvBienlai.GetRowCellValue(i, "SOTIEN").ToString());
            }
            lbldatra.Text = c1.ToString();
            c2 = c - c1;
            lblconno.Text = c2.ToString();
        }
        void LoadDataphieu()
        {
            try
            {
                gridphieu.DataSource = ptg.LayPhieuTG();
                repositoryItemLookUpEdit4.DataSource = Kh.LayKhachHang();
                repositoryItemLookUpEdit4.DisplayMember = "HOTEN";
                repositoryItemLookUpEdit4.ValueMember = "MAKH";
                DEMTG1 = int.Parse(gvPhieutragop.RowCount.ToString());
                if (DEMTG1 == 0)
                    DEMTG2 = 1;
                else
                {
                    DEMTG2 = int.Parse(gvPhieutragop.GetRowCellValue(DEMTG1 - 1, "MAPTG").ToString()) + 1;
                }
                Tongtien();
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void LoadDatabienlai()
        {
            try
            {
                grid_phieubienlai.DataSource = bl.LayBienLaiTraGop();
                DEMBL1 = int.Parse(gridView1.RowCount.ToString());
                repositoryItemLookUpEdit1.DataSource = Kh.LayKhachHang();
                repositoryItemLookUpEdit1.DisplayMember = "HOTEN";
                repositoryItemLookUpEdit1.ValueMember = "MAKH";
                if (DEMBL1 == 0)
                    DEMBL2 = 1;
                else
                {
                    DEMBL2 = int.Parse(gridView1.GetRowCellValue(DEMBL1 - 1, "MABL").ToString()) + 1;
                }
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void LoadDatabienlaiTheoMaKH()
        {
            int makh = int.Parse(gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "MAKH").ToString());
            try
            {
                gridbienlai.DataSource = bl.LayBienLaiTheoMakh(makh);
                DEMBL1 = int.Parse(gvBienlai.RowCount.ToString());
                repositoryItemLookUpEdit1.DataSource = Kh.LayKhachHang();
                repositoryItemLookUpEdit1.DisplayMember = "HOTEN";
                repositoryItemLookUpEdit1.ValueMember = "MAKH";
                Datra();
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void BienLaiTraGop_Load(object sender, EventArgs e)
        {
            LoadDataphieu();
            LoadDatabienlai();
            
        }

        private void tsbthem_Click(object sender, EventArgs e)
        {
            PhieuTraGop1 frm = new PhieuTraGop1();
            frm.THEM = true;
            frm.MAPTG = DEMTG2.ToString();
            frm.LAISUAT = "0";
            frm.ShowDialog();
            LoadDataphieu();
        }

        private void gvPhieutragop_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

            LoadDatabienlaiTheoMaKH();
            Tongtien();

        }

        private void tsbthem1_Click(object sender, EventArgs e)
        {
            int makh = int.Parse(gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "MAKH").ToString());
            BienLaiTraGop1 frm = new BienLaiTraGop1();
            frm.THEM = true;
            frm.MABL = DEMBL2.ToString();
            frm.MAKH = makh.ToString();
            frm.TienNo = lblconno.Text;
            frm.ShowDialog();
            LoadDatabienlaiTheoMaKH();
        }

        private void tsbxoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult TRALOI;
                TRALOI = MessageBox.Show("Bạn muốn xóa phiếu trả góp này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (TRALOI == DialogResult.Yes)
                {
                    if (int.Parse(lblconno.Text) == 0)
                    {
                        int makh = int.Parse(gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "MAKH").ToString());
                        bl.XoaBienLai_Makh(makh);
                        LoadDatabienlaiTheoMaKH();
                        string STRMAPTG = gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "MAPTG").ToString();
                        ptg.XoaPhieuTG(int.Parse(STRMAPTG));
                        LoadDataphieu();
                        MessageBox.Show("Phiếu trả góp đã được xóa", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("phiếu trả góp còn tiền nợ không thể xóa");
                    }

                }
                else
                {
                    MessageBox.Show("Không xóa phiếu trả góp này", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được phiếu trả góp này.", "Lỗi");
            }
        }

        private void tsbsua_Click(object sender, EventArgs e)
        {
            PhieuTraGop1 frm = new PhieuTraGop1();
            frm.THEM = false;
            if (DEMTG1 == 0)
            {
                MessageBox.Show("Bạn chưa chọn phiếu trả góp để cập nhật thông tin mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "MAPTG") != null)
                    frm.MAPTG = gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "MAPTG").ToString();
                if (gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "MANV") != null)
                    frm.MANV = gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "MANV").ToString();
                if (gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "MAKH") != null)
                    frm.MAKH = gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "MAKH").ToString();
                if (gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "MAMH") != null)
                    frm.MAMH = gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "MAMH").ToString();
                if (gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "CMND") != null)
                    frm.CMND = gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "CMND").ToString();
                if (gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "NGAYLAP") != null)
                    frm.NGAYLAP = gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "NGAYLAP").ToString();
                if (gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "TONGTIEN") != null)
                    frm.TONGTIEN = gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "TONGTIEN").ToString();
                if (gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "LAISUAT") != null)
                    frm.LAISUAT = gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "LAISUAT").ToString();
                if (gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "HANTRA") != null)
                    frm.HANTRA = gvPhieutragop.GetRowCellValue(gvPhieutragop.FocusedRowHandle, "HANTRA").ToString();
                frm.ShowDialog();
            }
            LoadDataphieu();
        }

        private void tsbxoa1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult TRALOI;
                TRALOI = MessageBox.Show("Bạn muốn xóa biên lai này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (TRALOI == DialogResult.Yes)
                {
                    string STRMABL = gvBienlai.GetRowCellValue(gvBienlai.FocusedRowHandle, "MABL").ToString();
                    bl.XoaBienLaiTraGop(int.Parse(STRMABL));
                    LoadDatabienlai();
                    MessageBox.Show("Biên lai đã được xóa", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không xóa Biên lai này", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được biên lai này.", "Lỗi");
            }
            LoadDatabienlaiTheoMaKH();
        }

        private void tsbsua1_Click(object sender, EventArgs e)
        {
            BienLaiTraGop1 frm = new BienLaiTraGop1();
            frm.TienNo = lblconno.Text;
            frm.THEM = false;
            if (DEMBL1 == 0)
            {
                MessageBox.Show("Bạn chưa chọn Biên lai để cập nhật thông tin mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (gvBienlai.GetRowCellValue(gvBienlai.FocusedRowHandle, "MABL") != null)
                    frm.MABL = gvBienlai.GetRowCellValue(gvBienlai.FocusedRowHandle, "MABL").ToString();
                if (gvBienlai.GetRowCellValue(gvBienlai.FocusedRowHandle, "MANV") != null)
                    frm.MANV = int.Parse(gvBienlai.GetRowCellValue(gvBienlai.FocusedRowHandle, "MANV").ToString());
                if (gvBienlai.GetRowCellValue(gvBienlai.FocusedRowHandle, "NGAYLAP") != null)
                    frm.NGAY = gvBienlai.GetRowCellValue(gvBienlai.FocusedRowHandle, "NGAYLAP").ToString();
                if (gvBienlai.GetRowCellValue(gvBienlai.FocusedRowHandle, "MAKH") != null)
                    frm.MAKH = gvBienlai.GetRowCellValue(gvBienlai.FocusedRowHandle, "MAKH").ToString();
                if (gvBienlai.GetRowCellValue(gvBienlai.FocusedRowHandle, "SOTIEN") != null)
                    frm.SOTIEN = gvBienlai.GetRowCellValue(gvBienlai.FocusedRowHandle, "SOTIEN").ToString();
                if (gvBienlai.GetRowCellValue(gvBienlai.FocusedRowHandle, "GHICHU") != null)
                    frm.GHICHU = gvBienlai.GetRowCellValue(gvBienlai.FocusedRowHandle, "GHICHU").ToString();
                frm.ShowDialog();
            }
            LoadDatabienlaiTheoMaKH();
        }

        private void tsbintragop_Click(object sender, EventArgs e)
        {
            gridphieu.ShowRibbonPrintPreview();
        }

        private void tsbinBienlai_Click(object sender, EventArgs e)
        {
            gridbienlai.ShowRibbonPrintPreview();
        }

        private void tsbref_Click(object sender, EventArgs e)
        {
            LoadDataphieu();
        }

        private void tsbref1_Click(object sender, EventArgs e)
        {
            LoadDatabienlaiTheoMaKH();
        }
    }
}
