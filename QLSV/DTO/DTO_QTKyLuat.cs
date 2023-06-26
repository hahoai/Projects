using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_QTKyLuat
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
        private string loaiKL;

        public string LoaiKL
        {
            get { return loaiKL; }
            set { loaiKL = value; }
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
        public DTO_QTKyLuat(string pmaSV, string phocKy, string ploaiKL, string psoQD, string pngayQD, string phinhThuc)
        {
            this.maSV = pmaSV;
            this.hocKy = phocKy;
            this.loaiKL = ploaiKL;
            this.soQD = psoQD;
            this.ngayQD = pngayQD;
            this.HinhThuc = phinhThuc;

        }
    }
}
