using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_PCGD
    {
        private string lopMH;
        public string LopMH
        {
            get { return lopMH; }
            set { lopMH = value; }
        }
        private string maMH;
        public string MaMH
        {
            get { return maMH; }
            set { maMH = value; }
        }
        private string maLop;
        public string MaLop
        {
            get { return maLop; }
            set { maLop = value; }

        }
        private string maGV;
        public string MaGV
        {
            get { return maGV; }
            set { maGV = value; }
        }
        private string namHoc;

        public string NamHoc
        {
            get { return namHoc; }
            set { namHoc = value; }
        }
        private string hocKy;
        public string HocKy
        {
            get { return hocKy; }
            set { hocKy = value; }
        }
        
        public DTO_PCGD(string plopMH, string pmaMH, string pmaLop, string pmaGV,string pnamHoc,string phocKy)
        {
            this.lopMH = plopMH;
            this.maMH = pmaMH;
            this.maLop = pmaLop;
            this.maGV = pmaGV;
            this.namHoc = pnamHoc;
            this.hocKy = phocKy;
        }
    }
}
