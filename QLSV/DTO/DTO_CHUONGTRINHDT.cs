using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CHUONGTRINHDT
    {
        private string maNganh;
        public string MaNganh
        {
            get { return maNganh; }
            set { maNganh = value; }
        }
        private string maMH;

        public string MaMH
        {
            get { return maMH; }
            set { maMH = value; }
        }
        private string kyThu ;

        public string KyThu
        {
            get { return kyThu; }
            set { kyThu = value; }
        }
        
        

        public DTO_CHUONGTRINHDT(string pmaNganh, string pmaMH,string pkyThu)
        {
            this.maMH = pmaMH;
            this.maNganh = pmaNganh;
            this.kyThu = pkyThu;
        }
    }
}
