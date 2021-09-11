using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class TonkhoDAL_BLL
    {
        QL_CHDDDataContext tk = new QL_CHDDDataContext();
        public void CapNhatSLTon(int mamh,int sl)
        {
             tk.UPDATESLNHAP(mamh, sl);
        }
        public void CapNhatSLCon(int mamh)
        {
            tk.UPDATESLCON(mamh);
        }
    }
}
