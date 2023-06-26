using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
   public class DTO_TKB
    {
        private string lopMH;
        public string LopMH
        {
            get { return lopMH; }
            set { lopMH = value; }
        }
        private string ngayBD;
        public string NgayBD
        {
            get { return ngayBD; }
            set { ngayBD = value; }
        }
        private string ngayKT;
        public string NgayKT
        {
            get { return ngayKT; }
            set { ngayKT = value; }
        }
        private string thu;
        public string Thu
        {
            get { return thu; }
            set { thu = value; }
        }
        private string tietBD;
        public string TietBD
        {
            get { return tietBD; }
            set { tietBD = value; }
        }
        private string tietKT;
        public string TietKT
        {
            get { return tietKT; }
            set { tietKT = value; }
        }

        private string phong;
        public string Phong
        {
            get { return phong; }
            set { phong = value; }
        }
        public DTO_TKB(string plopMH, string pngayBD, string pngayKT, string pphong, string ptietBD,string ptietKT, string pthu)
        {
            this.lopMH = plopMH;
            this.ngayBD = pngayBD;
            this.ngayKT = pngayKT;
            this.phong = pphong;
            this.tietBD = ptietBD;
            this.tietKT = ptietKT;
            this.thu = pthu;
            
        }
    }
}
