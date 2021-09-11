using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class HoaDonDAL_BLL
    {
        QL_CHDDDataContext db = new QL_CHDDDataContext();
        public IQueryable<LAYHOADONResult> LayHoaDon()
        {
            return db.LAYHOADON();
        }
        public IQueryable LayHoaDon1()
        {
            IQueryable hd = from c in db.HOADONs
                     select new { c.MAHD, c.SOLUONG, c.MAKH, c.NGAYLAP, c.NHANVIEN.HOTEN, c.TONGTIEN };

            return hd;
        }
        public IQueryable LayHoaDon2(int mahd)
        {
            IQueryable hd = from c in db.HOADONs
                            where c.MAHD==mahd
                            select new { c.MAHD};

            return hd;
        }
        public IQueryable LayHoaDon3()
        {
            IQueryable hd = from c in db.HOADONs
                            select new { c.MAHD };

            return hd;
        }
        public int CapNhatHoaDon1(int MAHD)
        {
            return db.spCAPNHATHOADON1(MAHD);
        }
        public int ThemHoaDon(int MAHD, string SOLUONG, int MAKH, DateTime NGAYLAP, int MANV, string TONGTIEN)
        {
            return db.spTHEMHOADON(MAHD, SOLUONG, MAKH, NGAYLAP, MANV, TONGTIEN);
        }
        public int CapNhatHoaDon(int MAHD, int SOLUONG, int MAKH, DateTime NGAYLAP, int MANV, float TONGTIEN)
        {
            return db.spCAPNHATHOADON(MAHD, SOLUONG, MAKH, NGAYLAP, MANV, TONGTIEN);
        }
        public int XoaHoaDon(int MAHD)
        {
            return db.spXOAHOADON(MAHD);
        }
    }
}
