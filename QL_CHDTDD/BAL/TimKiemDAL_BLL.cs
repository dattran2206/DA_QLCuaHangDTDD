using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class TimKiemDAL_BLL
    {
        QL_CHDDDataContext db = new QL_CHDDDataContext();
        public IQueryable<TKBAOHANHResult> TKBH(string TENKH, bool DATRA)
        {
            return db.TKBAOHANH(TENKH, DATRA);
        }
        public IQueryable<TKBAOHANH_TENKHResult> TKBH_TENKH(string TENKH)
        {
            return db.TKBAOHANH_TENKH(TENKH);
        }
        public IQueryable<TKBAOHANH_DTResult> TKBHDT(bool M1)
        {
            return db.TKBAOHANH_DT(M1);
        }
        public IQueryable<TKMATHANG_LOAIMHResult> TKmaThangLoaiMH(string LOAIMH)
        {
            return db.TKMATHANG_LOAIMH(LOAIMH);
        }
        public IQueryable<TKMATHANGResult> TKmaThang(string TENMH, string LOAIMH)
        {
            return db.TKMATHANG(TENMH, LOAIMH);
        }
        public IQueryable<TKMATHANG_TENMHResult> TKmaThang_TenMH(string TENMH)
        {
            return db.TKMATHANG_TENMH(TENMH);
        }
        public IQueryable<TKKHACHHANG_TENKHTRAGOPResult> TKkhachhang_tenkhtragop(string TENKH)
        {
            return db.TKKHACHHANG_TENKHTRAGOP(TENKH);
        }
        public IQueryable<TKKHACHHANG_TENKHKHONGTRAGOPResult> TKkhachhang_tenkhkhongtragop(string TENKH)
        {
            return db.TKKHACHHANG_TENKHKHONGTRAGOP(TENKH);
        }
        public IQueryable<TKKHACHHANG_TENKHResult> TKkhachhang_tenkh(string TENKH)
        {
            return db.TKKHACHHANG_TENKH(TENKH);
        }
        public IQueryable<TKNHACUNGCAPResult> TKnhacungcap(string TENNCC)
        {
            return db.TKNHACUNGCAP(TENNCC);
        }
        public IQueryable<TKNHAPKHOResult> TKnhapkho(string MAMH, DateTime ngay1, DateTime ngay2)
        {
            return db.TKNHAPKHO(MAMH, ngay1, ngay2);
        }
        public IQueryable<TKNHAPKHO_MAMHResult> TKnhapkho_mathang(string MAMH)
        {
            return db.TKNHAPKHO_MAMH(MAMH);
        }
        public IQueryable<TKNHAPKHO_NGAYResult> TKnhapkho_ngay(DateTime ngay1, DateTime ngay2)
        {
            return db.TKNHAPKHO_NGAY(ngay1, ngay2);
        }
        public IQueryable<TKXUATKHOResult> TKxuatkho(int MAHD)
        {
            return db.TKXUATKHO(MAHD);
        }
        public IQueryable<TKTONKHO_LOAIMHResult> TKtonkholoaiMH(string LOAIMH)
        {
            return db.TKTONKHO_LOAIMH(LOAIMH);
        }
        public IQueryable<TKTONKHOResult> TKtonkho(string MAMH)
        {
            return db.TKTONKHO(MAMH);
        }
        public IQueryable<TKTONKHO_LOAIMHVAMAMHResult> TKtonkholoaiMHvaMaMH(string MAMH, string LOAIMH)
        {
            return db.TKTONKHO_LOAIMHVAMAMH(MAMH, LOAIMH);
        }
        public IQueryable TKxuatkho1(int MAHD)
        {
            IQueryable hd = from c in db.CHITIETHOADONs
                            where c.MAHD == MAHD
                            select new { c.MACTHD, c.MAHD, c.MATHANG.TENMH, c.SOLUONG, c.DONVITINH, c.THANHTIEN };
            return hd;
        }
        public IQueryable<TKPHIEUDATHANG_DATRA1Result> TKphieudathangdatra()
        {
            return db.TKPHIEUDATHANG_DATRA1();
        }
        public IQueryable<TKPHIEUDATHANG_DATRAResult> TKphieudathang_datra(string MANCC)
        {
            return db.TKPHIEUDATHANG_DATRA(MANCC);
        }
        public IQueryable<TKPHIEUDATHANG_CONNO1Result> TKphieudathangconno()
        {
            return db.TKPHIEUDATHANG_CONNO1();
        }
        public IQueryable<TKPHIEUDATHANG_CONNOResult> TKphieudathang_conno(string MANCC)
        {
            return db.TKPHIEUDATHANG_CONNO(MANCC);
        }
        public IQueryable<TKPHIEUDATHANG_MANCCResult> TKphieudathang_nhacc(string MANCC)
        {
            return db.TKPHIEUDATHANG_MANCC(MANCC);
        }
        public IQueryable<TKPHIEUTHUResult> TKphieuthu(DateTime ngay1, DateTime ngay2)
        {
            return db.TKPHIEUTHU(ngay1, ngay2);
        }
        public IQueryable<TKPHIEUCHIResult> TKphieuchi(DateTime ngay1, DateTime ngay2)
        {
            return db.TKPHIEUCHI(ngay1, ngay2);
        }
        public IQueryable<TKNHANVIENResult> TKnhanvien(string TENNV, string BOPHAN)
        {
            return db.TKNHANVIEN(TENNV, BOPHAN);
        }
        public IQueryable<TKNHANVIEN1Result> TKnhanvien1(string TENNV)
        {
            return db.TKNHANVIEN1(TENNV);
        }
        public IQueryable<TKTTBAOHANHResult> TKTTBH(string M1, string M2)
        {
            return db.TKTTBAOHANH(M1, M2);
        }
        public IQueryable<TKTTBAOHANH_MAKHResult> TKTTBH_KH(string MAKH)
        {
            return db.TKTTBAOHANH_MAKH(MAKH);
        }
        public IQueryable<TKTTBAOHANH_MAMHResult> TKTTBH_MH(string MAMH)
        {
            return db.TKTTBAOHANH_MAMH(MAMH);
        }
        public IQueryable<TKKHUYENMAINGAYResult> TKkhuyenmaingay(DateTime NGAY)
        {
            return db.TKKHUYENMAINGAY(NGAY);
        }
    }
}
