using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_QTKhenThuong
    {
        private string maSV;

        public string MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }
        private string hocKy;

        public string HocKy
        {
            get { return hocKy; }
            set { hocKy = value; }
        }
        private string loaiKT;

        public string LoaiKT
        {
            get { return loaiKT; }
            set { loaiKT = value; }
        }
        private string soQD;

        public string SoQD
        {
            get { return soQD; }
            set { SoQD = value; }
        }
        private string ngayQD;

        public string NgayQD
        {
            get { return ngayQD; }
            set { ngayQD = value; }
        }
        
        private string hinhThuc;

        public string HinhThuc
        {
            get { return hinhThuc; }
            set { hinhThuc = value; }
        }
        public DTO_QTKhenThuong(string pmaSV, string phocKy, string ploaiKT, string psoQD, string pngayQD, string phinhThuc)
        {
            this.maSV = pmaSV;
            this.hocKy = phocKy;
            this.loaiKT = ploaiKT;
            this.soQD = psoQD;
            this.ngayQD = pngayQD;
            this.HinhThuc = phinhThuc;

        }
    }
}
