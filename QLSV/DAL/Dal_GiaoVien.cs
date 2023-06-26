using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class Dal_GiaoVien : connect
    {
        SqlDataAdapter adap;
        DataTable dt;
        
        public bool kiemtratontai(String MaGV)
        {
            bool tatkt = false;
            adap = new SqlDataAdapter("Select* from GIAOVIEN where MaGV='" + MaGV + "'", dbConn);
            dt = new DataTable();
            adap.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                tatkt = true;
            }
            adap.Dispose();
            return tatkt;
        }
        public DataTable GV_DS()
        {
            string cmd = "SELECT * FROM GIAOVIEN";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }

        public bool themGV(DTO_GiaoVien pGV)
        {
            dbConn.Open();
            string cmd = "INSERT INTO GIAOVIEN VALUES(N'" + pGV.MaGV + "',N'" + pGV.TenGV + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool suaGV(DTO_GiaoVien pGV)
        {
            dbConn.Open();
            string cmd = "UPDATE GIAOVIEN SET TENGV=N'" + pGV.TenGV + "' WHERE MAGV='" + pGV.MaGV + "'";
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
