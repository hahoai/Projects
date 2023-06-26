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
   public class BUS_KyLuat
    {
        Dal_KyLuat dal_KL = new Dal_KyLuat();
        public bool themKL(DTO_KyLuat pKL)
        {
            return dal_KL.themKL(pKL);
        }

        public bool suaKL(DTO_KyLuat pKL)
        {
            return dal_KL.suaKL(pKL);
        }

        public bool xoaKL(String maKL)
        {
            return dal_KL.xoaKL(maKL);
        }
        public DataTable KL()
        {
            return dal_KL.KL();
        }

    }
}
