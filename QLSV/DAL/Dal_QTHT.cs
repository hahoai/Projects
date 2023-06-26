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
   public class Dal_QTHT : connect
    {
        SqlDataAdapter adap;
        DataTable dt;

        public DataTable QTHT1(String maSV, String namHoc)
        {
            string cmd = @"SELECT SINHVIEN.MASV, SINHVIEN.HOTENSV,QTHT.SOQD,QTHT.NAMHOC,QTHT.LOP,QTHT.TRANGTHAI,(SUM((DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)*SOTINCHI)/(SELECT sum(SOTINCHI) FROM PHANCONGGD INNER JOIN DIEM ON DIEM.LOPMH=PHANCONGGD.LOPMH INNER JOIN 
CHUONGTRINHDT ON CHUONGTRINHDT.MAMH=PHANCONGGD.MAMH INNER JOIN MONHOC ON MONHOC.MAMH= CHUONGTRINHDT.MAMH WHERE DIEM.MASV='" + maSV + "' AND CHUONGTRINHDT.NAMHOC = '"+namHoc+"')) AS DIEMTBC FROM SINHVIEN INNER JOIN LOP ON SINHVIEN.MALOP = LOP.MALOP INNER JOIN CHUYENNGANH ON CHUYENNGANH.MANGANH = LOP.MANGANH INNER JOIN CHUONGTRINHDT ON CHUYENNGANH.MANGANH = CHUONGTRINHDT.MANGANH INNER JOIN MONHOC ON MONHOC.MAMH = CHUONGTRINHDT.MAMH INNER JOIN PHANCONGGD ON PHANCONGGD.MALOP = LOP.MALOP AND MONHOC.MAMH = PHANCONGGD.MAMH INNER JOIN DIEM ON DIEM.MASV = SINHVIEN.MASV AND PHANCONGGD.LOPMH = DIEM.LOPMH INNER JOIN QTHT ON SINHVIEN.MASV = QTHT.MASV AND QTHT.NAMHOC = CHUONGTRINHDT.NAMHOC WHERE SINHVIEN.MASV = '"+maSV+"'  AND(dbo.CHUONGTRINHDT.NAMHOC = '"+namHoc+"') GROUP BY  SINHVIEN.MASV, SINHVIEN.HOTENSV,QTHT.SOQD,QTHT.NAMHOC,QTHT.LOP,QTHT.TRANGTHAI";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public bool kiemtratontai(string MaSV,string NamHoc,string TrangThai)
        {
            bool tatkt = false;
            adap = new SqlDataAdapter("Select * from QTHT where MaSV='" + MaSV + "'AND NAMHOC='" + NamHoc + "' AND  TRANGTHAI=N'" + TrangThai + "' ", dbConn);
            dt = new DataTable();
            adap.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                tatkt = true;
            }
            adap.Dispose();
            return tatkt;
        }
        public DataTable TIMKIEM(String maSV )
        {
            string cmd = "SELECT QTHT.*, SINHVIEN.HOTENSV  FROM QTHT INNER JOIN SINHVIEN ON QTHT.MASV=SINHVIEN.MASV WHERE QTHT.MASV LIKE '%" + maSV+"%' ";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public DataTable QTHT()
        {
            string cmd = "SELECT QTHT.*, SINHVIEN.HOTENSV  FROM QTHT INNER JOIN SINHVIEN ON QTHT.MASV=SINHVIEN.MASV";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }

        public DataTable TrangThai()
        {
            string cmd = "SELECT * FROM TRANGTHAI";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
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
        public DataTable TrangThai1()
        {
            string cmd = "SELECT * FROM TRANGTHAI WHERE MATT='0'";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public DataTable TrangThai2()
        {
            string cmd = "SELECT * FROM TRANGTHAI where MATT='1'";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public DataTable TrangThai3()
        {
            string cmd = "SELECT * FROM TRANGTHAI where MATT='1' OR MATT='2' OR MATT='5' or MATT='6'";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public DataTable TrangThai4()
        {
            string cmd = "SELECT * FROM TRANGTHAI where MATT='2' OR MATT='3' OR MATT='5'or MATT='6'";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public DataTable TrangThai5()
        {
            string cmd = "SELECT * FROM TRANGTHAI where MATT='3' OR MATT='4'";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public DataTable TrangThai7()
        {
            string cmd = "SELECT * FROM TRANGTHAI where MATT='3' OR MATT='5' or MATT='6";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public DataTable TrangThai8()
        {
            string cmd = "SELECT * FROM TRANGTHAI where MATT='2' OR MATT='5'or MATT='6'";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public DataTable TrangThai9()
        {
            string cmd = "SELECT * FROM TRANGTHAI where MATT='3' OR MATT='5'or MATT='6'";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public DataTable TrangThai6()
        {
            string cmd = "SELECT * FROM TRANGTHAI where MATT='-1'";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public bool themQTHT(DTO_QTHT pQTHT)
        {
            dbConn.Open();
            string cmd = "INSERT INTO QTHT VALUES('" + pQTHT.MaSV + "','" + pQTHT.NamHoc + "', '" + pQTHT.Lop + "',  N'" + pQTHT.TrangThai + "','" + pQTHT.SoQD + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool suaQTHT(DTO_QTHT pQTHT)
        {
            dbConn.Open();
            string cmd = "UPDATE QTHT SET SOQD=N'"+pQTHT.SoQD+"' NAMHOC='" + pQTHT.NamHoc + "' ,LOP='" + pQTHT.Lop + "',  TRANGTHAI=N'" + pQTHT.TrangThai + "' WHERE MASV='" + pQTHT.MaSV + "' AND ,LOP='" + pQTHT.Lop + "'AND  TRANGTHAI=N'" + pQTHT.TrangThai + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool xoaQTHT(String maSV, String namHoc, String lop, String trangThai)
        {
            dbConn.Open();
            string cmd = "DELETE FROM QTHT WHERE MASV='" + maSV + "' and NAMHOC='"+namHoc+ "' and LOP='" + lop + "' and TRANGTHAI='" + trangThai+"' ";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
    }
}
