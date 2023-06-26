using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_QTHT
    {
        private string maSV;

        public string MaSV
        {
            get { return maSV; }
            set { MaSV = value; }
        }
        private string namHoc;

        public string NamHoc
        {
            get { return namHoc; }
            set { namHoc = value; }
        }
        private string lop;

        public string Lop
        {
            get { return lop; }
            set { lop = value; }
        }

        private string trangThai;

        public string TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
        private string soQD;

        public string SoQD
        {
            get { return soQD; }
            set { soQD = value; }
        }
        public DTO_QTHT(string pmaSV,string psoQD, string pnamHoc,string plop, string ptrangThai)
        {
            this.maSV = pmaSV;
            this.soQD = psoQD;
            this.namHoc = pnamHoc;
            this.lop = plop;
            this.trangThai = ptrangThai;
        }
    }
}
