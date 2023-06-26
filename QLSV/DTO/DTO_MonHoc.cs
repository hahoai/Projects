using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_MonHoc
    {
        private string maMonHoc;

        public string MaMonHoc
        {
            get { return maMonHoc; }
            set { maMonHoc = value; }
        }


        private string tenMonHoc;

        public string TenMonHoc
        {
            get { return tenMonHoc; }
            set { tenMonHoc = value; }
        }
        private string sotiet;

        public string SoTiet
        {
            get { return sotiet; }
            set { sotiet = value; }
        }
        private string soTinChi;

        public string SoTinChi
        {
            get { return soTinChi; }
            set { soTinChi = value; }
        }
        
        private string maNganh;

        public string MaNganh
        {
            get { return maNganh; }
            set { maNganh = value; }
        }
        private string monChung;
        public string MonChung
        {
            get { return monChung; }
            set { monChung = value; }
        }


        public DTO_MonHoc(string pmaMonHoc, string ptenMonHoc, string psoTiet, string psoTinChi, string pmaNganh,string pmonChung)
        {
            this.maMonHoc = pmaMonHoc;
            this.tenMonHoc = ptenMonHoc;
            this.SoTiet = psoTiet;
            this.soTinChi = psoTinChi;
            this.maNganh = pmaNganh;
            this.monChung = pmonChung;
            
        }
    }
}
