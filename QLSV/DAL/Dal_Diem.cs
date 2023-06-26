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
    public class Dal_Diem : connect
    {
        SqlDataAdapter da;
        DataTable dt;
        

        // hàm lấy dữ liệu từ csdl lên datagridview
        
        public DataTable LopMH()
        {
            da = new SqlDataAdapter("SELECT * FROM PHANCONGGD", dbConn);
            dt = new DataTable();
            da.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable DIEM()
        {
            da = new SqlDataAdapter("SELECT * FROM DIEM", dbConn);
            dt = new DataTable();
            da.Fill(dt);
            dbConn.Close();
            return dt;
        }




        public DataTable SinhVien_DSMH(String maMH)
        {
            string cmd = "SELECT SINHVIEN.MASV,DIEM.MAMH, DIEMCC,DIEMKT1,DIEMTHI, ( DIEMCC*0.1 + DIEMKT1*0.3 + DIEMTHI*0.6 ) as DiemTB FROM LOP INNER JOIN SINHVIEN ON LOP.MALOP = SINHVIEN.MALOP INNER JOIN DIEM ON SINHVIEN.MASV = DIEM.MASV inner join monhoc on monhoc.mamh=diem.mamh WHERE monhoc.mamh ='" + maMH + "' GROUP BY SINHVIEN.MASV,DIEM.MAMH,DIEMCC,DIEMKT1,DIEMTHI ";
            da = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable SinhVien_DSLOP_MH(String maMH, String maLop)
        {
            string cmd = "SELECT SINHVIEN.MASV,DIEM.MAMH, DIEMCC,DIEMKT1,DIEMTHI,( DIEMCC*0.1 + DIEMKT1*0.3 + DIEMTHI*0.6 ) as DiemTB FROM LOP INNER JOIN SINHVIEN ON LOP.MALOP = SINHVIEN.MALOP INNER JOIN DIEM ON SINHVIEN.MASV = DIEM.MASV inner join monhoc on monhoc.mamh=diem.mamh WHERE monhoc.mamh ='" + maMH + "' and LOP.MALOP='" + maLop + "' GROUP BY SINHVIEN.MASV,DIEM.MAMH,DIEMCC,DIEMKT1,DIEMTHI ";
            da = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable DS_SV()
        {
            string cmd = @"insert INTO DIEM (MASV,LOPMH,DIEMCC,DIEMKT1,DIEMTHI) SELECT QTHT.MASV, PHANCONGGD.LOPMH,0,0,0 
from QTHT INNER JOIN PHANCONGGD ON QTHT.LOP=PHANCONGGD.MALOP AND QTHT.NAMHOC=PHANCONGGD.NAMHOC 
WHERE  NOT EXISTS (SELECT MASV, LOPMH FROM DIEM WHERE DIEM.MASV = QTHT.MASV and DIEM.LOPMH = PHANCONGGD.LOPMH)
             ";
            da = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
