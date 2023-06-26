using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SinhVien
    {
        private string maSV;

        public string MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }
        private string hotenSV;
        public string HoTenSV
        {
            get { return hotenSV; }
            set { hotenSV = value; }
        }
        
        private string maLop;

        public string MaLop
        {
            get { return maLop; }
            set { maLop = value; }
        }
        
        private string ngaySinh;

        public string NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        private string gioiTinh;

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        private string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        

        public DTO_SinhVien(string pmaSV, string photenSV, string pngaySinh, string pgioiTinh, string pdiaChi)
        {
            this.maSV = pmaSV;
            this.hotenSV = photenSV;
            this.ngaySinh = pngaySinh;
            this.gioiTinh = pgioiTinh;
            this.diaChi = pdiaChi;
        }
    }
}
