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
    public partial class QuanLyTaiKhoan1 : Form
    {
        TaiKhoanDAL_BLL TK = new TaiKhoanDAL_BLL();
        public QuanLyTaiKhoan1()
        {
            InitializeComponent();
        }
        public void loaddata()
        {
            luemaquyen.Properties.DataSource = TK.LayMaQuyen();
            luemaquyen.Properties.DisplayMember = "TENQUYEN";
            luemaquyen.Properties.ValueMember = "MAQUYEN";
        }
        private void QuanLyTaiKhoan1_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                TK.Themtaikhoan(txttaikhoan.Text.Trim(), txtmatkhau.Text.Trim(), int.Parse(luemaquyen.EditValue.ToString()));
                MessageBox.Show("Thêm tài khoản mới thành công", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Không thêm được tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
