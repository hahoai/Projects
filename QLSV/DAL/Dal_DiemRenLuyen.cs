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
   public class Dal_DiemRenLuyen : connect
    {
        SqlDataAdapter da;
        DataTable dt;
        public DataTable DS_SV()
        {
            string cmd = "SELECT SINHVIEN.MASV, SINHVIEN.HOTENSV, DIEMRENLUYEN.HOCKY,DIEMRENLUYEN.DIEM FROM SINHVIEN INNER JOIN DIEMRENLUYEN ON SINHVIEN.MASV=DIEMRENLUYEN.MASV";
            da = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool kiemtratontai(String MaSV,string HocKy)
        {
            bool tatkt = false;
            da = new SqlDataAdapter("Select* from DIEMRENLUYEN where MaSV='" + MaSV + "' AND HOCKY='"+HocKy+"'", dbConn);
            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                tatkt = true;
            }
            da.Dispose();
            return tatkt;
        }
        public bool themGV(DTO_DiemRenLuyen pdrl)
        {
            dbConn.Open();
            string cmd = "INSERT INTO GIAOVIEN VALUES(N'" + pdrl.MaSV + "',N'" + pdrl.HocKy + "','"+pdrl.Diem+"')";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool suaDiemRL(DTO_DiemRenLuyen pdrl)
        {
            dbConn.Open();
            string cmd = "UPDATE DIEM SET DIEMCC='" + pdrl.Diem + "'  WHERE MASV='" + pdrl.MaSV + "' and HOCKY='" + pdrl.HocKy + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool xoaGV(String maGV)
        {
            dbConn.Open();
            string cmd = "DELETE FROM GIAOVIEN WHERE MAGV='" + maGV + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
    }
}
