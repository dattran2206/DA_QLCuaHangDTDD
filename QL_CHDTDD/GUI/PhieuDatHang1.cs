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
    public partial class PhieuDatHang1 : Form
    {
        PhieuDatHangDAL_BLL PDH = new PhieuDatHangDAL_BLL();
        NhaCungCapDAL_BLL NCC = new NhaCungCapDAL_BLL();
        NhanVienDAL_BLL NV = new NhanVienDAL_BLL();
        MatHangDAL_BLL MH = new MatHangDAL_BLL();
        public PhieuDatHang1()
        {
            InitializeComponent();
        }
        public string MAPDH { set; get; }
        public string MAMH { set; get; }
        public string SOLUONG { set; get; }
        public string GIANHAP { set; get; }
        public string MANCC { set; get; }
        public string MANV { set; get; }
        public string NGAYDH { set; get; }
        public string DATRA { set; get; }
        public string CONNO { set; get; }
        public bool THEM { set; get; }
        public void loaddata()
        {
            int mq = int.Parse(DangNhap.MAQUYEN);
            if (mq == 4)
            {
                luemanv.Properties.DataSource = NV.LayNhanVien2(mq);
                luemanv.Properties.DisplayMember = "HOTEN";
                luemanv.Properties.ValueMember = "MANV";
            }
            else
            {
                luemanv.Properties.DataSource = NV.LayNhanVien();
                luemanv.Properties.DisplayMember = "HOTEN";
                luemanv.Properties.ValueMember = "MANV";
            }
            luemamh.Properties.DataSource = MH.laymathang();
            luemamh.Properties.DisplayMember = "TENMH";
            luemamh.Properties.ValueMember = "MAMH";

            luemancc.Properties.DataSource = NCC.LayNhaCC();
            luemancc.Properties.DisplayMember = "TENNCC";
            luemancc.Properties.ValueMember = "MANCC";


        }
        private void PhieuDatHang1_Load(object sender, EventArgs e)
        {
            txtmapdh.Text = MAPDH;
            luemamh.EditValue = MAMH;
            luemancc.EditValue = MANCC;
            luemanv.EditValue = MANV;
            txtsoluong.Text = SOLUONG;
            dtpngaydh.Text = NGAYDH;
            txtdatra.Text = DATRA;
            txtconno.Text = CONNO;
            txtgianhap.Text = GIANHAP;
            loaddata();
        }
        public bool DEM { set; get; }
        private void bntluu_Click(object sender, EventArgs e)
        {
            if (THEM)
            {
                if (luemamh.EditValue.Equals("") || luemancc.EditValue.Equals("") || luemanv.EditValue.Equals("") || txtsoluong.Text.Equals("") || txtdatra.Text.Equals(""))
                    MessageBox.Show("Bạn nhập Thiếu Dữ Liệu");
                else
                {
                    try
                    {
                        PDH.ThemPhieuDH(int.Parse(txtmapdh.Text.Trim()), int.Parse(luemamh.EditValue.ToString()), int.Parse(luemancc.EditValue.ToString()), int.Parse(luemanv.EditValue.ToString()),
                                        int.Parse(txtsoluong.Text.Trim()), float.Parse(txtgianhap.Text.Trim()), DateTime.Parse(dtpngaydh.Text.Trim()),
                                        double.Parse(txtdatra.Text.Trim()), double.Parse(txtconno.Text.Trim()));
                        MessageBox.Show("Thêm phiếu đặt hàng mới thành công", "Thông báo");
                        DEM = true;
                    }
                    catch
                    {
                        MessageBox.Show("Không thêm được phiếu đặt hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            if (!THEM)
            {
                try
                {
                    PDH.CapNhatPhieuDH(int.Parse(txtmapdh.Text), int.Parse(luemamh.EditValue.ToString()), int.Parse(luemancc.EditValue.ToString()), int.Parse(luemanv.EditValue.ToString()),
                                    int.Parse(txtsoluong.Text), float.Parse(txtgianhap.Text), DateTime.Parse(dtpngaydh.Text), double.Parse(txtdatra.Text), double.Parse(txtconno.Text));
                    MessageBox.Show("Đã cập nhật phiếu đặt hàng mới", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Không cập nhật được phiếu đặt hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void luemamh_EditValueChanged(object sender, EventArgs e)
        {
            int mamh = int.Parse(luemamh.EditValue.ToString());
            gridGiaBan.DataSource = MH.LayGiaBan(mamh);
        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            int giaban = int.Parse(gridView3.GetRowCellValue(gridView3.FocusedRowHandle, "GIABAN").ToString());
            if (!txtsoluong.Text.Equals(""))
            {
                int soluong = int.Parse(txtsoluong.Text);
                int gianhap = giaban * soluong;
                txtgianhap.Text = gianhap.ToString();
            }
            else
                txtgianhap.ResetText();
        }

        private void txtdatra_TextChanged(object sender, EventArgs e)
        {
            int gianhap = int.Parse(txtgianhap.Text);

            if (!txtdatra.Text.Equals(""))
            {
                int datra = int.Parse(txtdatra.Text);
                int conno = gianhap - datra;
                if(gianhap<datra)
                {
                    txtconno.ResetText();
                }
                else
                txtconno.Text = conno.ToString();
            }
            else
                txtconno.ResetText();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (DEM == true)
            {
                int DEM2 = int.Parse(txtmapdh.Text) + 1;
                txtmapdh.Text = DEM2.ToString();
                DEM = false;
            }
            //txtconno.ResetText();
            txtdatra.ResetText();
            //txtgianhap.ResetText();
            txtsoluong.ResetText();
            luemamh.Focus();
            luemancc.ResetText();
            luemanv.ResetText();
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
