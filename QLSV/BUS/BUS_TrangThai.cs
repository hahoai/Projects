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
   public class BUS_TrangThai
    {
        Dal_TrangThai dal_TT = new Dal_TrangThai();
        public DataTable TrangThai()
        {
            return dal_TT.TrangThai();
        }
        public bool themTT(DTO_TrangThai pTT)
        {
            return dal_TT.themTT(pTT);
        }

        public bool suaTT(DTO_TrangThai pTT)
        {
            return dal_TT.suaTT(pTT);
        }

        public bool xoaTT(String maTT)
        {
            return dal_TT.xoaTT(maTT);
        }
    }
}
