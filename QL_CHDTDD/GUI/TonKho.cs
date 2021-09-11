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
    public partial class TonKho : Form
    {
        ThongKeDAL_BLL tk = new ThongKeDAL_BLL();
        TonkhoDAL_BLL tonkho = new TonkhoDAL_BLL();
        MatHangDAL_BLL mh = new MatHangDAL_BLL();
        TimKiemDAL_BLL timkiem = new TimKiemDAL_BLL();
        public int MAMH2 { set; get; }
        public int SOLUONG { set; get; }
        public TonKho()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                gridTonkho.DataSource = tk.Laytonkho();
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadMAMH()
        {
            luutimkiem.Properties.DataSource = mh.LayMaMH();
        }
        private void TonKho_Load(object sender, EventArgs e)
        {
            LoadData();
            LoaiMH();
            LoadMAMH();
            //MAMH2 = NhapKho.MAMH1;
            //SOLUONG = NhapKho.SOLUONG;
        }
        void LoaiMH()
        {
            gridLoaiMH.DataSource = mh.Laymathang1();
            int b = int.Parse(gridView3.RowCount.ToString());
            trvtimkiem.Nodes.Add("Tất cả");
            for (int i = 0; i < b; i++)
            {
                trvtimkiem.Nodes.Add(gridView3.GetRowCellValue(i, "lOAIMH").ToString());
            }
        }
        private void tsbREf_Click(object sender, EventArgs e)
        {
            //tonkho.CapNhatSLTon(MAMH2,SOLUONG);
            LoadData();
            luutimkiem.EditValue = null;
            luutimkiem.Properties.NullText = "Chọn mã mặt hàng";    
        }

        private void sbtn_slcon_Click(object sender, EventArgs e)
        {
            //tonkho.CapNhatSLCon()

        }

        private void trvtimkiem_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode thenode = this.trvtimkiem.SelectedNode;
            if (thenode.Text == "Tất cả")
            {
                gridTonkho.DataSource = tk.Laytonkho();
            }
            else
            {
                if (luutimkiem.Text == "" || luutimkiem.Text == "Chọn mã mặt hàng")
                    gridTonkho.DataSource = timkiem.TKtonkholoaiMH(thenode.Text);
                else
                    gridTonkho.DataSource = timkiem.TKtonkholoaiMHvaMaMH(luutimkiem.Text, thenode.Text);
            }
        }

        private void luutimkiem_EditValueChanged(object sender, EventArgs e)
        {
            TreeNode thenode = this.trvtimkiem.SelectedNode;
            if (luutimkiem.Text == "" || luutimkiem.Text == "Chọn mã mặt hàng")
            {
                if (thenode.Text == "Tất cả")
                    LoadData();
                else
                    gridTonkho.DataSource = timkiem.TKtonkholoaiMH(thenode.Text);
            }
            else
            {
                if (thenode.Text == "Tất cả")
                    gridTonkho.DataSource = timkiem.TKtonkho(luutimkiem.Text);
                else
                    gridTonkho.DataSource = timkiem.TKtonkholoaiMHvaMaMH(luutimkiem.Text, thenode.Text);
            }
        }

        private void luutimkiem_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                luutimkiem.EditValue = null;
                luutimkiem.Properties.NullText = "Chọn mã mặt hàng";
            }
        }
    }
}
