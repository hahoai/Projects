using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class connect
    {
       public SqlConnection dbConn = new SqlConnection(@"Data Source=DESKTOP-SOJM7CD\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");

    }
}
