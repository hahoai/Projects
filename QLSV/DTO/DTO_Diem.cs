using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Diem
    {
        private string maSV;

        public string MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }


        private string maMH;

        public string MaMH
        {
            get { return maMH; }
            set { maMH = value; }
        }
        
        private string diemCC;

        public string DiemCC
        {
            get { return diemCC; }
            set { diemCC = value; }
        }
        private string diemKT1;

        public string DiemKT1
        {
            get { return diemKT1; }
            set { diemKT1 = value; }
        }
        
        private string diemThi;

        public string DiemThi
        {
            get { return diemThi; }
            set { diemThi = value; }
        }


        public DTO_Diem(string pmaSV, string pmaMH, string pdiemCC, string pdiemKT1, string pdiemThi)
        {
            this.maSV = pmaSV;
            this.maMH = pmaMH;
            this.diemCC = pdiemCC;
            this.diemKT1 = pdiemKT1;
            this.diemThi = pdiemThi;
        }
    }
}
