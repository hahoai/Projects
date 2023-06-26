USE [QuanLySinhVien]
GO
/****** Object:  User [mai]    Script Date: 5/10/2023 9:40:45 PM ******/
CREATE USER [mai] FOR LOGIN [mai] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[CHUONGTRINHDAOTAO]    Script Date: 5/10/2023 9:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUONGTRINHDAOTAO](
	[MANGANH] [varchar](10) NOT NULL,
	[MAMH] [varchar](10) NOT NULL,
	[KYTHU] [varchar](1) NULL,
 CONSTRAINT [PK_CHUONGTRINHDAOTAO] PRIMARY KEY CLUSTERED 
(
	[MANGANH] ASC,
	[MAMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHUYENNGANH]    Script Date: 5/10/2023 9:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUYENNGANH](
	[MANGANH] [varchar](10) NOT NULL,
	[TENNGANH] [nvarchar](50) NULL,
	[MAKHOA] [varchar](10) NULL,
 CONSTRAINT [PK_CHUYENNGANH] PRIMARY KEY CLUSTERED 
(
	[MANGANH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DANGNHAP]    Script Date: 5/10/2023 9:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANGNHAP](
	[TENDANGNHAP] [varchar](10) NOT NULL,
	[MATKHAU] [nvarchar](20) NULL,
	[HOTEN] [nvarchar](50) NULL,
	[QUYEN] [nvarchar](50) NULL,
 CONSTRAINT [PK_DANGNHAP] PRIMARY KEY CLUSTERED 
(
	[TENDANGNHAP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DIEM]    Script Date: 5/10/2023 9:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DIEM](
	[MASV] [varchar](10) NOT NULL,
	[LOPMH] [varchar](20) NOT NULL,
	[DIEMCC] [decimal](10, 1) NULL,
	[DIEMKT1] [decimal](10, 1) NULL,
	[DIEMTHI] [decimal](10, 1) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GIAOVIEN]    Script Date: 5/10/2023 9:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIAOVIEN](
	[MAGV] [varchar](10) NOT NULL,
	[TENGV] [nvarchar](50) NULL,
 CONSTRAINT [PK_GIAOVIEN] PRIMARY KEY CLUSTERED 
(
	[MAGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHENTHUONG]    Script Date: 5/10/2023 9:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHENTHUONG](
	[MAKT] [varchar](10) NOT NULL,
	[TENKT] [nvarchar](50) NULL,
 CONSTRAINT [PK_LOAIKHENTHUONG] PRIMARY KEY CLUSTERED 
(
	[MAKT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHOA]    Script Date: 5/10/2023 9:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHOA](
	[MAKHOA] [varchar](10) NOT NULL,
	[TENKHOA] [nvarchar](50) NULL,
 CONSTRAINT [PK_KHOA] PRIMARY KEY CLUSTERED 
(
	[MAKHOA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KYLUAT]    Script Date: 5/10/2023 9:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KYLUAT](
	[MaKL] [varchar](10) NOT NULL,
	[TENKL] [nvarchar](50) NULL,
 CONSTRAINT [PK_KYLUAT] PRIMARY KEY CLUSTERED 
(
	[MaKL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOP]    Script Date: 5/10/2023 9:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOP](
	[MALOP] [varchar](10) NOT NULL,
	[TENLOP] [nvarchar](50) NULL,
	[MANGANH] [varchar](10) NULL,
 CONSTRAINT [PK_LOP] PRIMARY KEY CLUSTERED 
(
	[MALOP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MONHOC]    Script Date: 5/10/2023 9:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MONHOC](
	[MAMH] [varchar](10) NOT NULL,
	[TENMH] [nvarchar](50) NULL,
	[SOTIET] [varchar](10) NULL,
	[SOTINCHI] [decimal](10, 0) NULL,
	[MANGANH] [varchar](10) NULL,
	[MONCHUNG] [nvarchar](10) NULL,
 CONSTRAINT [PK_MONHOC] PRIMARY KEY CLUSTERED 
(
	[MAMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHANCONGGD]    Script Date: 5/10/2023 9:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHANCONGGD](
	[LOPMH] [varchar](20) NOT NULL,
	[MAMH] [varchar](10) NULL,
	[MALOP] [varchar](10) NULL,
	[MAGV] [varchar](10) NULL,
	[NAMHOC] [nvarchar](12) NULL,
	[HOCKY] [varchar](1) NULL,
 CONSTRAINT [PK_PHANCONGGD] PRIMARY KEY CLUSTERED 
(
	[LOPMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QTHT]    Script Date: 5/10/2023 9:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QTHT](
	[MASV] [varchar](10) NULL,
	[NAMHOC] [nvarchar](12) NULL,
	[LOP] [varchar](10) NULL,
	[TRANGTHAI] [varchar](2) NULL,
	[SOQD] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QTKHENTHUONG]    Script Date: 5/10/2023 9:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QTKHENTHUONG](
	[MASV] [varchar](10) NOT NULL,
	[HOCKY] [varchar](10) NOT NULL,
	[MAKT] [varchar](10) NOT NULL,
	[SOQUYETDINH] [varchar](10) NULL,
	[NGAYQUYETDINH] [date] NULL,
	[HINHTHUC] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QTKYLUAT]    Script Date: 5/10/2023 9:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QTKYLUAT](
	[MASV] [varchar](10) NOT NULL,
	[HOCKY] [varchar](10) NOT NULL,
	[MAKL] [varchar](10) NOT NULL,
	[SOQD] [varchar](10) NULL,
	[NGAYQD] [date] NULL,
	[HINHTHUC] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 5/10/2023 9:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SINHVIEN](
	[MASV] [varchar](10) NOT NULL,
	[HOTENSV] [nvarchar](50) NULL,
	[NGAYSINH] [date] NULL,
	[GIOITINH] [nvarchar](10) NULL,
	[DIACHI] [nvarchar](50) NULL,
 CONSTRAINT [PK_SINHVIEN] PRIMARY KEY CLUSTERED 
(
	[MASV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THOIKHOABIEU]    Script Date: 5/10/2023 9:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THOIKHOABIEU](
	[LOPMH] [varchar](20) NULL,
	[NGAYBATDAU] [date] NULL,
	[NGAYKETTHUC] [date] NULL,
	[DIADIEM] [nvarchar](50) NULL,
	[TIETBD] [int] NULL,
	[TIETKT] [int] NULL,
	[THU] [varchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRANGTHAI]    Script Date: 5/10/2023 9:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRANGTHAI](
	[MATT] [varchar](2) NOT NULL,
	[TENTT] [nvarchar](50) NULL,
 CONSTRAINT [PK_TRANGTHAI] PRIMARY KEY CLUSTERED 
(
	[MATT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CHUONGTRINHDAOTAO]  WITH CHECK ADD  CONSTRAINT [FK_CHUONGTRINHDAOTAO_CHUYENNGANH] FOREIGN KEY([MANGANH])
REFERENCES [dbo].[CHUYENNGANH] ([MANGANH])
GO
ALTER TABLE [dbo].[CHUONGTRINHDAOTAO] CHECK CONSTRAINT [FK_CHUONGTRINHDAOTAO_CHUYENNGANH]
GO
ALTER TABLE [dbo].[CHUONGTRINHDAOTAO]  WITH CHECK ADD  CONSTRAINT [FK_CHUONGTRINHDAOTAO_MONHOC1] FOREIGN KEY([MAMH])
REFERENCES [dbo].[MONHOC] ([MAMH])
GO
ALTER TABLE [dbo].[CHUONGTRINHDAOTAO] CHECK CONSTRAINT [FK_CHUONGTRINHDAOTAO_MONHOC1]
GO
ALTER TABLE [dbo].[CHUYENNGANH]  WITH CHECK ADD  CONSTRAINT [FK_CHUYENNGANH_KHOA] FOREIGN KEY([MAKHOA])
REFERENCES [dbo].[KHOA] ([MAKHOA])
GO
ALTER TABLE [dbo].[CHUYENNGANH] CHECK CONSTRAINT [FK_CHUYENNGANH_KHOA]
GO
ALTER TABLE [dbo].[DIEM]  WITH CHECK ADD  CONSTRAINT [FK_DIEM_PHANCONGGD] FOREIGN KEY([LOPMH])
REFERENCES [dbo].[PHANCONGGD] ([LOPMH])
GO
ALTER TABLE [dbo].[DIEM] CHECK CONSTRAINT [FK_DIEM_PHANCONGGD]
GO
ALTER TABLE [dbo].[DIEM]  WITH CHECK ADD  CONSTRAINT [FK_DIEM_SINHVIEN1] FOREIGN KEY([MASV])
REFERENCES [dbo].[SINHVIEN] ([MASV])
GO
ALTER TABLE [dbo].[DIEM] CHECK CONSTRAINT [FK_DIEM_SINHVIEN1]
GO
ALTER TABLE [dbo].[LOP]  WITH CHECK ADD  CONSTRAINT [FK_LOP_CHUYENNGANH] FOREIGN KEY([MANGANH])
REFERENCES [dbo].[CHUYENNGANH] ([MANGANH])
GO
ALTER TABLE [dbo].[LOP] CHECK CONSTRAINT [FK_LOP_CHUYENNGANH]
GO
ALTER TABLE [dbo].[PHANCONGGD]  WITH CHECK ADD  CONSTRAINT [FK_PHANCONGGD_GIAOVIEN1] FOREIGN KEY([MAGV])
REFERENCES [dbo].[GIAOVIEN] ([MAGV])
GO
ALTER TABLE [dbo].[PHANCONGGD] CHECK CONSTRAINT [FK_PHANCONGGD_GIAOVIEN1]
GO
ALTER TABLE [dbo].[PHANCONGGD]  WITH CHECK ADD  CONSTRAINT [FK_PHANCONGGD_LOP] FOREIGN KEY([MALOP])
REFERENCES [dbo].[LOP] ([MALOP])
GO
ALTER TABLE [dbo].[PHANCONGGD] CHECK CONSTRAINT [FK_PHANCONGGD_LOP]
GO
ALTER TABLE [dbo].[PHANCONGGD]  WITH CHECK ADD  CONSTRAINT [FK_PHANCONGGD_MONHOC] FOREIGN KEY([MAMH])
REFERENCES [dbo].[MONHOC] ([MAMH])
GO
ALTER TABLE [dbo].[PHANCONGGD] CHECK CONSTRAINT [FK_PHANCONGGD_MONHOC]
GO
ALTER TABLE [dbo].[QTHT]  WITH CHECK ADD  CONSTRAINT [FK_QTHT_LOP] FOREIGN KEY([LOP])
REFERENCES [dbo].[LOP] ([MALOP])
GO
ALTER TABLE [dbo].[QTHT] CHECK CONSTRAINT [FK_QTHT_LOP]
GO
ALTER TABLE [dbo].[QTHT]  WITH CHECK ADD  CONSTRAINT [FK_QTHT_SINHVIEN] FOREIGN KEY([MASV])
REFERENCES [dbo].[SINHVIEN] ([MASV])
GO
ALTER TABLE [dbo].[QTHT] CHECK CONSTRAINT [FK_QTHT_SINHVIEN]
GO
ALTER TABLE [dbo].[QTHT]  WITH CHECK ADD  CONSTRAINT [FK_QTHT_TRANGTHAI] FOREIGN KEY([TRANGTHAI])
REFERENCES [dbo].[TRANGTHAI] ([MATT])
GO
ALTER TABLE [dbo].[QTHT] CHECK CONSTRAINT [FK_QTHT_TRANGTHAI]
GO
ALTER TABLE [dbo].[QTKHENTHUONG]  WITH CHECK ADD  CONSTRAINT [FK_QTKHENTHUONG_KHENTHUONG] FOREIGN KEY([MAKT])
REFERENCES [dbo].[KHENTHUONG] ([MAKT])
GO
ALTER TABLE [dbo].[QTKHENTHUONG] CHECK CONSTRAINT [FK_QTKHENTHUONG_KHENTHUONG]
GO
ALTER TABLE [dbo].[QTKHENTHUONG]  WITH CHECK ADD  CONSTRAINT [FK_QTKHENTHUONG_SINHVIEN] FOREIGN KEY([MASV])
REFERENCES [dbo].[SINHVIEN] ([MASV])
GO
ALTER TABLE [dbo].[QTKHENTHUONG] CHECK CONSTRAINT [FK_QTKHENTHUONG_SINHVIEN]
GO
ALTER TABLE [dbo].[QTKYLUAT]  WITH CHECK ADD  CONSTRAINT [FK_QTKYLUAT_KYLUAT] FOREIGN KEY([MAKL])
REFERENCES [dbo].[KYLUAT] ([MaKL])
GO
ALTER TABLE [dbo].[QTKYLUAT] CHECK CONSTRAINT [FK_QTKYLUAT_KYLUAT]
GO
ALTER TABLE [dbo].[QTKYLUAT]  WITH CHECK ADD  CONSTRAINT [FK_QTKYLUAT_SINHVIEN] FOREIGN KEY([MASV])
REFERENCES [dbo].[SINHVIEN] ([MASV])
GO
ALTER TABLE [dbo].[QTKYLUAT] CHECK CONSTRAINT [FK_QTKYLUAT_SINHVIEN]
GO
ALTER TABLE [dbo].[THOIKHOABIEU]  WITH CHECK ADD  CONSTRAINT [FK_THOIKHOABIEU_PHANCONGGD] FOREIGN KEY([LOPMH])
REFERENCES [dbo].[PHANCONGGD] ([LOPMH])
GO
ALTER TABLE [dbo].[THOIKHOABIEU] CHECK CONSTRAINT [FK_THOIKHOABIEU_PHANCONGGD]
GO
/****** Object:  StoredProcedure [dbo].[diemSVtheoki]    Script Date: 5/10/2023 9:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[diemSVtheoki]
	@MASV varchar(10),
	@HOCKY VARCHAR(1),
	@NAMHOC NVARCHAR(12)	
as
begin
	select 
		SINHVIEN.MASV,
		SINHVIEN.HOTENSV,
		CHUYENNGANH.TENNGANH,
		LOP.TENLOP,
		MONHOC.TENMH,
		MONHOC.SOTINCHI,
		PHANCONGGD.LOPMH,
		PHANCONGGD.HOCKY,
		PHANCONGGD.NAMHOC,
		GIAOVIEN.TENGV,
		DIEM.DIEMCC,
		DIEM.DIEMKT1,
		DIEM.DIEMTHI,
		((SELECT count((MONHOC.SOTINCHI)) FROM  DIEM INNER JOIN
             PHANCONGGD ON DIEM.LOPMH = PHANCONGGD.LOPMH INNER JOIN
             MONHOC ON PHANCONGGD.MAMH = MONHOC.MAMH 
			 WHERE  (DIEM.MASV = @MASV) AND (PHANCONGGD.HOCKY = @HOCKY) AND (PHANCONGGD.NAMHOC=@NAMHOC) GROUP BY DIEM.MASV, PHANCONGGD.HOCKY,PHANCONGGD.NAMHOC)
			 /(SELECT count((MONHOC.SOTINCHI)) FROM  DIEM INNER JOIN
             PHANCONGGD ON DIEM.LOPMH = PHANCONGGD.LOPMH INNER JOIN
             MONHOC ON PHANCONGGD.MAMH = MONHOC.MAMH 
             WHERE (DIEM.MASV = @MASV) AND (PHANCONGGD.HOCKY = @HOCKY) AND (PHANCONGGD.NAMHOC=@NAMHOC) GROUP BY DIEM.MASV, PHANCONGGD.HOCKY,PHANCONGGD.NAMHOC)) AS SOMH,
		(CAST((SELECT count(CAST((MONHOC.SOTINCHI) AS decimal)) FROM  DIEM INNER JOIN
             PHANCONGGD ON DIEM.LOPMH = PHANCONGGD.LOPMH INNER JOIN
             MONHOC ON PHANCONGGD.MAMH = MONHOC.MAMH 
			 WHERE ((DIEM.DIEMCC * 0.1 + DIEM.DIEMKT1 * 0.3) + DIEM.DIEMTHI * 0.6 > 4) 
			 GROUP BY DIEM.MASV, PHANCONGGD.HOCKY, PHANCONGGD.NAMHOC having (DIEM.MASV = @MASV) AND (PHANCONGGD.HOCKY = @HOCKY) AND PHANCONGGD.NAMHOC=@NAMHOC )AS DECIMAL)
			 /(SELECT COUNT((MONHOC.SOTINCHI)) FROM  DIEM INNER JOIN
             PHANCONGGD ON DIEM.LOPMH = PHANCONGGD.LOPMH INNER JOIN MONHOC ON PHANCONGGD.MAMH = MONHOC.MAMH 
             WHERE  (DIEM.MASV = @MASV) AND (PHANCONGGD.HOCKY = @HOCKY) AND (PHANCONGGD.NAMHOC=@NAMHOC) 
			 GROUP BY DIEM.MASV, PHANCONGGD.HOCKY,PHANCONGGD.NAMHOC)) AS SOMHDAT,

		(DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6) AS TBCHP,

		((SELECT SUM(cast ((MONHOC.SOTINCHI) as decimal)) FROM  DIEM INNER JOIN PHANCONGGD ON DIEM.LOPMH = PHANCONGGD.LOPMH INNER JOIN
             MONHOC ON PHANCONGGD.MAMH = MONHOC.MAMH 
             WHERE ((DIEM.DIEMCC * 0.1 + DIEM.DIEMKT1 * 0.3) + DIEM.DIEMTHI * 0.6 > 4)
             GROUP BY DIEM.MASV, PHANCONGGD.HOCKY,PHANCONGGD.NAMHOC
             HAVING (DIEM.MASV = @MASV) AND (PHANCONGGD.HOCKY = @HOCKY) AND(PHANCONGGD.NAMHOC=@NAMHOC) )
			 /(SELECT COUNT((MONHOC.SOTINCHI)) FROM  DIEM INNER JOIN PHANCONGGD ON DIEM.LOPMH = PHANCONGGD.LOPMH INNER JOIN MONHOC ON PHANCONGGD.MAMH = MONHOC.MAMH 
             WHERE  (DIEM.MASV = @MASV) AND (PHANCONGGD.HOCKY = @HOCKY) AND (PHANCONGGD.NAMHOC=@NAMHOC) 
			 GROUP BY DIEM.MASV, PHANCONGGD.HOCKY,PHANCONGGD.NAMHOC)) AS SOTCDAT,

             
		(DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)*SOTINCHI/
		(SELECT sum(SOTINCHI) FROM  DIEM INNER JOIN
             PHANCONGGD ON DIEM.LOPMH = PHANCONGGD.LOPMH INNER JOIN MONHOC ON PHANCONGGD.MAMH = MONHOC.MAMH 
             WHERE  (DIEM.MASV = @MASV) AND (PHANCONGGD.HOCKY = @HOCKY) AND (PHANCONGGD.NAMHOC=@NAMHOC) 
			 GROUP BY DIEM.MASV, PHANCONGGD.HOCKY,PHANCONGGD.NAMHOC) AS DIEMTBC,
		 
		 CASE 
		WHEN (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)>=9.5 and (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)<=10 then 'A+'
		when (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)<=9.4 and (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)>=8.5 then 'A'
		when (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)<=8.4 and (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)>=8.0 then 'B+'
		when (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)<=7.9 and (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)>=7 then 'B'
		when (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)<=6.9 and (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)>=6.5 then 'C+'
		when (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)<=6.4 and (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)>=5.5 then 'C'
		when (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)<=5.4 and (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)>=5.0 then 'D+'
		when (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)<=4.9 and (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)>=4.0 then 'D'
		when (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)<=3.9 and (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)>=2.0 then 'F+'
		when (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)<2.0  then 'F'
		end AS DIEMCHU
		FROM SINHVIEN INNER JOIN QTHT ON SINHVIEN.MASV=QTHT.MASV INNER JOIN LOP 
		ON  QTHT.LOP=LOP.MALOP INNER JOIN DIEM ON DIEM.MASV=SINHVIEN.MASV  INNER JOIN PHANCONGGD 
		ON DIEM.LOPMH=PHANCONGGD.LOPMH INNER JOIN CHUYENNGANH 
		ON CHUYENNGANH.MANGANH=LOP.MANGANH INNER JOIN MONHOC ON PHANCONGGD.MAMH=MONHOC.MAMH INNER JOIN GIAOVIEN ON PHANCONGGD.MAGV=GIAOVIEN.MAGV
		WHERE SINHVIEN.MASV=@MASV AND PHANCONGGD.HOCKY=@HOCKY AND PHANCONGGD.NAMHOC=@NAMHOC
		group by SINHVIEN.MASV,
		SINHVIEN.HOTENSV,
		CHUYENNGANH.TENNGANH,
		LOP.TENLOP,
		MONHOC.TENMH,
		MONHOC.SOTINCHI,
		PHANCONGGD.LOPMH,
		PHANCONGGD.HOCKY,
		PHANCONGGD.NAMHOC,
		DIEM.DIEMCC,
		DIEM.DIEMKT1,
		DIEM.DIEMTHI,
		GIAOVIEN.TENGV
		end;
GO
/****** Object:  StoredProcedure [dbo].[DTB_calop]    Script Date: 5/10/2023 9:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DTB_calop]
	@MALOP varchar (10),
	@HOCKY varchar (10)
as
begin
 select SINHVIEN.MASV, SINHVIEN.HOTENSV, LOP.TENLOP, CHUONGTRINHDT.HOCKY,
sum((DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)*sotinchi)/((select sum(sotinchi) from MONHOC inner join PHANCONGGD on MONHOC.MAMH=PHANCONGGD.MAMH inner join lop on lop.MALOP=PHANCONGGD.MALOP inner join chuongtrinhdt on CHUONGTRINHDT.MAMH=MONHOC.MAMH where lop.MALOP=@MALOP AND CHUONGTRINHDT.HOCKY=@HOCKY )
)
FROM DIEM INNER JOIN PHANCONGGD ON DIEM.LOPMH=PHANCONGGD.LOPMH INNER JOIN MONHOC ON MONHOC.MAMH=PHANCONGGD.MAMH INNER JOIN SINHVIEN ON SINHVIEN.MASV=DIEM.MASV INNER JOIN CHUONGTRINHDT ON CHUONGTRINHDT.MAMH=MONHOC.MAMH INNER JOIN LOP ON LOP.MALOP=SINHVIEN.MALOP
where sinhvien.malop=@MALOP AND CHUONGTRINHDT.HOCKY=@HOCKY
group by sinhvien.masv,SINHVIEN.HOTENSV , LOP.TENLOP,CHUONGTRINHDT.HOCKY             
end;
GO
/****** Object:  StoredProcedure [dbo].[ketquatheonamhoc]    Script Date: 5/10/2023 9:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ketquatheonamhoc]
	@MASV varchar(10),
	@NAMHOC NVARCHAR(12)	
as
begin
	select 
		SINHVIEN.MASV,
		SINHVIEN.HOTENSV,
		CHUYENNGANH.TENNGANH,
		LOP.TENLOP,
		MONHOC.TENMH,
		MONHOC.SOTINCHI,
		PHANCONGGD.LOPMH,
		PHANCONGGD.NAMHOC,
		GIAOVIEN.TENGV,
		DIEM.DIEMCC,
		DIEM.DIEMKT1,
		DIEM.DIEMTHI,
		((SELECT count((MONHOC.SOTINCHI)) FROM  DIEM INNER JOIN
             PHANCONGGD ON DIEM.LOPMH = PHANCONGGD.LOPMH INNER JOIN
             MONHOC ON PHANCONGGD.MAMH = MONHOC.MAMH 
			 WHERE  (DIEM.MASV = @MASV)  AND (PHANCONGGD.NAMHOC=@NAMHOC) GROUP BY DIEM.MASV, PHANCONGGD.NAMHOC)
			 /(SELECT count((MONHOC.SOTINCHI)) FROM  DIEM INNER JOIN
             PHANCONGGD ON DIEM.LOPMH = PHANCONGGD.LOPMH INNER JOIN
             MONHOC ON PHANCONGGD.MAMH = MONHOC.MAMH 
             WHERE (DIEM.MASV = @MASV)  AND (PHANCONGGD.NAMHOC=@NAMHOC) GROUP BY DIEM.MASV,PHANCONGGD.NAMHOC)) AS SOMH,
		(CAST((SELECT count(CAST((MONHOC.SOTINCHI) AS decimal)) FROM  DIEM INNER JOIN
             PHANCONGGD ON DIEM.LOPMH = PHANCONGGD.LOPMH INNER JOIN
             MONHOC ON PHANCONGGD.MAMH = MONHOC.MAMH 
			 WHERE ((DIEM.DIEMCC * 0.1 + DIEM.DIEMKT1 * 0.3) + DIEM.DIEMTHI * 0.6 > 4) 
			 GROUP BY DIEM.MASV, PHANCONGGD.NAMHOC having (DIEM.MASV = @MASV)  AND PHANCONGGD.NAMHOC=@NAMHOC )AS DECIMAL)
			 /(SELECT COUNT((MONHOC.SOTINCHI)) FROM  DIEM INNER JOIN
             PHANCONGGD ON DIEM.LOPMH = PHANCONGGD.LOPMH INNER JOIN MONHOC ON PHANCONGGD.MAMH = MONHOC.MAMH 
             WHERE  (DIEM.MASV = @MASV) AND (PHANCONGGD.NAMHOC=@NAMHOC) 
			 GROUP BY DIEM.MASV,PHANCONGGD.NAMHOC)) AS SOMHDAT,

		(DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6) AS TBCHP,

		((SELECT SUM(cast ((MONHOC.SOTINCHI) as decimal)) FROM  DIEM INNER JOIN PHANCONGGD ON DIEM.LOPMH = PHANCONGGD.LOPMH INNER JOIN
             MONHOC ON PHANCONGGD.MAMH = MONHOC.MAMH 
             WHERE ((DIEM.DIEMCC * 0.1 + DIEM.DIEMKT1 * 0.3) + DIEM.DIEMTHI * 0.6 > 4)
             GROUP BY DIEM.MASV, PHANCONGGD.HOCKY,PHANCONGGD.NAMHOC
             HAVING (DIEM.MASV = @MASV) AND(PHANCONGGD.NAMHOC=@NAMHOC) )
			 /(SELECT COUNT((MONHOC.SOTINCHI)) FROM  DIEM INNER JOIN PHANCONGGD ON DIEM.LOPMH = PHANCONGGD.LOPMH INNER JOIN MONHOC ON PHANCONGGD.MAMH = MONHOC.MAMH 
             WHERE  (DIEM.MASV = @MASV)  AND (PHANCONGGD.NAMHOC=@NAMHOC) 
			 GROUP BY DIEM.MASV, PHANCONGGD.NAMHOC)) AS SOTCDAT,

             
		(DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)*SOTINCHI/
		(SELECT sum(SOTINCHI) FROM  DIEM INNER JOIN
             PHANCONGGD ON DIEM.LOPMH = PHANCONGGD.LOPMH INNER JOIN MONHOC ON PHANCONGGD.MAMH = MONHOC.MAMH 
             WHERE  (DIEM.MASV = @MASV)  AND (PHANCONGGD.NAMHOC=@NAMHOC) 
			 GROUP BY DIEM.MASV,PHANCONGGD.NAMHOC) AS DIEMTBC,
		 
		 CASE 
		WHEN (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)>=9.5 and (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)<=10 then 'A+'
		when (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)<=9.4 and (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)>=8.5 then 'A'
		when (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)<=8.4 and (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)>=8.0 then 'B+'
		when (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)<=7.9 and (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)>=7 then 'B'
		when (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)<=6.9 and (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)>=6.5 then 'C+'
		when (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)<=6.4 and (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)>=5.5 then 'C'
		when (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)<=5.4 and (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)>=5.0 then 'D+'
		when (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)<=4.9 and (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)>=4.0 then 'D'
		when (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)<=3.9 and (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)>=2.0 then 'F+'
		when (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)<2.0  then 'F'
		end AS DIEMCHU
		FROM SINHVIEN INNER JOIN QTHT ON SINHVIEN.MASV=QTHT.MASV INNER JOIN LOP 
		ON  QTHT.LOP=LOP.MALOP INNER JOIN DIEM ON DIEM.MASV=SINHVIEN.MASV  INNER JOIN PHANCONGGD 
		ON DIEM.LOPMH=PHANCONGGD.LOPMH INNER JOIN CHUYENNGANH 
		ON CHUYENNGANH.MANGANH=LOP.MANGANH INNER JOIN MONHOC ON PHANCONGGD.MAMH=MONHOC.MAMH INNER JOIN GIAOVIEN ON PHANCONGGD.MAGV=GIAOVIEN.MAGV
		WHERE SINHVIEN.MASV=@MASV AND PHANCONGGD.NAMHOC=@NAMHOC
		group by SINHVIEN.MASV,
		SINHVIEN.HOTENSV,
		CHUYENNGANH.TENNGANH,
		LOP.TENLOP,
		MONHOC.TENMH,
		MONHOC.SOTINCHI,
		PHANCONGGD.LOPMH,
		PHANCONGGD.NAMHOC,
		DIEM.DIEMCC,
		DIEM.DIEMKT1,
		DIEM.DIEMTHI,
		GIAOVIEN.TENGV
		end;
GO
/****** Object:  StoredProcedure [dbo].[ketquatoankhoa]    Script Date: 5/10/2023 9:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ketquatoankhoa]
	@MASV varchar(10)
	
as
begin
	select 
		SINHVIEN.MASV,
		SINHVIEN.HOTENSV,
		SINHVIEN.NGAYSINH,
		SINHVIEN.GIOITINH,
		SINHVIEN.DIACHI,
		CHUYENNGANH.TENNGANH,
		MONHOC.TENMH,
		MONHOC.SOTINCHI,
		KHOA.TENKHOA,
		DIEM.DIEMCC,
		DIEM.DIEMKT1,
		DIEM.DIEMTHI,
		((SELECT count((MONHOC.SOTINCHI)) FROM  DIEM INNER JOIN
             PHANCONGGD ON DIEM.LOPMH = PHANCONGGD.LOPMH INNER JOIN
             MONHOC ON PHANCONGGD.MAMH = MONHOC.MAMH 
			 WHERE  (DIEM.MASV = @MASV)   GROUP BY DIEM.MASV)
			 /(SELECT count((MONHOC.SOTINCHI)) FROM  DIEM INNER JOIN
             PHANCONGGD ON DIEM.LOPMH = PHANCONGGD.LOPMH INNER JOIN
             MONHOC ON PHANCONGGD.MAMH = MONHOC.MAMH 
             WHERE (DIEM.MASV = @MASV)  GROUP BY DIEM.MASV)) AS SOMH,
		(CAST((SELECT count(CAST((MONHOC.SOTINCHI) AS decimal)) FROM  DIEM INNER JOIN
             PHANCONGGD ON DIEM.LOPMH = PHANCONGGD.LOPMH INNER JOIN
             MONHOC ON PHANCONGGD.MAMH = MONHOC.MAMH 
			 WHERE ((DIEM.DIEMCC * 0.1 + DIEM.DIEMKT1 * 0.3) + DIEM.DIEMTHI * 0.6 > 4) 
			 GROUP BY DIEM.MASV having (DIEM.MASV = @MASV)  )AS DECIMAL)
			 /(SELECT COUNT((MONHOC.SOTINCHI)) FROM  DIEM INNER JOIN
             PHANCONGGD ON DIEM.LOPMH = PHANCONGGD.LOPMH INNER JOIN MONHOC ON PHANCONGGD.MAMH = MONHOC.MAMH 
             WHERE  (DIEM.MASV = @MASV)  
			 GROUP BY DIEM.MASV)) AS SOMHDAT,

		(DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6) AS TBCHP,

		((SELECT SUM(cast ((MONHOC.SOTINCHI) as decimal)) FROM  DIEM INNER JOIN PHANCONGGD ON DIEM.LOPMH = PHANCONGGD.LOPMH INNER JOIN
             MONHOC ON PHANCONGGD.MAMH = MONHOC.MAMH 
             WHERE ((DIEM.DIEMCC * 0.1 + DIEM.DIEMKT1 * 0.3) + DIEM.DIEMTHI * 0.6 > 4)
             GROUP BY DIEM.MASV, PHANCONGGD.HOCKY
             HAVING (DIEM.MASV = @MASV)  )
			 /(SELECT COUNT((MONHOC.SOTINCHI)) FROM  DIEM INNER JOIN PHANCONGGD ON DIEM.LOPMH = PHANCONGGD.LOPMH INNER JOIN MONHOC ON PHANCONGGD.MAMH = MONHOC.MAMH 
             WHERE  (DIEM.MASV = @MASV)  
			 GROUP BY DIEM.MASV)) AS SOTCDAT,

             
		(DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)*SOTINCHI/
		(SELECT sum(SOTINCHI) FROM  DIEM INNER JOIN
             PHANCONGGD ON DIEM.LOPMH = PHANCONGGD.LOPMH INNER JOIN MONHOC ON PHANCONGGD.MAMH = MONHOC.MAMH 
             WHERE  (DIEM.MASV = @MASV)  
			 GROUP BY DIEM.MASV) AS DIEMTBC,
		 
		 CASE 
		WHEN (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)>=9.5 and (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)<=10 then 'A+'
		when (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)<=9.4 and (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)>=8.5 then 'A'
		when (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)<=8.4 and (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)>=8.0 then 'B+'
		when (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)<=7.9 and (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)>=7 then 'B'
		when (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)<=6.9 and (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)>=6.5 then 'C+'
		when (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)<=6.4 and (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)>=5.5 then 'C'
		when (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)<=5.4 and (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)>=5.0 then 'D+'
		when (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)<=4.9 and (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)>=4.0 then 'D'
		when (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)<=3.9 and (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)>=2.0 then 'F+'
		when (DIEMCC*0.1+DIEMKT1*0.3+DIEMTHI*0.6)<2.0  then 'F'
		end AS DIEMCHU
		FROM SINHVIEN INNER JOIN QTHT ON SINHVIEN.MASV=QTHT.MASV INNER JOIN LOP 
		ON  QTHT.LOP=LOP.MALOP INNER JOIN DIEM ON DIEM.MASV=SINHVIEN.MASV  INNER JOIN PHANCONGGD 
		ON DIEM.LOPMH=PHANCONGGD.LOPMH INNER JOIN CHUYENNGANH 
		ON CHUYENNGANH.MANGANH=LOP.MANGANH INNER JOIN MONHOC ON PHANCONGGD.MAMH=MONHOC.MAMH INNER JOIN KHOA ON KHOA.MAKHOA=CHUYENNGANH.MAKHOA
		WHERE SINHVIEN.MASV=@MASV 
		group by SINHVIEN.MASV,
		SINHVIEN.HOTENSV,
		SINHVIEN.NGAYSINH,
		SINHVIEN.GIOITINH,
		SINHVIEN.DIACHI,
		CHUYENNGANH.TENNGANH,
		MONHOC.TENMH,
		MONHOC.SOTINCHI,
		KHOA.TENKHOA,
		DIEM.DIEMCC,
		DIEM.DIEMKT1,
		DIEM.DIEMTHI
		end;
GO
/****** Object:  StoredProcedure [dbo].[SINHVIEN_selectMALOP]    Script Date: 5/10/2023 9:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SINHVIEN_selectMALOP]
	@MALOP varchar(10),
	@NAMHOC nvarchar(12)
	
as
begin
	select 
		 SINHVIEN.*,QTHT.LOP,QTHT.NAMHOC, LOP.TENLOP 
		FROM SINHVIEN INNER JOIN QTHT ON SINHVIEN.MASV=QTHT.MASV INNER JOIN LOP ON QTHT.LOP=LOP.MALOP    
		WHERE QTHT.LOP=@MALOP	AND QTHT.NAMHOC=@NAMHOC 
end;
GO
/****** Object:  StoredProcedure [dbo].[test]    Script Date: 5/10/2023 9:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[test]
@MASV varchar(13),
@HOCKY varchar(2)
AS
BEGIN
	SELECT dbo.DIEM.MASV, dbo.DIEM.DIEMCC, dbo.DIEM.DIEMKT1, dbo.DIEM.DIEMTHI, (dbo.DIEM.DIEMCC * 0.1 + dbo.DIEM.DIEMKT1 * 0.3) + dbo.DIEM.DIEMTHI * 0.6 AS DIEMTB, SUM(((dbo.DIEM.DIEMCC * 0.1 + dbo.DIEM.DIEMKT1 * 0.3) + dbo.DIEM.DIEMTHI * 0.6) * dbo.MONHOC.SOTINCHI) 
             / SUM(dbo.MONHOC.SOTINCHI) AS Expr2, SUM(dbo.MONHOC.SOTINCHI) AS Expr1, dbo.MONHOC.TENMH, dbo.CHUONGTRINHDT.HOCKY
FROM   dbo.DIEM INNER JOIN
             dbo.PHANCONGGD ON dbo.DIEM.LOPMH = dbo.PHANCONGGD.LOPMH INNER JOIN
             dbo.MONHOC ON dbo.PHANCONGGD.MAMH = dbo.MONHOC.MAMH INNER JOIN
             dbo.CHUONGTRINHDT ON dbo.MONHOC.MAMH = dbo.CHUONGTRINHDT.MAMH
WHERE ((dbo.DIEM.DIEMCC * 0.1 + dbo.DIEM.DIEMKT1 * 0.3) + dbo.DIEM.DIEMTHI * 0.6 > 4) AND (dbo.CHUONGTRINHDT.HOCKY = @HOCKY)
GROUP BY dbo.DIEM.MASV, dbo.DIEM.DIEMCC, dbo.DIEM.DIEMKT1, dbo.DIEM.DIEMTHI, (dbo.DIEM.DIEMCC * 0.1 + dbo.DIEM.DIEMKT1 * 0.3) + dbo.DIEM.DIEMTHI * 0.6, dbo.MONHOC.TENMH, dbo.CHUONGTRINHDT.HOCKY
HAVING (dbo.DIEM.MASV = @MASV)
END
GO
/****** Object:  StoredProcedure [dbo].[tkb]    Script Date: 5/10/2023 9:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[tkb]
	@MALOP varchar(10)
	, @HOCKY varchar (10),
	@NAMHOC VARCHAR(10)
	
as
begin
	select 
		THOIKHOABIEU.*,
		MONHOC.TENMH,
		LOP.TENLOP,
		PHANCONGGD.HOCKY,
		PHANCONGGD.NAMHOC,
		GIAOVIEN.TENGV,
		MONHOC.TENMH,
		MONHOC.SOTINCHI
	FROM MONHOC INNER JOIN PHANCONGGD ON MONHOC.MAMH=PHANCONGGD.MAMH INNER JOIN GIAOVIEN ON PHANCONGGD.MAGV=GIAOVIEN.MAGV
		INNER JOIN THOIKHOABIEU ON THOIKHOABIEU.LOPMH = PHANCONGGD.LOPMH 
		INNER JOIN LOP ON LOP.MALOP=PHANCONGGD.MALOP
	WHERE PHANCONGGD.MALOP=@MALOP and PHANCONGGD.HOCKY=@HOCKY AND PHANCONGGD.NAMHOC=@NAMHOC

		
end;
GO
