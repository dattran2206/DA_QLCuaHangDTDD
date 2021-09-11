using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL;
namespace BAL
{
   public class BoPhanDAL_BLL
    {
        QL_CHDDDataContext BoPhan = new QL_CHDDDataContext();
        public IQueryable<LAYBOPHANResult> LayBoPhan()
        {
            return BoPhan.LAYBOPHAN();
        }
        public int ThemBoPhan(int MABP, string TENBP)
        {
            return BoPhan.spTHEMBOPHAN(MABP, TENBP);
        }
        public int CapNhatBoPhan(int MABP, string TENBP)
        {
            return BoPhan.spCAPNHATBOPHAN(MABP, TENBP);
        }
        public int XoaBoPhan(int MABP)
        {
            return BoPhan.spXOABOPHAN(MABP);
        }
    }
}
