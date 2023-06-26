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

   public class Dal_TKB: connect
    {
        SqlDataAdapter adap;
        DataTable dt;

        public DataTable PCGD()
        {
            string cmd = "SELECT * FROM PHANCONGGD";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        
        public DataTable ThoiKhoaBieu()
        {
            string cmd = "SELECT * FROM THOIKHOABIEU";
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

        public bool themTKB(DTO_TKB pTKB)
        {
            dbConn.Open();
            string cmd = "INSERT INTO THOIKHOABIEU VALUES('"+pTKB.LopMH+"', '"+pTKB.NgayBD+"', '"+pTKB.NgayKT+"', N'"+pTKB.Phong+"', '"+pTKB.TietBD+"', '"+pTKB.TietKT+"', '"+pTKB.Thu+"')";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool suaTKB(DTO_TKB pTKB)
        {
            dbConn.Open();
            string cmd = "UPDATE THOIKHOABIEU SET NGAYBATDAU=N'" + pTKB.NgayBD + "', NGAYKETTHUC=N'" + pTKB.NgayKT + "', DIADIEM=N'" + pTKB.Phong + "', TIETBD=N'"+ pTKB.TietBD +"',TIETKT=N'"+ pTKB.TietKT +"', THU=N'"+pTKB.Thu+"'  WHERE LOPMH='" + pTKB.LopMH + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        
        public bool xoaTKB(String lopMH)
        {
            dbConn.Open();
            string cmd = "DELETE FROM THOIKHOABIEU WHERE LOPMH='" + lopMH + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool LOPMH(String maLop, string hocKy)
        {
            dbConn.Open();
            string cmd = "select THOIKHOABIEU.LOPMH FROM MONHOC INNER JOIN PHANCONGGD ON MONHOC.MAMH= PHANCONGGD.MAMH INNER JOIN GIAOVIEN ON PHANCONGGD.MAGV= GIAOVIEN.MAGV INNER JOIN THOIKHOABIEU ON THOIKHOABIEU.LOPMH = PHANCONGGD.LOPMH INNER JOIN CHUONGTRINHDT ON CHUONGTRINHDT.MAMH= PHANCONGGD.MAMH WHERE PHANCONGGD.MALOP= '"+maLop+"' and CHUONGTRINHDT.HOCKY= '"+hocKy+"'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }

    }
}
