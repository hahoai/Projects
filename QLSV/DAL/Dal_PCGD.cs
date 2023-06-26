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
  public  class Dal_PCGD: connect
    {
        SqlDataAdapter adap;
        DataTable dt;

        public DataTable MonHoc()
        {
            string cmd = "SELECT * FROM MONHOC";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public DataTable ChuyenNganh()
        {
            string cmd = "SELECT * FROM CHUYENNGANH";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public DataTable MonHoc1(string maNganh)
        {
            string cmd = @"sELECT * FROM MONHOC where MONHOC.MANGANH='" + maNganh + "' OR MONHOC.MONCHUNG='Có' ";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public DataTable Lop1(string maNganh)
        {
            string cmd = "SELECT * FROM LOP where MANGANH='"+maNganh+"' ";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public DataTable Lop()
        {
            string cmd = "SELECT * FROM LOP ";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public DataTable GiaoVien()
        {
            string cmd = "SELECT * FROM GiaoVien";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public DataTable PCGD()
        {
            string cmd = @"SELECT * FROM PHANCONGGD ";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public DataTable PCGD1(string MaLop)
        {
            string cmd = @"SELECT * FROM PHANCONGGD where MALOP='"+MaLop+"' ";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public DataTable CTDT()
        {
            string cmd = "SELECT * FROM CTDT";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }


        public bool kiemtratontai(String LopMH, String MaMH, String MaLop)
        {
            bool tatkt = false;
            adap = new SqlDataAdapter("Select* from PHANCONGGD where LopMH='"+LopMH+"' and MaMH='" + MaMH + "'and MaLop='" + MaLop + "'", dbConn);
            dt = new DataTable();
            adap.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                tatkt = true;
            }
            adap.Dispose();
            return tatkt;
        }
        public bool themPCGD(DTO_PCGD pPCGD)
        {
            dbConn.Open();
            string cmd = "INSERT INTO PHANCONGGD VALUES(N'" + pPCGD.LopMH + "',N'" + pPCGD.MaMH + "','" + pPCGD.MaLop + "',N'" + pPCGD.MaGV + "','"+pPCGD.NamHoc+"','"+pPCGD.HocKy+"')";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool suaPCGD(DTO_PCGD pPCGD)
        {
            dbConn.Open();
            string cmd = "UPDATE PHANCONGGD SET MAMH=N'" + pPCGD.MaMH + "', MALOP=N'" + pPCGD.MaLop + "', MAGV=N'" + pPCGD.MaGV + "',NAMHOC=N'"+pPCGD.NamHoc+"',HOCKY='"+pPCGD.HocKy+"'  WHERE LOPMH='" + pPCGD.LopMH + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool xoaPCGD(String lopMH)
        {
            dbConn.Open();
            string cmd = "DELETE FROM PHANCONGGD WHERE LOPMH='" + lopMH + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }

    }
}
