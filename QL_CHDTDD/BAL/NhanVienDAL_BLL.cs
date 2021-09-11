using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
   public class NhanVienDAL_BLL
    {
        QL_CHDDDataContext NhanVien = new QL_CHDDDataContext();
        public IQueryable<LAYNHANVIENResult> LayNhanVien()
        {
            return NhanVien.LAYNHANVIEN();
        }
        public IQueryable LayNhanVien1(int maquyen,int manv)
        {
            IQueryable d = from c in NhanVien.NHANVIENs
                           where c.MABP == maquyen && c.MANV==manv
                           select new { c.MANV, c.HOTEN };
            return d;

        }
        public IQueryable LayNhanVien2(int maquyen)
        {
            IQueryable d = from c in NhanVien.NHANVIENs
                           where c.MABP == maquyen
                           select new { c.MANV, c.HOTEN };
            return d;

        }
        public IQueryable LayNhanVien3(int manv)
        {
            IQueryable d = from c in NhanVien.NHANVIENs
                           where c.MANV == manv
                           select new { c.MANV, c.HOTEN };
            return d;

        }
        public int ThemNhanVien(int MANV, string HOTEN, string DIACHI, string SDT, int MABP, byte[] HINH, bool GIOITINH)
        {
            return NhanVien.spTHEMNHANVIEN(MANV, HOTEN, DIACHI, SDT, MABP, HINH, GIOITINH);
        }
        public int CapNhatNhanVien(int MANV, string HOTEN, string DIACHI, string SDT, int MABP, byte[] HINH, bool GIOITINH)
        {
            return NhanVien.spCAPNHATNHANVIEN(MANV, HOTEN, DIACHI, SDT, MABP, HINH, GIOITINH);
        }
        public int XoaNhanVien(int MANV)
        {
            return NhanVien.spXOANHANVIEN(MANV);
        }
    }
}
