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
    public partial class QuanlyTaiKhoan : Form
    {
        TaiKhoanDAL_BLL tk = new TaiKhoanDAL_BLL();
        public QuanlyTaiKhoan()
        {
            InitializeComponent();
        }
        void Taikhoan()
        {
            try
            {
                gridTaikhoan.DataSource = tk.Laytaikhoan();
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu từ bảng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void QuanlyTaiKhoan_Load(object sender, EventArgs e)
        {
            Taikhoan();
        }

        private void tsbThem_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoan1 frm = new QuanLyTaiKhoan1();
            frm.ShowDialog();
            Taikhoan();
        }

        private void tsbxoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult TRALOI;
                TRALOI = MessageBox.Show("Bạn muốn xóa phiếu bảo hành này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (TRALOI == DialogResult.Yes)
                {
                    string STRMABH = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TAIKHOAN").ToString();
                    tk.Xoataikhoan(STRMABH);
                    Taikhoan();
                    MessageBox.Show("Tài khoản đã được xóa", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được tài khoản này.", "Lỗi");
            }
        }

        private void tsbRef_Click(object sender, EventArgs e)
        {
            Taikhoan();
        }
    }
}
