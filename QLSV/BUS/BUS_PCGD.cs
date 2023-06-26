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
   public class BUS_PCGD
    {
        Dal_PCGD PC = new Dal_PCGD();
        public bool themPCGD(DTO_PCGD pPCGD)
        {
            return PC.themPCGD(pPCGD);
        }
        public bool suaPCGD(DTO_PCGD pPCGD)
        {
            return PC.suaPCGD(pPCGD);
        }
        public bool xoaPCGD(string lopMH)
        {
            return PC.xoaPCGD(lopMH);
        }
        public bool kiemtratontai(string lopMH, string maMH, string maLop)
        {
            return PC.kiemtratontai(lopMH, maMH, maLop);
        }

        public DataTable MonHoc()
        {
            return PC.MonHoc();
        }
        public DataTable CTDT ()
        {
            return PC.CTDT();
        }
        public DataTable ChuyenNganh()
        {
            return PC.ChuyenNganh();
        }
        public DataTable MonHoc1(string maNganh)
        {
            return PC.MonHoc1(maNganh);
        }
        public DataTable Lop()
        {
            return PC.Lop();
        }
        public DataTable Lop1(string maNganh)
        {
            return PC.Lop1(maNganh);
        }
        public DataTable GiaoVien()
        {
            return PC.GiaoVien();
        }
        public DataTable PCGD()
        {
            return PC.PCGD();
        }
        public DataTable PCGD1(string MaLop)
        {
            return PC.PCGD1(MaLop);
        }
    }
}
