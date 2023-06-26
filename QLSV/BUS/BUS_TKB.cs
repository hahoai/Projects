using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
   public class BUS_TKB
    {
        Dal_TKB dal_TKB = new Dal_TKB();

        public bool themTKB(DTO_TKB pTKB)
        {
            return dal_TKB.themTKB(pTKB);
        }

        public bool suaTKB(DTO_TKB pTKB)
        {
            return dal_TKB.suaTKB(pTKB);
        }

        public bool xoaTKB(String lopMH)
        {
            return dal_TKB.xoaTKB(lopMH);
        }
        public bool lopmh1(String maLop,string hocKy)
        {
            return dal_TKB.LOPMH(maLop,hocKy);
        }
        public DataTable ThoiKhoaBieu()
        {
            return dal_TKB.ThoiKhoaBieu();
        }
        public DataTable LopMH()
        {
            return dal_TKB.PCGD();
        }
        public DataTable Lop()
        {
            return dal_TKB.Lop();
        }

    }
}
