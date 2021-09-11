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
    public partial class NhapKho1 : Form
    {
        MatHangDAL_BLL MH = new MatHangDAL_BLL();
        NhanVienDAL_BLL NV = new NhanVienDAL_BLL();
        PhieuNhapDAL_BLL PN = new PhieuNhapDAL_BLL();
        TonkhoDAL_BLL TK = new TonkhoDAL_BLL();
        public NhapKho1()
        {
            InitializeComponent();
        }
        public string MAPN { set; get; }
        public string MAMH { set; get; }
        public string MANV { set; get; }
        public string NGAYNHAP { set; get; }
        public string SOLUONG { set; get; }
        public bool THEM { set; get; }
        public bool DEM { set; get; }
        public void Loaddata()
        {
            int mq = int.Parse(DangNhap.MAQUYEN);
            if (mq == 4)
            {
                luemanv.Properties.DataSource = NV.LayNhanVien2(mq);
                luemanv.Properties.DisplayMember = "HOTEN";
                luemanv.Properties.ValueMember = "MANV";
            }
            else
            {
                luemanv.Properties.DataSource = NV.LayNhanVien();
                luemanv.Properties.DisplayMember = "HOTEN";
                luemanv.Properties.ValueMember = "MANV";
            }
            luemamh.Properties.DataSource = MH.laymathang();
            luemamh.Properties.DisplayMember = "TENMH";
            luemamh.Properties.ValueMember = "MAMH";
        }
        private void NhapKho1_Load(object sender, EventArgs e)
        {
            if (THEM)
            {
                txtmapn.Text = MAPN;
                luemamh.Text = MAMH;
                luemanv.Text = MANV;
                dtpngaynhap.Enabled = false;
                dtpngaynhap.Text = DateTime.Now.ToShortDateString();
                txtsoluong.Text = SOLUONG;
            }
            else
            {
                txtmapn.Text = MAPN;
                luemamh.EditValue = MAMH;
                luemanv.EditValue = MANV;
                dtpngaynhap.Enabled = true;
                dtpngaynhap.Text = NGAYNHAP;
                txtsoluong.Text = SOLUONG;
            }
            Loaddata();
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == '.'))
            {
                e.Handled = true;
                MessageBox.Show("Bạn Nhập sai dữ liệu");
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (THEM)
            {
                if (luemamh.EditValue.Equals("") || luemanv.EditValue.Equals("") || txtsoluong.Text.Equals(""))
                    MessageBox.Show("Bạn Nhập Thiếu Dữ Liệu");
                else
                {
                    //int mamh = int.Parse(luemamh.EditValue.ToString());
                    //int sl = int.Parse(txtsoluong.Text);
                    try
                    {
                        PN.ThemPhieuNhap(int.Parse(txtmapn.Text.Trim()), int.Parse(luemamh.EditValue.ToString()), int.Parse(luemanv.EditValue.ToString()),
                                            DateTime.Parse(dtpngaynhap.Text.Trim()), int.Parse(txtsoluong.Text.Trim())); 
                        MessageBox.Show("Thêm phiếu nhập mới thành công", "Thông báo");
                        //TK.CapNhatSLTon(mamh, sl);
                        MH.updateSL1(int.Parse(luemamh.EditValue.ToString()));
                        DEM = true;
                    }
                    catch
                    {
                        MessageBox.Show("Không thêm được phiếu nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            if (!THEM)
            {
                try
                {
                    PN.CapNhatPhieuNhap(int.Parse(txtmapn.Text), int.Parse(luemamh.EditValue.ToString()), int.Parse(luemanv.EditValue.ToString()), DateTime.Parse(dtpngaynhap.Text), int.Parse(txtsoluong.Text));
                    MessageBox.Show("Đã cập nhật phiếu nhập mới", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Không cập nhật được phiếu nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            if (DEM == true)
            {
                int DEM2 = int.Parse(txtmapn.Text) + 1;
                txtmapn.Text = DEM2.ToString();
                DEM = false;
            }
            txtsoluong.ResetText();
            luemanv.ResetText();
            luemamh.ResetText();
            //dtpngaynhap.ResetText();
            luemamh.Focus();
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
