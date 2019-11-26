USE master
GO
IF DB_ID('BaoCaoKhoaHoc') IS NOT NULL
	DROP DATABASE BaoCaoKhoaHoc
CREATE DATABASE BaoCaoKhoaHoc
GO 
USE BaoCaoKhoaHoc
GO

CREATE TABLE TacGia
(
	MaTacGia      nvarchar(50) NOT NULL,
	HoTen        nvarchar(50)NOT NULL,
	MatKhau      nvarchar(50)NOT NULL,
	QuocGia       nvarchar(50) NOT NULL,
    SDT           int NOT NULL,	
	primary key (MaTacGia),	
)
GO
CREATE TABLE WebDangTai
(
      Ma_website nvarchar(50) NOT NULL,
      NoiDangTai nvarchar(50) NOT NULL,
	  SoTrang    nvarchar(50) NOT NULL,
	  TG_DangTai nvarchar(50)NOT NULL,
	  website nvarchar(50) NULL,
	  idQuanLy nvarchar(50)NOT NULL,
	  primary key(Ma_website),
)
GO
CREATE TABLE NhomTacGia
(
    MaNhom     nvarchar(50) NOT NULL,
	TenNhom nvarchar(50)        NOT NULL,
    primary key(MaNhom)
 )
GO
CREATE TABLE DangTai
(
    MaNhom     nvarchar(50) NOT NULL,
	Ma_website nvarchar(50) NOT NULL,
	primary key(MaNhom),
	Foreign key(Ma_website) references WebDangTai(Ma_website),
   Foreign key(MaNhom) references NhomTacGia(MaNhom),
)
CREATE TABLE QuanHeTGNhom
(
   MaTacGia nvarchar(50) NOT NULL,
   MaNhom    nvarchar(50) NOT NULL,
   primary key(MaNhom),
   Foreign key(MaTacGia) references TacGia(MaTacGia),
   Foreign key(MaNhom) references NhomTacGia(MaNhom),
)

CREATE TABLE TheLoaiNghienCuu
(
    MaTheLoai nvarchar(50) NOT NULL,
	TenTheLoai nvarchar(50) NOT NULL,
	primary key(MaTheLoai)
)
CREATE TABLE QuanLy
(   
        idQuanLy  nvarchar(50) NOT NULL,
		Ma_website nvarchar(50) NOT NULL,
		MatKhau     nvarchar(50) NOT NULL,
		SoWebQuanLy  int NOT NULL,
		HoVaTen     nvarchar(50) NOT NULL,
		QueQuan      nvarchar(50) NOT NULL,
		SDT          int NOT NULL,
		primary key(idQuanly),
)
GO

CREATE TABLE QuanheWeb_QL
(   
        QuanLy  nvarchar(50) NOT NULL,
		Ma_website nvarchar(50) NOT NULL,
		primary key(QuanLy),
		Foreign key(QuanLy) references QuanLy(idQuanLy),
		Foreign key(Ma_Website) references WebDangTai(Ma_website),
)
GO
CREATE TABLE NoiDungChinh
(
	MaTieuDe               nvarchar(50) NOT NULL,
	TieuDe             nvarchar(50)NOT NULL,
    NhomTacGia            nvarchar(50) NOT NULL,
    TheLoaiNghienCuu      nvarchar(50) NOT NULL,
	QuanLy         nvarchar(50) NOT NULL,
    primary key(MaTieuDe),
	Foreign key(NhomTacGia) references NhomTacGia(MaNhom),
	Foreign key(TheLoaiNghienCuu) references TheLoaiNghienCuu(MaTheLoai),
	Foreign key(QuanLy) references QuanLy(idQuanLy),
)
Go
INSERT Tacgia(MaTacGia,HoTen,MatKhau,QuocGia,SDT) VALUES 
('17140001', 'Michelle','1234','USE',840123144),
('17140002','Mayteh', '4321','CANADA',0139355251)
GO
INSERT QuanLy(idQuanLy,Ma_website,MatKhau,SoWebQuanLy,HoVaTen,QueQuan,SDT) VALUES 
('16145255', '9402','trongtuong05',2,'davidvila','Australia','24019244'),
('16145253','9401','tanvy123',3,'jaxMIcal','USE','29033313')
GO
INSERT WebDangTai(Ma_website,NoiDangTai,SoTrang,TG_DangTai,website,idQuanLy) VALUES 
('9401', 'Báo Khoa Học','200','14/06/2015','https://www.esm.psu.edu/academics','16145255'),
('9402', 'Báo Công Nghệ','500','14/06/2018','https://www.esm.psu.edu/academics/undergraduate','16145253')
GO
INSERT NhomTacGia(MaNhom,TenNhom) VALUES 
('0235', 'Mix_chell'),
('0351','Mayfeu')
GO
INSERT DangTai(MaNhom,Ma_website) VALUES 
('0235', '9402'),
('0351','9401')
GO
INSERT QuanheWeb_QL(QuanLy,Ma_website) VALUES 
('16145255', '9402'),
('16145253','9401')
GO

INSERT QuanHeTGNhom(MaNhom,MaTacGia) VALUES 
('0235', '17140001'),
('0351','17140002')
GO
INSERT TheLoaiNghienCuu(MaTheLoai,TenTheLoai) VALUES 
('901', 'engineer'),
('902','bodylanguage')
GO
INSERT NoiDungChinh(MaTieuDe,TieuDe,NhomTacGia,TheLoaiNghienCuu,QuanLy) VALUES 
('0002','Study IT and Engineering','0235','902','16145255'),
('0541','engineer vector','0351','901','16145253')


