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
    public class BUS_GiaoVien
    {
        Dal_GiaoVien dal_GV = new Dal_GiaoVien();

        public bool themGV(DTO_GiaoVien pGV)
        {
            return dal_GV.themGV(pGV);
        }

        public bool suaGV(DTO_GiaoVien pGV)
        {
            return dal_GV.suaGV(pGV);
        }

        public bool xoaGV(String maGV)
        {
            return dal_GV.xoaGV(maGV);
        }
        public bool kiemtratontai(String maGV)
        {
            return dal_GV.kiemtratontai(maGV);
        }

        public DataTable GV()
        {
            return dal_GV.GV_DS();
        }
    }
}
