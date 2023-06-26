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
   public class Dal_KhenThuong: connect
    {
        SqlDataAdapter adap;
        DataTable dt;
        public DataTable KT()
        {
            string cmd = "SELECT * FROM KHENTHUONG";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }

        public bool themKT(DTO_KhenThuong pKT)
        {
            dbConn.Open();
            string cmd = "INSERT INTO KHENTHUONG VALUES(N'" + pKT.MaKT + "',N'" + pKT.TenKT + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool suaKT(DTO_KhenThuong pKT)
        {
            dbConn.Open();
            string cmd = "UPDATE KHENTHUONG SET TENKT=N'" + pKT.TenKT + "' WHERE MAKT='" + pKT.MaKT + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool xoaKT(String maKT)
        {
            dbConn.Open();
            string cmd = "DELETE FROM KHENTHUONG WHERE MAKT='" + maKT + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
    }
}
