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
    public partial class BaoHanh1 : Form
    {
        BaoHanhDAL_BLL bh = new BaoHanhDAL_BLL();
        NhanVienDAL_BLL NV = new NhanVienDAL_BLL();
        MatHangDAL_BLL mh = new MatHangDAL_BLL();
        public BaoHanh1()
        {
            InitializeComponent();
        }
        public string MABH { set; get; }
        public string TENKH { set; get; }
        public string NGAYNHAN { set; get; }
        public string NGAYTRA { set; get; }
        public string DIENTHOAI { set; get; }
        public string MAMH { set; get; }
        public string MANV { set; get; }
        public string YEUCAU { set; get; }
        public string GHICHHU { set; get; }
        public bool DATRA { set; get; }
        public bool THEM { set; get; }
        private void BaoHanh1_Load(object sender, EventArgs e)
        {
            loadata();
            txtmabh.Text = MABH;
            txttenbh.Text = TENKH;
            txtdienthoai.Text = DIENTHOAI;
            txtyeucau.Text = YEUCAU;
            txtghichu.Text = GHICHHU;
            dtpngaynhan.Text = NGAYNHAN;
            dtpngaytra.Text = NGAYTRA;
            luemathang.EditValue = MAMH;
            luenhanvien.EditValue = MANV;
            chkdatra.Checked = DATRA;
        }
        public void loadata()
        {
            int mq = int.Parse(DangNhap.MAQUYEN);
            if (mq == 2)
            {
                luenhanvien.Properties.DataSource = NV.LayNhanVien2(mq);
                luenhanvien.Properties.DisplayMember = "HOTEN";
                luenhanvien.Properties.ValueMember = "MANV";
            }
            else
            {
                luenhanvien.Properties.DataSource = NV.LayNhanVien();
                luenhanvien.Properties.DisplayMember = "HOTEN";
                luenhanvien.Properties.ValueMember = "MANV";
            }
            luemathang.Properties.DataSource =mh.laymathang();
            luemathang.Properties.DisplayMember = "TENMH";
            luemathang.Properties.ValueMember = "MAMH";
        }
        public bool dem { set; get; }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (THEM)
            {
                try
                {
                    if (txtdienthoai.Text != "")
                    {
                        bh.ThemBaoHanh(int.Parse(txtmabh.Text.Trim()), DateTime.Parse(dtpngaynhan.Text.Trim()), txttenbh.Text.Trim(), txtdienthoai.Text.Trim(), int.Parse(luemathang.EditValue.ToString()),
                                       int.Parse(luenhanvien.EditValue.ToString()), txtyeucau.Text.Trim(), DateTime.Parse(dtpngaytra.Text.Trim()), txtghichu.Text.Trim(), chkdatra.Checked);
                        MessageBox.Show("Thêm phiếu bảo hành mới thành công", "Thông báo");
                        dem = true;
                    }
                    else
                    {
                        bh.ThemBaoHanh(int.Parse(txtmabh.Text.Trim()), DateTime.Parse(dtpngaynhan.Text.Trim()), txttenbh.Text.Trim(), null, int.Parse(luemathang.EditValue.ToString()),
                                       int.Parse(luenhanvien.EditValue.ToString()), txtyeucau.Text.Trim(), DateTime.Parse(dtpngaytra.Text.Trim()), txtghichu.Text.Trim(), chkdatra.Checked);
                        MessageBox.Show("Thêm phiếu bảo hành mới thành công", "Thông báo");
                        dem = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Không thêm được phiếu bảo hành", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (!THEM)
            {
                try
                {
                    if (txtdienthoai.Text != "")
                    {
                        bh.CapNhatBaoHanh(int.Parse(txtmabh.Text), DateTime.Parse(dtpngaynhan.Text), txttenbh.Text, txtdienthoai.Text, int.Parse(luemathang.EditValue.ToString()),
                                       int.Parse(luenhanvien.EditValue.ToString()), txtyeucau.Text, DateTime.Parse(dtpngaytra.Text), txtghichu.Text, chkdatra.Checked);
                        MessageBox.Show("Đã cập nhật phiếu bảo hành mới", "Thông báo");
                    }
                    else
                    {
                        bh.CapNhatBaoHanh(int.Parse(txtmabh.Text), DateTime.Parse(dtpngaynhan.Text), txttenbh.Text, null, int.Parse(luemathang.EditValue.ToString()),
                                       int.Parse(luenhanvien.EditValue.ToString()), txtyeucau.Text, DateTime.Parse(dtpngaytra.Text), txtghichu.Text, chkdatra.Checked);
                        MessageBox.Show("Đã cập nhật phiếu bảo hành mới", "Thông báo");
                    }
                }
                catch
                {
                    MessageBox.Show("Không cập nhật được phiếu bảo hành.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (dem == true)
            {
                int dem1 = int.Parse(txtmabh.Text) + 1;
                txtmabh.Text = dem1.ToString();
                dem = false;
            }
            txttenbh.ResetText();
            txtdienthoai.ResetText();
            txtyeucau.ResetText();
            txtghichu.ResetText();
            txttenbh.Focus();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
