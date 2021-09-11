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
    public partial class KhachHang1 : Form
    {
        KhachHangDAL_BLL KH = new KhachHangDAL_BLL();
        public KhachHang1()
        {
            InitializeComponent();
        }
        public string MAKH { set; get; }
        public string TENKH { set; get; }
        public string DIACHI { set; get; }
        public bool GIOITINH { set; get; }
        public string SDT { set; get; }
        public bool THEM { set; get; }
        public bool DEM { set; get; }
        private void KhachHang1_Load(object sender, EventArgs e)
        {
            txtmakh.Text = MAKH;
            txttenkh.Text = TENKH;
            txtdiachi.Text = DIACHI;
            chkgioitinh.Checked = GIOITINH;
            txtSDT.Text = SDT;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (THEM)
            {
                if (txttenkh.Text.Equals("") || txtdiachi.Text.Equals("") || txtSDT.Text.Equals(""))
                    MessageBox.Show("Bạn Nhập Thiếu Dữ Liệu");
                else
                {
                    try
                    {
                        KH.ThemKhachHang(int.Parse(txtmakh.Text.Trim()), txttenkh.Text.Trim(), txtdiachi.Text.Trim(), chkgioitinh.Checked, txtSDT.Text.Trim());
                        MessageBox.Show("Thêm khách hàng mới thành công", "Thông báo");
                        DEM = true;
                    }
                    catch
                    {
                        MessageBox.Show("Không thêm được khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            if (!THEM)
            {
                try
                {
                    if (txtSDT.Text != "")
                    {
                        KH.CapNhatKhachHang(int.Parse(txtmakh.Text), txttenkh.Text, txtdiachi.Text, chkgioitinh.Checked, txtSDT.Text);
                        MessageBox.Show("Đã cập nhật khách hàng mới", "Thông báo");
                    }
                    else
                    {
                        KH.CapNhatKhachHang(int.Parse(txtmakh.Text), txttenkh.Text, txtdiachi.Text, chkgioitinh.Checked, null);
                        MessageBox.Show("Đã cập nhật khách hàng mới", "Thông báo");
                    }
                }
                catch
                {
                    MessageBox.Show("Không cập nhật được khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            if (DEM == true)
            {
                int DEM2 = int.Parse(txtmakh.Text) + 1;
                txtmakh.Text = DEM2.ToString();
                DEM = false;
            }
            txttenkh.ResetText();
            txtdiachi.ResetText();
            txtSDT.ResetText();
            chkgioitinh.Reset();
            txttenkh.Focus();
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
