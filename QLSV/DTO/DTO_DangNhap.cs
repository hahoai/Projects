using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DangNhap
    {
        private string quyen;

        public string Quyen
        {
            get { return quyen; }
            set { quyen = value; }
        }
        private string hoTen;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        private string tenDN;

        public string TenDN
        {
            get { return tenDN; }
            set { tenDN = value; }
        }
        private string MK;

        public string MK1
        {
            get { return MK; }
            set { MK = value; }
        }
        public DTO_DangNhap(string pTenDN, string pMK,string pHoTen, string pQuyen )
        {
            this.tenDN = pTenDN;
            this.MK = pMK;
            this.hoTen = pHoTen;
            this.quyen = pQuyen;
        }
        public DTO_DangNhap()
        {
            this.tenDN = "";
            this.MK = "";
            this.hoTen = "";
            this.quyen = ""; 
           
        }
    }
}
