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
    public partial class NhaCungCap1 : Form
    {
        NhaCungCapDAL_BLL NCC = new NhaCungCapDAL_BLL();
        public NhaCungCap1()
        {
            InitializeComponent();
        }
        public string MANCC { set; get; }
        public string TENNCC { set; get; }
        public string DIACHI { set; get; }
        public string SDT { set; get; }
        public string GHICHU { set; get; }
        public bool THEM { set; get; }
        public bool DEM { set; get; }
        private void btnluu_Click(object sender, EventArgs e)
        {
            if (THEM)
            {
                if (txtTenNCC.Text.Equals("") || txtDiaChi.Text.Equals("") || txtSDT.Text.Equals(""))
                    MessageBox.Show("Bạn Nhập Thiếu Dữ Liệu");
                else
                {
                    try
                    {
                        if (txtGhiChu.Text != "")
                        {
                            NCC.ThemNhaCC(int.Parse(txtMaNCC.Text.Trim()), txtTenNCC.Text.Trim(), txtDiaChi.Text.Trim(), txtSDT.Text.Trim(), txtGhiChu.Text.Trim());
                            MessageBox.Show("Thêm nhà cung cấp mới thành công", "Thông báo");
                        }
                        else
                        {
                            NCC.ThemNhaCC(int.Parse(txtMaNCC.Text.Trim()), txtTenNCC.Text.Trim(), txtDiaChi.Text.Trim(), txtSDT.Text, null);
                            MessageBox.Show("Thêm nhà cung cấp mới thành công", "Thông báo");
                        }
                        DEM = true;
                    }
                    catch
                    {
                        MessageBox.Show("Không thêm được nhà cung cấp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            if (!THEM)
            {
                try
                {
                    if (txtSDT.Text != "")
                    {
                        NCC.CapNhatNhaCC(int.Parse(txtMaNCC.Text), txtTenNCC.Text, txtDiaChi.Text, txtSDT.Text, txtGhiChu.Text);
                        MessageBox.Show("Đã cập nhật nhà cung cấp mới", "Thông báo");
                    }
                    else
                    {
                        NCC.CapNhatNhaCC(int.Parse(txtMaNCC.Text), txtTenNCC.Text, txtDiaChi.Text, null, txtGhiChu.Text);
                        MessageBox.Show("Đã cập nhật nhà cung cấp mới", "Thông báo");
                    }
                }
                catch
                {
                    MessageBox.Show("Không cập nhật được nhà cung cấp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void NhaCungCap1_Load(object sender, EventArgs e)
        {
            txtMaNCC.Text = MANCC;
            txtTenNCC.Text = TENNCC;
            txtDiaChi.Text = DIACHI;
            txtSDT.Text = SDT;
            txtGhiChu.Text = GHICHU;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (DEM == true)
            {
                int DEM2 = int.Parse(txtMaNCC.Text) + 1;
                txtMaNCC.Text = DEM2.ToString();
                DEM = false;
            }
            txtTenNCC.ResetText();
            txtSDT.ResetText();
            txtGhiChu.ResetText();
            txtDiaChi.ResetText();
            txtTenNCC.Focus();
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
