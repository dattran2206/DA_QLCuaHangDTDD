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
    public partial class DoiMatKhau : Form
    {
        TaiKhoanDAL_BLL taikhoan = new TaiKhoanDAL_BLL();
        public DoiMatKhau()
        {
            InitializeComponent();
        }
        
        private void DoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn Có Muốn Thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txt_taikhoan.Text.Equals("") || txt_matkhaucu.Text.Equals("") || txt_matkhaumoi.Text.Equals("") || txt_xacnhan.Text.Equals(""))
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin để thay đổi mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if(txt_matkhaumoi.Text.CompareTo(txt_xacnhan.Text)!=0)
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không trùng khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    griddn.DataSource = taikhoan.Check_TK(txt_taikhoan.Text, txt_matkhaucu.Text);
                    int dem = int.Parse(gridView1.RowCount.ToString());
                    if (dem == 1)
                    {
                        taikhoan.CapNhatMatKhau(txt_taikhoan.Text, txt_matkhaucu.Text, txt_matkhaumoi.Text);
                        MessageBox.Show("Đổi mật khẩu mới thành công", "Thông báo");
                        
                    }
                    else
                    {
                        MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng.", "Thông báo");
                    }
                }
                catch
                {

                    MessageBox.Show("Không đổi được mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
