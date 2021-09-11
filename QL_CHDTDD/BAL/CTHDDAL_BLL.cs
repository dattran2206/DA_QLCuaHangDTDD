using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
   public class CTHDDAL_BLL
    {
        QL_CHDDDataContext db = new QL_CHDDDataContext();
        public IQueryable<LAYCHITIETHOADONResult> LayCTHD()
        {
            return db.LAYCHITIETHOADON();
        }
        public IQueryable<LAYCTHD1Result>LayCTHD2()
        {
            return db.LAYCTHD1();
        }
        public IQueryable LayCTHD1()
        {
            IQueryable cthd = from c in db.CHITIETHOADONs
                              select new { c.MACTHD, c.MAHD, c.MATHANG.TENMH, c.SOLUONG, c.DONVITINH, c.THANHTIEN};
            return cthd;
        }
        public IQueryable LayCTHD1(int Mahd)
        {
            IQueryable cthd = from c in db.CHITIETHOADONs
                              where c.MAHD==Mahd
                              select new { c.MACTHD, c.MAHD, c.MATHANG.TENMH, c.SOLUONG, c.DONVITINH, c.THANHTIEN};
            return cthd;
        }
        public IQueryable LayCTHD2(int Mahd)
        {
            IQueryable cthd = from c in db.CHITIETHOADONs
                              where c.MAHD == Mahd
                              select c;
            return cthd;
        }
        public IQueryable LayCTHD3()
        {
            IQueryable cthd3 = from c in db.CHITIETHOADONs
                               where c.MAHD == 1
                               select new { c.MAHD, c.MATHANG.MAMH, c.MATHANG.TENMH, c.MATHANG.GIABAN, c.THANHTIEN, c.SOLUONG, c.HOADON.TONGTIEN };
            return cthd3;
        }
            
        public int ThemCTHD(int MACTHD, int MAHD, int MAMH, int MANV, int MAKH, int SOLUONG, string DONVITINH, float THANHTIEN)
        {
            return db.spTHEMCTHOADON(MACTHD, MAHD, MAMH, MANV, MAKH, SOLUONG, DONVITINH, THANHTIEN);
        }
        public int CapNhatCTHD(int MACTHD, int MAHD, int MAMH, int MANV, int MAKH, int SOLUONG, string DONVITINH, float THANHTIEN)
        {
            return db.spCAPNHATCTHOADON(MACTHD, MAHD, MAMH, MANV, MAKH, SOLUONG, DONVITINH, THANHTIEN);
        }
        public int XoaCTHD(int MACTHD)
        {
            return db.spXOACTHOADON(MACTHD);
        }
        public int XoaCTHD_MAHD(int MAHD)
        {
            return db.XOACTHD_MAHD(MAHD);
        }
    }
}
