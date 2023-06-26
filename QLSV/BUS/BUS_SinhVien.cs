﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_SinhVien
    {
        Dal_SinhVien dal_SV = new Dal_SinhVien();


        public bool themSV(DTO_SinhVien sv)
        {
            return dal_SV.themSV(sv);
        }

        public bool suaSV(DTO_SinhVien sv)
        {
            return dal_SV.suaSV(sv);
        }

        public bool xoaSV(String maSV)
        {
            return dal_SV.xoaSV(maSV);
        }
        public DataTable timkiemSV(String maSV)
        {
            return dal_SV.timkiemSV(maSV);
        }
        public DataTable SinhVien()
        {
            return dal_SV.SinhVien();
        }

        public DataTable sinhVien_Lop(string maLop)
        {
            return dal_SV.sinhVien_Lop(maLop);
        }

        public DataTable Lop()
        {
            return dal_SV.Lop();
        }
        public bool kiemtratontai(String maSV)
        {
            return dal_SV.kiemtratontai(maSV);
        }
    }
}
