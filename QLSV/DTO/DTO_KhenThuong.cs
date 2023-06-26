using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_KhenThuong
    {
        private string maKT;

        public string MaKT
        {
            get { return maKT; }
            set { maKT = value; }
        }
        private string tenKT;

        public string TenKT
        {
            get { return tenKT; }
            set { tenKT = value; }
        }
        public DTO_KhenThuong(string pmaKT, string ptenKT)
        {
            this.maKT = pmaKT;
            this.tenKT = ptenKT;
            
        }
    }
}
