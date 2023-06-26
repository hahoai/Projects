using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_DangNhap
    {
        Dal_DangNhap dal_DN = new Dal_DangNhap();

        public bool themDN(DTO_DangNhap pDN)
        {
            return dal_DN.themDN(pDN);
        }

        public bool suaDN(DTO_DangNhap pDN)
        {
            return dal_DN.suaDN(pDN);
        }

        public bool xoaDN(String TenDN)
        {
            return dal_DN.xoaDN(TenDN);
        }
        public bool kiemtratontai(String TenDN)
        {
            return dal_DN.kiemtratontai(TenDN);
        }

        public DataTable DN()
        {
            return dal_DN.DangNhap();
        }
    }
}
