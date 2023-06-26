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
   public class Dal_QTKyLuat:connect
    {
        SqlDataAdapter adap;
        DataTable dt;
        public DataTable QTKYLUAT()
        {
            string cmd = "SELECT * FROM QTKYLUAT";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public DataTable LoaiKL()
        {
            string cmd = "SELECT * FROM KYLUAT";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public bool themQTKL(DTO_QTKyLuat pQTKL)
        {
            dbConn.Open();
            string cmd = "INSERT INTO QTKYLUAT VALUES('" + pQTKL.MaSV + "','" + pQTKL.HocKy + "','" + pQTKL.LoaiKL + "','" + pQTKL.SoQD + "', '" + pQTKL.NgayQD + "',  N'" + pQTKL.HinhThuc + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool suaQTKL(DTO_QTKyLuat pQTKL)
        {
            dbConn.Open();
            string cmd = "UPDATE QTKYLUAT SET HOCKY='" + pQTKL.HocKy + "',MAKL=N'" + pQTKL.LoaiKL + "',SOQD='" + pQTKL.SoQD + "', NGAYQD='" + pQTKL.NgayQD + "', HINHTHUC=N'" + pQTKL.HinhThuc + "' WHERE MASV='" + pQTKL.MaSV + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool xoaQTKL(String maSV, String hocKy, String maKL)
        {
            dbConn.Open();
            string cmd = "DELETE FROM QTKYLUAT WHERE MASV='" + maSV + "'  and HOCKY='" + hocKy + "' and MAKL='" + maKL + "' ";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }

    }
}
