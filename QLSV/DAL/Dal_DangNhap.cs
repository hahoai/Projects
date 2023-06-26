using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Dal_DangNhap:connect
    {
        SqlDataAdapter adap;
        DataTable dt;

        public DataTable DangNhap()
        {
            adap = new SqlDataAdapter("SELECT * FROM DANGNHAP", dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            dbConn.Close();
            return dt;
        }
        
        public bool kiemtratontai(String tenDN)
        {
            bool tatkt = false;
            adap = new SqlDataAdapter("Select* from DANGNHAP where tenDangNhap='" + tenDN + "'", dbConn);
            dt = new DataTable();
            adap.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                tatkt = true;
            }
            adap.Dispose();
            return tatkt;
        }

        public bool themDN(DTO_DangNhap pDN)
        {
            dbConn.Open();
            string cmd = "INSERT INTO DANGNHAP VALUES(N'" + pDN.TenDN + "',N'" + pDN.MK1 + "',N'" + pDN.HoTen + "',N'"+pDN.Quyen+"')";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool suaDN(DTO_DangNhap pDN)
        {
            dbConn.Open();
            string cmd = "UPDATE DANGNHAP SET matKhau='" + pDN.MK1 + "', hoTen=N'" + pDN.HoTen + "', quyen=N'"+ pDN.Quyen+"' WHERE tenDangNhap=N'" + pDN.TenDN + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool xoaDN(String TenDN)
        {
            dbConn.Open();
            string cmd = "DELETE FROM DANGNHAP WHERE tenDangNhap='" + TenDN + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
    }
}
