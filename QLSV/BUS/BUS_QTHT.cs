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
   public class BUS_QTHT
    {
        Dal_QTHT dal_QTHT = new Dal_QTHT();
        
         public DataTable TrangThai1()
        {
            return dal_QTHT.TrangThai1();
        }
        public DataTable TrangThai2()
        {
            return dal_QTHT.TrangThai2();
        }
        public DataTable TrangThai3()
        {
            return dal_QTHT.TrangThai3();
        }
        public DataTable TrangThai4()
        {
            return dal_QTHT.TrangThai4();
        }
        public DataTable TrangThai5()
        {
            return dal_QTHT.TrangThai5();
        }
        public DataTable TrangThai6()
        {
            return dal_QTHT.TrangThai6();
        }
        public DataTable TrangThai7()
        {
            return dal_QTHT.TrangThai7();
        }
        public DataTable TrangThai8()
        {
            return dal_QTHT.TrangThai8();
        }
        public DataTable TrangThai9()
        {
            return dal_QTHT.TrangThai9();
        }
        public bool kt(string MaSV, string NamHoc,string TrangThai)
        {
            return dal_QTHT.kiemtratontai(MaSV, NamHoc, TrangThai);
        }
        public bool themQTHT(DTO_QTHT pQTHT)
        {
            return dal_QTHT.themQTHT(pQTHT);
        }

        public bool suaQTHT(DTO_QTHT pQTHT)
        {
            return dal_QTHT.suaQTHT(pQTHT);
        }

        public bool xoaQTHT(String maSV, String namHoc, String lop, String trangThai)
        {
            return dal_QTHT.xoaQTHT(maSV, namHoc, lop , trangThai);
        }
        public DataTable QTHT1(String maSV,String namHoc )
        {
            return dal_QTHT.QTHT1(maSV,namHoc);
        }
        public DataTable QTHT()
        {
            return dal_QTHT.QTHT();
        }
        public DataTable TIMKIEM(String maSV)
        {
            return dal_QTHT.TIMKIEM(maSV);
        }
        public DataTable TrangThai()
        {
            return dal_QTHT.TrangThai();
        }
        public DataTable Lop()
        {
            return dal_QTHT.Lop();
        }
    }
}
