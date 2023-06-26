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
   public class Dal_QTKhenThuong: connect
    {
        SqlDataAdapter adap;
        DataTable dt;
        public DataTable QTKHENTHUONG()
        {
            string cmd = "SELECT * FROM QTKHENTHUONG";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public DataTable LoaiKT()
        {
            string cmd = "SELECT * FROM KHENTHUONG";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public bool themQTKT(DTO_QTKhenThuong pQTKT)
        {
            dbConn.Open();
            string cmd = "INSERT INTO QTKHENTHUONG VALUES('" + pQTKT.MaSV + "','" + pQTKT.HocKy + "',N'" + pQTKT.LoaiKT + "','" + pQTKT.SoQD + "', '" + pQTKT.NgayQD + "',  N'" + pQTKT.HinhThuc + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool suaQTKT(DTO_QTKhenThuong pQTKT)
        {
            dbConn.Open();
            string cmd = "UPDATE QTKHENTHUONG SET HOCKY='" + pQTKT.HocKy + "',MAKT=N'" + pQTKT.LoaiKT + "',SOQUYETDINH='" + pQTKT.SoQD + "', NGAYQUYETDINH='" + pQTKT.NgayQD + "', HINHTHUC=N'" + pQTKT.HinhThuc + "' WHERE MASV='" + pQTKT.MaSV + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool xoaQTKT(String maSV, String hocKy, String maKT )
        {
            dbConn.Open();
            string cmd = "DELETE FROM QTKHENTHUONG WHERE MASV='" + maSV + "'  and HOCKY='" + hocKy + "' and MAKT='" + maKT + "' ";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }

    }
}
