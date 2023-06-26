using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
   public class Dal_KyLuat: connect
    {
        SqlDataAdapter adap;
        DataTable dt;
        public DataTable KL()
        {
            string cmd = "SELECT * FROM KYLUAT";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }

        public bool themKL(DTO_KyLuat pKL)
        {
            dbConn.Open();
            string cmd = "INSERT INTO KYLUAT VALUES(N'" + pKL.MaKL + "',N'" + pKL.TenKL + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool suaKL(DTO_KyLuat pKL)
        {
            dbConn.Open();
            string cmd = "UPDATE KYLUAT SET TENKL=N'" + pKL.TenKL + "' WHERE MAKL='" + pKL.MaKL + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool xoaKL(String maKL)
        {
            dbConn.Open();
            string cmd = "DELETE FROM KYLUAT WHERE MAKL='" + maKL + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
    }
}
