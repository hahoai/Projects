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
    public class BUS_CHUONGTRINHDT
    {
        Dal_CHUONGTRINHDT dal_ChiTiet = new Dal_CHUONGTRINHDT();
        
        public DataTable MonHoc1(string maNganh)
        {
            return dal_ChiTiet.MonHoc1(maNganh);
        }
        public DataTable MonHoc()
        {
            return dal_ChiTiet.MonHoc();
        }
        public bool themCTDT(DTO_CHUONGTRINHDT pCTDT)
        {
            return dal_ChiTiet.themCTDT(pCTDT);
        }

        public bool suaCTDT(DTO_CHUONGTRINHDT pCTDT)
        {
            return dal_ChiTiet.suaCTDT(pCTDT);
        }

        public bool xoaCTDT(String maNganh, String maMH)
        {
            return dal_ChiTiet.xoaCTDT(maNganh, maMH);
        }
        
        public bool kiemtratontai(String maMH,String maNganh)
        {
            return dal_ChiTiet.kiemtratontai(maMH, maNganh);
        }

        public DataTable Nganh()
        {
            return dal_ChiTiet.Nganh();
        }
        public DataTable ChiTietCTDT()
        {
            return dal_ChiTiet.ChiTietCTDT();
        }
    }
}
