using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
namespace GUI
{
    public partial class MatHang1 : Form
    {
        MemoryStream ms;
        byte[] arrImage;
        MatHang mh = new MatHang();
        MatHangDAL_BLL MH = new MatHangDAL_BLL();
        KhuyenMaiDAL_BLL KM = new KhuyenMaiDAL_BLL();
        public MatHang1()
        {
            InitializeComponent();
        }
        public string MAMH { set; get; }
        public string TENMH { set; get; }
        public string HANGSX { set; get; }
        public string GIABAN { set; get; }
        public string GIAMUA { set; get; }
        public int BAOHANH { set; get; }
        public string KHUYENMAI { set; get; }
        public string DONVITINH { set; get; }
        public string SOLUONG { set; get; }
        public string DACDIEM { set; get; }
        public string GHICHU { set; get; }
        public Image HINH { set; get; }
        public string LOAIMH { set; get; }
        public bool THEM { set; get; }
        public bool DEM { set; get; }
        public void loadMH()
        {
            cb_loaiMH.DataSource = MH.laymathang1();
            cb_loaiMH.DisplayMember = "LOAIMH";
        }
        public void LoadKM()
        {
            luekhuyenmai.Properties.DataSource = KM.LayKhuyenMai();
            luekhuyenmai.Properties.DisplayMember = "MAKM";
        }
        private void MatHang1_Load(object sender, EventArgs e)
        {
            txt_mamathang.Text = MAMH;
            txt_tenmathang.Text = TENMH;
            txt_hangsanxuat.Text = HANGSX;
            txt_giaban.Text = GIABAN;
            txt_giamua.Text = GIAMUA;
            txt_baohanh.Text = BAOHANH.ToString();
            luekhuyenmai.Text = KHUYENMAI;
            cb_donvitinh.Text = DONVITINH;
            txt_soluong.Text = SOLUONG;
            txt_dacdiem.Text = DACDIEM;
            txt_ghichu.Text = GHICHU;
            picHINH.Image = HINH;
            loadMH();
            cb_loaiMH.Text =LOAIMH;
            LoadKM();
        }

        private void btnlayhinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog odlgOpenFile = new OpenFileDialog();
            odlgOpenFile.InitialDirectory = "C:\\";
            odlgOpenFile.Title = "Open File";
            odlgOpenFile.Filter = "Image files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (odlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                picHINH.Image = System.Drawing.Image.FromFile(odlgOpenFile.FileName);
                //
                ms = new MemoryStream();
                picHINH.Image.Save(ms, picHINH.Image.RawFormat);
                arrImage = ms.GetBuffer();
                ms.Close();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn Có Muốn Thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
        }

        private void luekhuyenmai_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                luekhuyenmai.EditValue = null;
                luekhuyenmai.Properties.NullText = "";
            }
        }

        private void luekhuyenmai_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (THEM)
            {
                if (txt_tenmathang.Text.Equals("") || txt_hangsanxuat.Text.Equals("") || txt_giaban.Text.Equals("") || txt_giamua.Text.Equals("") || txt_baohanh.Text.Equals("") || cb_donvitinh.SelectedItem == null || txt_soluong.Text.Equals("") || cb_loaiMH.SelectedItem == null || txt_dacdiem.Text.Equals("")||txt_ghichu.Text.Equals(""))
                {
                    MessageBox.Show("Dữ Liệu chưa đủ");
                }
                else
                {
                    try
                    {
                        if (luekhuyenmai.Text != "")
                        {
                            MH.Themmathang(int.Parse(txt_mamathang.Text.Trim()), txt_tenmathang.Text.Trim(), txt_hangsanxuat.Text.Trim(), double.Parse(txt_giamua.Text.Trim()), int.Parse(txt_giaban.Text.Trim()), cb_donvitinh.Text.Trim(),
                                            int.Parse(txt_baohanh.Text.Trim()), luekhuyenmai.Text.Trim(), txt_dacdiem.Text.Trim(), int.Parse(txt_soluong.Text.Trim()), arrImage, txt_ghichu.Text.Trim(), cb_loaiMH.Text.Trim());
                            MessageBox.Show("Thêm mặt hàng mới thành công", "Thông báo");
                        }
                        else
                        {
                            MH.Themmathang(int.Parse(txt_mamathang.Text.Trim()), txt_tenmathang.Text.Trim(), txt_hangsanxuat.Text.Trim(), double.Parse(txt_giamua.Text.Trim()), int.Parse(txt_giaban.Text.Trim()), cb_donvitinh.Text.Trim(),
                                            int.Parse(txt_baohanh.Text.Trim()), null, txt_dacdiem.Text.Trim(), int.Parse(txt_soluong.Text.Trim()), arrImage, txt_ghichu.Text.Trim(), cb_loaiMH.Text.Trim());
                            MessageBox.Show("Thêm mặt hàng mới thành công", "Thông báo");
                            MH.laymathang();
                        }
                        DEM = true;
                    }
                    catch
                    {
                        MessageBox.Show("Không thêm được mặt hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            if (!THEM)
            {
                try
                {
                    if (luekhuyenmai.Text != "")
                    {
                        MH.Capnhatmathang(int.Parse(txt_mamathang.Text.Trim()), txt_tenmathang.Text.Trim(), txt_hangsanxuat.Text.Trim(), double.Parse(txt_giamua.Text.Trim()), int.Parse(txt_giaban.Text.Trim()), cb_donvitinh.Text.Trim(),
                                            int.Parse(txt_baohanh.Text.Trim()), luekhuyenmai.Text.Trim(), txt_dacdiem.Text.Trim(), int.Parse(txt_soluong.Text.Trim()), arrImage, txt_ghichu.Text.Trim(), cb_loaiMH.Text.Trim());
                        MessageBox.Show("Đã cập nhật mặt hàng mới", "Thông báo");
                    }
                    else
                    {
                        MH.Capnhatmathang(int.Parse(txt_mamathang.Text.Trim()), txt_tenmathang.Text.Trim(), txt_hangsanxuat.Text.Trim(), double.Parse(txt_giamua.Text.Trim()), int.Parse(txt_giaban.Text.Trim()), cb_donvitinh.Text.Trim(),
                                            int.Parse(txt_baohanh.Text.Trim()), null, txt_dacdiem.Text.Trim(), int.Parse(txt_soluong.Text.Trim()), arrImage, txt_ghichu.Text.Trim(), cb_loaiMH.Text.Trim());
                        MessageBox.Show("Đã cập nhật mặt hàng mới", "Thông báo");
                    }
                }
                catch
                {
                    MessageBox.Show("Không cập nhật được mặt hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            if (DEM == true)
            {
                int dem1 = int.Parse(txt_mamathang.Text) + 1;
                txt_mamathang.Text = dem1.ToString();
                DEM = false;
            }
            txt_baohanh.ResetText();
            txt_dacdiem.ResetText();
            txt_ghichu.ResetText();
            txt_giaban.ResetText();
            txt_giamua.ResetText();
            txt_hangsanxuat.ResetText();
            txt_soluong.Text = "0";
            txt_tenmathang.ResetText();
            luekhuyenmai.ResetText();
            cb_donvitinh.ResetText();
            cb_loaiMH.ResetText();
            txt_tenmathang.Focus();
        }
    }
}
