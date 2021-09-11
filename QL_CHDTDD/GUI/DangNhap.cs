using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using BAL;
namespace GUI
{
    public partial class DangNhap : DevExpress.XtraEditors.XtraForm
    {
        TaiKhoanDAL_BLL taikhoan = new TaiKhoanDAL_BLL();
        public DangNhap()
        {
            InitializeComponent();
        }
        public static string MAQUYEN { set; get; }
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            KT_DN();
        }
        public void KT_DN()
        {
            string tk = txt_taikhoan.Text;
            string mk = txt_matkhau.Text;
            int dem = 0;
            if (tk.Equals("") && mk.Equals(""))
                MessageBox.Show("Bạn Chưa Nhập Tài Khoản và Mật Khẩu");
            else if (tk.Equals(""))
                MessageBox.Show("Bạn Chưa Nhập Tài Khoản");
            else if (mk.Equals(""))
                MessageBox.Show("Bạn Chưa Nhập Mật Khẩu");
            else
            {
                gridDN.DataSource = taikhoan.Check_TK(tk, mk);
                dem = int.Parse(gridView1.RowCount.ToString());
                if (dem == 1)
                {
                    MAQUYEN = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAQUYEN").ToString();
                    this.Hide();
                    manhinhchinh mh = new manhinhchinh();
                    mh.Show();
                }
                else
                    MessageBox.Show("Sai Tài Khoản hoặc Mật Khẩu");
            }
        }

        private void btn_huybo_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn Có Muốn Thoát", "Thoát", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                Application.Exit();
        }
    }
}