using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TrangThai
    {
        private string maTT;
        public string MaTT
        {
            get { return maTT; }
            set { maTT = value; }
        }
        private string tenTT;

        public string TenTT
        {
            get { return tenTT; }
            set { tenTT = value; }
        }
        public DTO_TrangThai(string pmaTT, string ptenTT)
        {
            this.maTT = pmaTT;
            this.tenTT = ptenTT;
        }
        }
}
