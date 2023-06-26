using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_GiaoVien
    {
        private string maGV;
        public string MaGV
        {
            get { return maGV; }
            set { maGV = value; }
        }
        private string tenGV;

        public string TenGV
        {
            get { return tenGV; }
            set { tenGV = value; }
        }
        public DTO_GiaoVien(string pmaGV, string ptenGV)
        {
            this.maGV = pmaGV;
            this.tenGV = ptenGV;
        }
    }
}
