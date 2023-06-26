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

    public class Dal_ChuyenNganh:connect
    {
        SqlDataAdapter adap;
        DataTable dt;

        public bool kiemtratontai(String MaNganh)
        {
            bool tatkt = false;
            adap = new SqlDataAdapter("Select* from CHUYENNGANH where MaNganh='" + MaNganh + "'", dbConn);
            dt = new DataTable();
            adap.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                tatkt = true;
            }
            adap.Dispose();
            return tatkt;
        }
        public DataTable Nganh()
        {
            string cmd = "SELECT * FROM CHUYENNGANH";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }

        public bool themNganh(DTO_ChuyenNganh pNganh)
        {
            dbConn.Open();
            string cmd = "INSERT INTO CHUYENNGANH VALUES(N'" + pNganh.MaNganh + "',N'" + pNganh.TenNganh + "',N'" + pNganh.MaKhoa + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool suaNganh(DTO_ChuyenNganh pNganh)
        {
            dbConn.Open();
            string cmd = "UPDATE CHUYENNGANH SET TENNGANH=N'" + pNganh.TenNganh + "', MAKHOA=N'" + pNganh.MaKhoa + "'  WHERE MANGANH='" + pNganh.MaNganh + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool xoaNganh(String maNganh)
        {
            dbConn.Open();
            string cmd = "DELETE FROM CHUYENNGANH WHERE MANGANH='" + maNganh + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }

        public DataTable SinhVien_DS()
        {
            string cmd = "SELECT SINHVIEN.MASV, HOTENSV, TENLOP, GIOITINH , NGAYSINH , DIACHI FROM SINHVIEN,LOP,KHOA,CHUYENNGANH  WHERE (SINHVIEN.MALOP=LOP.MALOP) and (CHUYENNGANH.MAKHOA=KHOA.MAKHOA)";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public DataTable SinhVien_DSLop(String maNganh)
        {
            string cmd = "SELECT SINHVIEN.MASV, HOTENSV, LOP.TENLOP, TENKHOA, GIOITINH ,NGAYSINH,DIACHI FROM SINHVIEN,LOP  WHERE (SINHVIEN.MALOP=LOP.MALOP) and (CHUYENNGANH.MAKHOA=KHOA.MAKHOA) and CHUYENNGANH.MANGANH='" + maNganh + "'";
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

    }
}
