using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_DiemRenLuyen
    {
        private string maSV;
        public string MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }
        private string diem;

        public string Diem
        {
            get { return diem; }
            set { diem = value; }
        }
        private string hocKy;

        public string HocKy
        {
            get { return hocKy; }
            set { hocKy = value; }
        }
        public DTO_DiemRenLuyen(string pmaSV, string pdiem, string phocKy)
        {
            this.maSV = pmaSV;
            this.diem = pdiem;
            this.hocKy = phocKy;
            
        }
    }
}
