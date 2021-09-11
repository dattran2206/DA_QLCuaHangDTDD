using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
   public class BienLaiTraGopDAL_BLL
    {
        QL_CHDDDataContext TraGop = new QL_CHDDDataContext();
        public IQueryable<LAYBIENLAITRAGOPResult> LayBienLaiTraGop()
        {
            return TraGop.LAYBIENLAITRAGOP();
        }
        public IQueryable LayBienLaiTheoMakh(int makh)
        {
            IQueryable kh = from c in TraGop.BIENLAITRAGOPs
                            where c.MAKH == makh
                            select c;
            return kh;
                           
        }
        public IQueryable LayKhachHangTraGop(int makh)
        {
            IQueryable khtg = from c in TraGop.PHIEUTRAGOPs
                              where c.MAKH == makh
                              select new { c.MAKH, c.KHACHHANG.HOTEN, c.TONGTIEN };
            return khtg;
        }
        public IQueryable<LAYTHONGBAOTRAGOPResult> Laythongbaotragop()
        {
            return TraGop.LAYTHONGBAOTRAGOP();
        }
        public int ThemBienLaiTraGop(int MABL, int MANV, DateTime NGAYLAP, int MAKH, float SOTIEN, string GHICHU)
        {
            return TraGop.spTHEMBIENLAITRAGOP(MABL, MANV, NGAYLAP, MAKH, SOTIEN, GHICHU);
        }
        public int CapNhatBienLaiTraGop(int MABL, int MANV, DateTime NGAYLAP, int MAKH, float SOTIEN, string GHICHU)
        {
            return TraGop.spCAPNHATBIENLAITRAGOP(MABL, MANV, NGAYLAP, MAKH, SOTIEN, GHICHU);
        }
        public int XoaBienLaiTraGop(int MABL)
        {
            return TraGop.spXOABIENLAITRAGOP(MABL);
        }
        public int XoaBienLai_Makh(int makh)
        {
            return TraGop.XOACBIENLAI_MAKH(makh);
        }
    }
}
