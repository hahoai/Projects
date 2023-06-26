using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Dal_TrangThai:connect
    {

        SqlDataAdapter adap;
        DataTable dt;
        public DataTable TrangThai()
        {
            string cmd = "SELECT * FROM TRANGTHAI";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }

        public bool themTT(DTO_TrangThai pTT)
        {
            dbConn.Open();
            string cmd = "INSERT INTO TRANGTHAI VALUES(N'" + pTT.MaTT + "',N'" + pTT.TenTT + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool suaTT(DTO_TrangThai pTT)
        {
            dbConn.Open();
            string cmd = "UPDATE TRANGTHAI SET TENTT=N'" + pTT.TenTT + "' WHERE MATT='" + pTT.MaTT + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool xoaTT(String maTT)
        {
            dbConn.Open();
            string cmd = "DELETE FROM TRANGTHAI WHERE MATT='" + maTT + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
    }
}
