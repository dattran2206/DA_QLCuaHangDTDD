using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
   public class KhachHangDAL_BLL
    {
        QL_CHDDDataContext db = new QL_CHDDDataContext();
        public IQueryable<LAYKHACHHANGResult> LayKhachHang()
        {
            return db.LAYKHACHHANG();
        }
        public int ThemKhachHang(int MAKH, string HOTEN, string DIACHI, bool GIOITINH, string SDT)
        {
            return db.spTHEMKHACHHANG(MAKH, HOTEN, DIACHI, GIOITINH, SDT);
        }
        public int CapNhatKhachHang(int MAKH, string HOTEN, string DIACHI, bool GIOITINH, string SDT)
        {
            return db.spCAPNHATKHACHHANG(MAKH, HOTEN, DIACHI, GIOITINH, SDT);
        }
        public int XoaKhachHang(int MAKH)
        {
            return db.spXOAKHACHHANG(MAKH);
        }
    }
}
