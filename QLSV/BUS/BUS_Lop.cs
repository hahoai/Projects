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
    public class BUS_Lop
    {
        Dal_Lop dal_Lop = new Dal_Lop();

        public bool themLop(DTO_Lop pLop)
        {
            return dal_Lop.themLop(pLop);
        }

        public bool suaLop(DTO_Lop pLop)
        {
            return dal_Lop.suaLop(pLop);
        }

        public bool xoaLop(String maLop)
        {
            return dal_Lop.xoaLop(maLop);
        }
        public bool kiemtratontai(String maLop)
        {
            return dal_Lop.kiemtratontai(maLop);
        }
        public DataTable LOP()
        {
            return dal_Lop.LOP();
        }
        public DataTable Nganh()
        {
            return dal_Lop.Nganh_DS();
        }
        public DataTable DS_SVLOP(string maLop)
        {
            return dal_Lop.SinhVien_DSLop(maLop);
        }
    }
}
