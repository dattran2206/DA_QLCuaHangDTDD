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
    public partial class XuatKho : Form
    {
        CTHDDAL_BLL XK = new CTHDDAL_BLL();
        HoaDonDAL_BLL HD = new HoaDonDAL_BLL();
        TimKiemDAL_BLL timKiem = new TimKiemDAL_BLL();
        public XuatKho()
        {
            InitializeComponent();
        }
        public void LayHoaDon()
        {
            lueTimkiem.Properties.DataSource = HD.LayHoaDon3();
        }
        void LoadData()
        {
            try
            {
                gridXuatKho.DataSource = XK.LayCTHD1();
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void XuatKho_Load(object sender, EventArgs e)
        {
            LoadData();
            LayHoaDon();
        }

        private void tsbRef_Click(object sender, EventArgs e)
        {
            LoadData();
            lueTimkiem.EditValue = null;
            lueTimkiem.Properties.NullText = "Chọn mã hóa đơn";
        }

        private void tsbIn_Click(object sender, EventArgs e)
        {
            gridXuatKho.ShowRibbonPrintPreview();
        }

        private void lueTimkiem_EditValueChanged(object sender, EventArgs e)
        {
            if (lueTimkiem.Text == "Chọn mã hóa đơn")
                gridXuatKho.DataSource = XK.LayCTHD();
            else
                gridXuatKho.DataSource = timKiem.TKxuatkho1(int.Parse(lueTimkiem.Text));
        }

        private void lueTimkiem_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                lueTimkiem.EditValue = null;
                lueTimkiem.Properties.NullText = "Chọn mã hóa đơn";
            }
        }
    }
}
