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
    public partial class BienLaiTraGop1 : Form
    {
        NhanVienDAL_BLL nv = new NhanVienDAL_BLL();
        BienLaiTraGopDAL_BLL bl = new BienLaiTraGopDAL_BLL();
        public BienLaiTraGop1()
        {
            InitializeComponent();
        }
        public string MABL { set; get; }
        public int MANV { set; get; }
        public string MAKH { set; get; }
        public string SOTIEN { set; get; }
        public string NGAY { set; get; }
        public string GHICHU { set; get; }
        public bool THEM { set; get; }
        public string TienNo { set; get; }
        public void loaddata()
        {
            int mq = int.Parse(DangNhap.MAQUYEN);
            if (mq == 3)
            {
                luemanv.Properties.DataSource = nv.LayNhanVien2(mq);
                luemanv.Properties.DisplayMember = "HOTEN";
                luemanv.Properties.ValueMember = "MANV";
            }
            else
            {
                luemanv.Properties.DataSource = nv.LayNhanVien();
                luemanv.Properties.DisplayMember = "HOTEN";
                luemanv.Properties.ValueMember = "MANV";
            }
            luemakh.Properties.DataSource = bl.LayKhachHangTraGop(int.Parse(MAKH));
            luemakh.Properties.DisplayMember = "HOTEN";
            luemakh.Properties.ValueMember = "MAKH";
        }
        private void BienLaiTraGop1_Load(object sender, EventArgs e)
        {
            loaddata();
            txtmabl.Text = MABL;
            luemanv.Text = MANV.ToString();
            luemakh.EditValue = MAKH;
            txtsotien.Text = SOTIEN;
            dtpngay.Text = NGAY;
            txtghichu.Text = GHICHU;
            //gridTragop.DataSource = TG.LayPhieuTG();

        }
        public bool dem { set; get; }
        private void btnluu_Click(object sender, EventArgs e)
        {
            if (!Checktientra())
                MessageBox.Show("Tiền trả lớn hơn tiền nợ");
            else
            {
                if (THEM)
                {
                    try
                    {
                        bl.ThemBienLaiTraGop(int.Parse(txtmabl.Text.Trim()), int.Parse(luemanv.EditValue.ToString()), DateTime.Parse(dtpngay.Text.Trim()), int.Parse(luemakh.EditValue.ToString()), float.Parse(txtsotien.Text.Trim()), txtghichu.Text.Trim());
                        MessageBox.Show("Thêm biên lai mới thành công", "Thông báo");
                        dem = true;
                    }
                    catch
                    {
                        MessageBox.Show("Không thêm được biên lai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (!THEM)
                {
                    try
                    {
                        bl.CapNhatBienLaiTraGop(int.Parse(txtmabl.Text), int.Parse(luemanv.EditValue.ToString()), DateTime.Parse(dtpngay.Text), int.Parse(luemakh.EditValue.ToString()), float.Parse(txtsotien.Text), txtghichu.Text);
                        MessageBox.Show("Đã cập nhật biên lai mới", "Thông báo");
                    }
                    catch
                    {
                        MessageBox.Show("Không cập nhật được biên lai.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void txtsotien_TextChanged(object sender, EventArgs e)
        {
            if (!Checktientra())
                MessageBox.Show("Tiền trả lớn hơn tiền nợ");
        }
        public bool Checktientra()
        {
            if (!txtsotien.Text.Equals(""))
            {
                int tientra = int.Parse(txtsotien.Text);
                int tienno = int.Parse(TienNo);
                if (tientra > tienno)
                    return false;
            }
            return true;
        }
    }
}
