using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BUS
{
    
  public class BUS_KhenThuong
    {
        Dal_KhenThuong dal_KT = new Dal_KhenThuong();
        public bool themKT(DTO_KhenThuong pKT)
        {
            return dal_KT.themKT(pKT);
        }

        public bool suaKT(DTO_KhenThuong pKT)
        {
            return dal_KT.suaKT(pKT);
        }

        public bool xoaKT(String maKT)
        {
            return dal_KT.xoaKT(maKT);
        }
        public DataTable KT()
        {
            return dal_KT.KT();
        }

    }
}
