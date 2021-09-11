using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class PhieuNhapDAL_BLL
    {
        QL_CHDDDataContext PhieuNhap = new QL_CHDDDataContext();
        public IQueryable<LAYPHIEUNHAPResult> LayPhieuChi()
        {
            return PhieuNhap.LAYPHIEUNHAP();
        }
        public int ThemPhieuNhap(int MAPN, int MAMH, int MANV, DateTime NGAYNHAP, int SOLUONG)
        {
            return PhieuNhap.spTHEMPHIEUNHAP(MAPN, MAMH, MANV, NGAYNHAP, SOLUONG);
        }
        public int CapNhatPhieuNhap(int MAPN, int MAMH, int MANV, DateTime NGAYNHAP, int SOLUONG)
        {
            return PhieuNhap.spCAPNHATPHIEUNHAP(MAPN, MAMH, MANV, NGAYNHAP, SOLUONG);
        }
        public int XoaPhieuNhap(int MAPN)
        {
            return PhieuNhap.spXOAPHIEUNHAP(MAPN);
        }
        public int XoaPhieuNhap1(int MAPN)
        {
            return PhieuNhap.XOAPHIEUNHAP(MAPN);
        }
    }
}
