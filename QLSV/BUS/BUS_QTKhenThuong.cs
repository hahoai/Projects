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
     public class BUS_QTKhenThuong
    {
        Dal_QTKhenThuong dal_QTKT = new Dal_QTKhenThuong();
        public bool themQTKT(DTO_QTKhenThuong pQTKT)
        {
            return dal_QTKT.themQTKT(pQTKT);
        }

        public bool suaQTKT(DTO_QTKhenThuong pQTKT)
        {
            return dal_QTKT.suaQTKT(pQTKT);
        }

        public bool xoaQTKT(String maSV, String maKT, String hocKy)
        {
            return dal_QTKT.xoaQTKT(maSV, maKT, hocKy);
        }
        public DataTable QTKT()
        {
            return dal_QTKT.QTKHENTHUONG();
        }
        public DataTable LoaiKT()
        {
            return dal_QTKT.LoaiKT();
        }
    }
}
