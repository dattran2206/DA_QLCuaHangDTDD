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
    public partial class CTHD : Form
    {
        HoaDonDAL_BLL HD = new HoaDonDAL_BLL();
        MatHangDAL_BLL MH = new MatHangDAL_BLL();
        NhanVienDAL_BLL NV = new NhanVienDAL_BLL();
        KhachHangDAL_BLL KH = new KhachHangDAL_BLL();
        CTHDDAL_BLL CTHD1 = new CTHDDAL_BLL();
        public CTHD()
        {
            InitializeComponent();


        }
        public string MACTHD { set; get; }
        public string MAHD { set; get; }
        public string MAMH { set; get; }
        public string MANV { set; get; }
        public string MAKH { set; get; }
        public string SOLUONG { set; get; }
        public string DONVITINH { set; get; }
        public float THANHTIEN { set; get; }
        public bool THEM { set; get; }
        public bool DEM { set; get; }
        public void tinhthanhtien()
        {
            int giaban = int.Parse(gridView5.GetRowCellValue(gridView5.FocusedRowHandle, "GIABAN").ToString());
            if (!txtsoluong.Text.Equals(""))
            {
                int soluong = int.Parse(txtsoluong.Text);
                int thanhtien = soluong * giaban;
                txtthanhtien.Text = thanhtien.ToString();
            }
            else
                txtthanhtien.ResetText();

        }
        public void loaddata()
        {
            int mq = int.Parse(DangNhap.MAQUYEN);
            //int manv = int.Parse(MANV);
            //luemaHD.Properties.DataSource = HD.LayHoaDon2();

            luemamh.Properties.DataSource = MH.LayMatHang2();
            luemamh.Properties.DisplayMember = "TENMH";
            luemamh.Properties.ValueMember = "MAMH";

            if (mq == 1)
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

            luemakh.Properties.DataSource = KH.LayKhachHang();
            luemakh.Properties.DisplayMember = "HOTEN";
            luemakh.Properties.ValueMember = "MAKH";

            lk_donvitinh.Properties.DataSource = MH.laymathang1();
            lk_donvitinh.Properties.DisplayMember = "lOAIMH";

        }
        private void CTHD_Load(object sender, EventArgs e)
        {
            gridMACTHD.DataSource = CTHD1.LayCTHD2();
            loaddata();
            if (THEM == false)
            {
                txtmacthd.Text = MACTHD;
                txt_mahd.Text = MAHD;
                luemamh.EditValue = MAMH;
                luemanv.EditValue = MANV;
                luemakh.EditValue = MAKH;
                txtsoluong.Text = SOLUONG;
                lk_donvitinh.EditValue = DONVITINH;
                txtthanhtien.Text = THANHTIEN.ToString();
            }
            else
            {

                txtmacthd.Text = int.Parse(gridView6.GetRowCellValue(gridView6.FocusedRowHandle, "MACTHD").ToString()) + 1 + "";
                txt_mahd.Text = MAHD;
                luemanv.SelectedText = MANV;
            }


        }

        private void luemamh_EditValueChanged(object sender, EventArgs e)
        {
                int ma = int.Parse(luemamh.EditValue.ToString());
                gridMatHang.DataSource = MH.LayGiaBan(ma);
                grid_soluong.DataSource = MH.LaySoLuong(ma);
        }
        public bool Check_SL()
        {
            int sl_ton = int.Parse(gridView7.GetRowCellValue(gridView7.FocusedRowHandle, "SOLUONG").ToString());
            int sl_ban = int.Parse(txtsoluong.Text);
            if (sl_ban > sl_ton)
            {
                return false;
            }
            return true;
        }
        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            tinhthanhtien();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (THEM)
            {
                if (luemamh.EditValue.Equals("") || luemanv.EditValue.Equals("") || luemakh.EditValue.Equals("") || lk_donvitinh.EditValue.Equals("") || txtsoluong.Text.Equals("") || txtthanhtien.Text.Equals(""))
                    MessageBox.Show("Bạn Nhập Thiếu Dữ Liệu");
                else if (!Check_SL())
                    MessageBox.Show("Hàng Không Còn Đủ Để Bán!!");
                else
                {
                    try
                    {
                        CTHD1.ThemCTHD(int.Parse(txtmacthd.Text.Trim()), int.Parse(txt_mahd.Text.Trim()), int.Parse(luemamh.EditValue.ToString()), int.Parse(luemanv.EditValue.ToString()),
                                        int.Parse(luemakh.EditValue.ToString()), int.Parse(txtsoluong.Text.Trim()), lk_donvitinh.Text, float.Parse(txtthanhtien.Text.Trim()));
                        MessageBox.Show("Thêm chi tiết hóa đơn mới thành công", "Thông báo");
                        MH.updateSL(int.Parse(luemamh.EditValue.ToString()));
                        DEM = true;
                    }
                    catch
                    {
                        MessageBox.Show("Không thêm được chi tiết hóa đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            if (!THEM)
            {
                try
                {
                    CTHD1.CapNhatCTHD(int.Parse(txtmacthd.Text.Trim()), int.Parse(txt_mahd.Text.Trim()), int.Parse(luemamh.EditValue.ToString()), int.Parse(luemanv.EditValue.ToString()),
                                    int.Parse(luemakh.EditValue.ToString()), int.Parse(txtsoluong.Text.Trim()), lk_donvitinh.Text, float.Parse(txtthanhtien.Text.Trim()));
                    MessageBox.Show("Đã cập nhật chi tiết hóa đơn mới", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Không cập nhật được chi tiết hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            if (DEM == true)
            {
                int DEM2 = int.Parse(txtmacthd.Text) + 1;
                txtmacthd.Text = DEM2.ToString();
                DEM = false;
            }
            lk_donvitinh.ResetText();
            txtsoluong.Text = "0";
            luemakh.ResetText();
            luemanv.ResetText();
            //luemamh.ResetText();
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
