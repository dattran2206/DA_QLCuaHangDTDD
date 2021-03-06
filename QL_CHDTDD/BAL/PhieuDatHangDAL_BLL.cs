using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
   public class PhieuDatHangDAL_BLL
    {
        QL_CHDDDataContext PhieuDH = new QL_CHDDDataContext();
        public IQueryable<LAYPHIEUDATHANGResult> LayPhieuDH()
        {
            return PhieuDH.LAYPHIEUDATHANG();
        }
        public int ThemPhieuDH(int MAPDH, int MAMH, int MANCC, int MANV, int SOLUONG, float GIANHAP, DateTime NGAYDH, double DATRA, double CONNO)
        {
            return PhieuDH.spTHEMPHIEUDATHANG(MAPDH, MAMH, MANCC, MANV, SOLUONG, GIANHAP, NGAYDH, DATRA, CONNO);
        }
        public int CapNhatPhieuDH(int MAPDH, int MAMH, int MANCC, int MANV, int SOLUONG, float GIANHAP, DateTime NGAYDH, double DATRA, double CONNO)
        {
            return PhieuDH.spCAPNHATPHIEUDATHANG(MAPDH, MAMH, MANCC, MANV, SOLUONG, GIANHAP, NGAYDH, DATRA, CONNO);
        }
        public int XoaPhieuDH(int MAPDH)
        {
            return PhieuDH.spXOAPHIEUDATHANG(MAPDH);
        }
    }
}
