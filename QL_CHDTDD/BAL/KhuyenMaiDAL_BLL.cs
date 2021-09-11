using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
   public class KhuyenMaiDAL_BLL
    {
        QL_CHDDDataContext db = new QL_CHDDDataContext();
        public IQueryable<LAYKHUYENMAIResult> LayKhuyenMai()
        {
            return db.LAYKHUYENMAI();
        }
        public int ThemKhuyenMai(int MAKM, string THONGTIN, float GIATRI, DateTime NGAYBATDAU, DateTime NGAYKETTHUC, string GHICHU)
        {
            return db.spTHEMKHUYENMAI(MAKM, THONGTIN, GIATRI, NGAYBATDAU, NGAYKETTHUC, GHICHU);
        }
        public int CapNhatKhuyenMai(int MAKM, string THONGTIN, float GIATRI, DateTime NGAYBATDAU, DateTime NGAYKETTHUC, string GHICHU)
        {
            return db.spCAPNHATKHUYENMAI(MAKM, THONGTIN, GIATRI, NGAYBATDAU, NGAYKETTHUC, GHICHU);
        }
        public int XoaKhuyenMai(int MAKM)
        {
            return db.spXOAKHUYENMAI(MAKM);
        }
    }
}
