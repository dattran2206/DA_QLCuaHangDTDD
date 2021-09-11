using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
  public  class NhaCungCapDAL_BLL
    {
        QL_CHDDDataContext db = new QL_CHDDDataContext();
        public IQueryable<LAYNHACUNGCAPResult> LayNhaCC()
        {
            return db.LAYNHACUNGCAP();
        }
        public int ThemNhaCC(int MANCC, string TENNCC, string DIACHI, string SDT, string GHICHU)
        {
            return db.spTHEMNHACUNGCAP(MANCC, TENNCC, DIACHI, SDT, GHICHU);
        }
        public int CapNhatNhaCC(int MANCC, string TENNCC, string DIACHI, string SDT, string GHICHU)
        {
            return db.spCAPNHATNHACUNGCAP(MANCC, TENNCC, DIACHI, SDT, GHICHU);
        }
        public int XoaNhaCC(int MANCC)
        {
            return db.spXOANHACUNGCAP(MANCC);
        }
    }
}
