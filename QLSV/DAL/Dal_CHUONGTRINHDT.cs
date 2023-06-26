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
    public class Dal_CHUONGTRINHDT:connect
    {
        SqlDataAdapter adap;
        DataTable dt;
       
        

        public DataTable ChiTietCTDT()
        {
            string cmd = "SELECT * FROM CHUONGTRINHDAOTAO";
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
        public DataTable MonHoc()
        {
            string cmd = "SELECT * FROM MONHOC";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public DataTable MonHoc1(string maNganh)
        {
            string cmd = @"sELECT * FROM MONHOC where MONHOC.MANGANH='" + maNganh + "' OR MONHOC.MONCHUNG='Có'";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }

        public bool kiemtratontai(String MaMH, String MaNganh)
        {
            bool tatkt = false;
            adap = new SqlDataAdapter("Select * from CHUONGTRINHDAOTAO where MaMH='" + MaMH + "'and MANGANH='"+MaNganh+"'", dbConn);
            dt = new DataTable();
            adap.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                tatkt = true;
            }
            adap.Dispose();
            return tatkt;
        }
        
        public bool themCTDT(DTO_CHUONGTRINHDT pCT)
        {
            dbConn.Open();
            string cmd = "INSERT INTO CHUONGTRINHDAOTAO VALUES(N'" + pCT.MaNganh + "',N'" + pCT.MaMH + "','" + pCT.KyThu + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool suaCTDT(DTO_CHUONGTRINHDT pCT)
        {
            dbConn.Open();
            string cmd = "UPDATE CHUONGTRINHDAOTAO SET KYTHU='" + pCT.KyThu + "' where MANGANH='" + pCT.MaNganh + "' and MaMH='" + pCT.MaMH + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool xoaCTDT(String maMH, String maCTDT)
        {
            dbConn.Open();
            string cmd = "DELETE FROM CHUONGTRINHDAOTAO where MaCTDT='" + maCTDT + "' and MaMH='" + maMH + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
    }
}
