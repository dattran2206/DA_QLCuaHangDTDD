using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class MatHangDAL_BLL
    {
        QL_CHDDDataContext db = new QL_CHDDDataContext();
        public IQueryable<LAYMATHANGResult> laymathang()
        {
            return db.LAYMATHANG();
        }
        public IQueryable<LAYMATHANG1Result> Laymathang1()
        {
            return db.LAYMATHANG1();
        }
        public IQueryable LayGiaBan(int ma)
        {
            IQueryable hd = from c in db.MATHANGs
                            where c.MAMH == ma
                            select new { c.GIABAN };
            return hd;

        }
        public IQueryable LayMaMH()
        {
            IQueryable hd = from c in db.MATHANGs
                            select new { c.MAMH,c.TENMH,c.HINH,c.DACDIEM };
            return hd;

        }
        public IQueryable LayMatHang2()
        {
            IQueryable hd = from c in db.MATHANGs
                            where c.SOLUONG > 0
                            select c;
            return hd;

        }
        public IQueryable LaySoLuong(int mahang)
        {
            IQueryable hd = from c in db.MATHANGs
                            where c.MAMH==mahang
                            select new { c.SOLUONG };
            return hd;
        }
        public int updateSL(int mamh)
        {
            return db.UPDATESL(mamh);
        }
        public int updateSL1(int mamh)
        {
            return db.UPDATESLNHAP1(mamh);
        }
        public IQueryable<LAYMATHANG1Result> laymathang1()
        {
            return db.LAYMATHANG1();
        }
        public int Themmathang(int MAMH, string TENMH, string HANGSX, double GIAMUA, double GIABAN, string DONVITINH, int BAOHANH, string MAKM, string DACDIEM, int SOLUONG,
                              byte[] HINH, string GHICHU, string lOAIMH)
        {
            return db.spTHEMMATHANG(MAMH, TENMH, HANGSX, GIAMUA, GIABAN, DONVITINH, BAOHANH, MAKM, DACDIEM, SOLUONG, HINH, GHICHU, lOAIMH);
        }
        public int XoaKhuyenMai(int MAMH)
        {
            return db.spXOAMATHANG(MAMH);
        }
        public int Capnhatmathang(int MAMH, string TENMH, string HANGSX, double GIAMUA, double GIABAN, string DONVITINH, int BAOHANH, string MAKM, string DACDIEM, int SOLUONG,
                                byte[] HINH, string GHICHU, string lOAIMH)
        {
            return db.spCAPNHATMATHANG(MAMH, TENMH, HANGSX, GIAMUA, GIABAN, DONVITINH, BAOHANH, MAKM, DACDIEM, SOLUONG, HINH, GHICHU, lOAIMH);
        }
    }
}
