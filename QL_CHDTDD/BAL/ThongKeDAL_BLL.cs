using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BAL
{
   public class ThongKeDAL_BLL
    {
        QL_CHDDDataContext db = new QL_CHDDDataContext();
        public List<TONKHO> Laytonkho()
        {
            return db.TONKHOs.ToList();
        }
        public List<THONGKECHI> LayThongkechi()
        {
            return db.THONGKECHIs.ToList();
        }
        public List<THONGKETHU> LayThongkethu()
        {
            return db.THONGKETHUs.ToList();
        }
        public List<THONGKEBANHANG> LayThongkebanhang()
        {
            return db.THONGKEBANHANGs.ToList();
        }
        public List<THONGKEHANGBANCHAY> Layhangbanchay()
        {
            return db.THONGKEHANGBANCHAYs.ToList();
        }
        public List<THONGTINBAOHANH> Laythongtinbaohanh()
        {
            return db.THONGTINBAOHANHs.ToList();
        }
        public List<THONGKENHAPKHO> Laythongkenhapkho()
        {
            return db.THONGKENHAPKHOs.ToList();
        }
        public List<THONGKEXUATKHO> Laythongkexuatkho()
        {
            return db.THONGKEXUATKHOs.ToList();
        }
    }
}
