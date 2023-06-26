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
   public class BUS_QTKyLuat
    {
        Dal_QTKyLuat dal_QTKL = new Dal_QTKyLuat();
        public bool themQTKL(DTO_QTKyLuat pQTKL)
        {
            return dal_QTKL.themQTKL(pQTKL);
        }

        public bool suaQTKL(DTO_QTKyLuat pQTKL)
        {
            return dal_QTKL.suaQTKL(pQTKL);
        }

        public bool xoaQTKL(String maSV,  String hocKy, String maKL)
        {
            return dal_QTKL.xoaQTKL(maSV, hocKy, maKL);
        }
        public DataTable QTKL()
        {
            return dal_QTKL.QTKYLUAT();
        }
        public DataTable LoaiKL()
        {
            return dal_QTKL.LoaiKL();
        }
    }
}
