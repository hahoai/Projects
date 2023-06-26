using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChuyenNganh
    {
        private string maNganh;

        public string MaNganh
        {
            get { return maNganh; }
            set { maNganh = value; }
        }
        private string tenNganh;

        public string TenNganh
        {
            get { return tenNganh; }
            set { tenNganh = value; }
        }
        
        private string maKhoa;

        public string MaKhoa
        {
            get { return maKhoa; }
            set { maKhoa = value; }
        }
        public DTO_ChuyenNganh(string pmaNganh,string ptenNganh, string pmaKhoa)
        {
            this.maNganh = pmaNganh;
            this.tenNganh = ptenNganh;
            
            this.maKhoa = pmaKhoa;
        }
        public DTO_ChuyenNganh()
        {
            this.maNganh = "";
            this.tenNganh = "";
            this.maKhoa = "";
        }
    }
}
