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
    public class Dal_SinhVien:connect
    {
        SqlDataAdapter adap;
        DataTable dt;

        public DataTable SinhVien()
        {
            adap = new SqlDataAdapter("SELECT * FROM SINHVIEN", dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            dbConn.Close();
            return dt;
        }

        public DataTable sinhVien_Lop(string maLop)
        {
            adap = new SqlDataAdapter("SELECT * FROM SINHVIEN where MALOP='"+maLop+"'", dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable Lop()
        {
            string cmd = "SELECT * FROM LOP";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public DataTable Khoa()
        {
            string cmd = "SELECT * FROM KHOA";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public DataTable Nganh()
        {
            string cmd = "SELECT * FROM CHUYENNGANH";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public DataTable timkiemSV(String maSV)
        {
            string cmd = "Select* FROM SINHVIEN WHERE MASV like '%" + maSV + "%' ";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public bool themSV(DTO_SinhVien sv)
        {
            dbConn.Open();
            string cmd = "INSERT INTO SINHVIEN VALUES('" + sv.MaSV + "',N'" + sv.HoTenSV + "',  '" + sv.NgaySinh + "', N'" + sv.GioiTinh + "', N'" + sv.DiaChi + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool suaSV(DTO_SinhVien sv)
        {
            dbConn.Open();
            string cmd = "UPDATE SINHVIEN SET HOTENSV=N'" + sv.HoTenSV + "', NGAYSINH='" + sv.NgaySinh + "', GIOITINH=N'" + sv.GioiTinh + "', DIACHI=N'" + sv.DiaChi + "' WHERE MASV='" + sv.MaSV + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool xoaSV(String maSV)
        {
            dbConn.Open();
            string cmd = "DELETE FROM SINHVIEN WHERE MASV='" + maSV + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        
        public bool kiemtratontai(String MaSV)
        {
            bool tatkt = false;
            adap = new SqlDataAdapter("Select * from SINHVIEN where MaSV='" + MaSV + "'", dbConn);
            dt = new DataTable();
            adap.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                tatkt = true;
            }
            adap.Dispose();
            return tatkt;
        }
    }
}
