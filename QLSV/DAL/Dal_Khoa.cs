﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class Dal_Khoa:connect
    {
        SqlDataAdapter adap;
        DataTable dt;
        public bool kiemtratontai(String MaKhoa)
        {
            bool tatkt = false;
            adap = new SqlDataAdapter("Select * from KHOA where MaKhoa='" + MaKhoa + "'", dbConn);
            dt = new DataTable();
            adap.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                tatkt = true;
            }
            adap.Dispose();
            return tatkt;
        }
        public DataTable Khoa_DS()
        {
            string cmd = "SELECT * FROM KHOA";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }

        public bool themKhoa(DTO_Khoa pKhoa)
        {
            dbConn.Open();
            string cmd = "INSERT INTO KHOA VALUES(N'" + pKhoa.MaKhoa + "',N'" + pKhoa.TenKhoa + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool suaKhoa(DTO_Khoa pKhoa)
        {
            dbConn.Open();
            string cmd = "UPDATE KHOA SET TENKHOA=N'" + pKhoa.TenKhoa + "' WHERE MAKHOA='" + pKhoa.MaKhoa + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool xoaKhoa(String maKhoa)
        {
            dbConn.Open();
            string cmd = "DELETE FROM KHOA WHERE MAKHOA='" + maKhoa + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
    }
}
