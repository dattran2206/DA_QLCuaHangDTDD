using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace BAL
{
    public class TaiKhoanDAL_BLL
    {
        QL_CHDDDataContext db = new QL_CHDDDataContext();
        public IQueryable<LAYDANGNHAP1Result> Check_TK(string tk, string mk)
        {
            return db.LAYDANGNHAP1(tk, mk);
        }
        public int CapNhatMatKhau(string tk,string mk,string mkmoi)
        {
            return db.spDOIMATKHAU1(tk, mk, mkmoi);
        }
        public IQueryable LayMaQuyen()
        {
            IQueryable mq = from c in db.PHANQUYENs
                            select c;
            return mq;
        }
        public IQueryable<LAYTAIKHOANResult> Laytaikhoan()
        {
            return db.LAYTAIKHOAN();
        }
        public int Themtaikhoan(string TAIKHOAN, string MATKHAU, int MAQUYEN)
        {
            return db.spTHEMTAIKHOAN(TAIKHOAN, MATKHAU, MAQUYEN);
        }
        public int Xoataikhoan(string TAIKHOAN)
        {
            return db.spXOATAIKHOAN(TAIKHOAN);
        }
    }
}
