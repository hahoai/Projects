using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_Diem
    {
        Dal_Diem dal_di = new Dal_Diem();

        //thêm KT
       
        public DataTable LopMH()
        {
            return dal_di.LopMH();
        }
        public DataTable Diem()
        {
            return dal_di.DIEM();
        }

        public DataTable SinhVien_DSMH(String maMH)
        {
            return dal_di.SinhVien_DSMH(maMH);
        }
        public DataTable SinhVien_DSLOP_MH(String maMH,String maLop)
        {
            return dal_di.SinhVien_DSLOP_MH(maMH,maLop);
        }
        public DataTable DS_SV()
        {
            return dal_di.DS_SV();
        }
    }
}
