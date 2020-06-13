--Xoá database
use master ;
go
drop database SaleGame

Create DataBase SaleGame
Go
Use SaleGame

--Tạo bảng game
Create Table Game
(
	MSHH VARCHAR(20),
	TenGame VARCHAR(50),
	HinhAnh Image,
	Gia Int,
    TinhTrang  BIT,
	Constraint G_MSHH_PK Primary Key(MSHH)
)

--Tạo bảng đơn hàng
Create Table DonHang
(
    MSDH VARCHAR(20),
	MSHH VARCHAR(20),
	SoLuong Int,
    TiLeGiam Int,
	Constraint DH_PK Primary Key(MSDH, MSHH)
)

--Tạo bảng hoá đơn
Create Table HoaDon
(
    MSDH VARCHAR(20),
	MSNV VARCHAR(20),
    NgayDat DATETIME,
	Constraint HD_PK Primary Key(MSDH)
)

--Tạo bảng nhân viên
Create Table NhanVien
(
	MSNV VARCHAR(20),
	TenNV NVARCHAR(50),
	Loai BIT, --1 là nhân viên, 0 là chủ
	Constraint NV_MSNV_PK Primary Key(MSNV)
)

--Tạo bảng account
Create Table TaiKhoan
(
	MSNV VARCHAR(20),
	TenTaiKhoan VARCHAR(25),
	MatKhau VARBINARY,
	ChiaKhoa VARBINARY,
	IV VARBINARY,
	Constraint TK_PK Primary Key(MSNV)
)

--Tạo bảng Nhập kho
Create Table NhapKho
(
    MSNK VARCHAR(20),
	MSHH VARCHAR(20),
	MSNV VARCHAR(20),
    NgayNhap DATETIME,
	Constraint NK_PK Primary Key(MSNK)
)

--Tạo khoá ngoại
alter table DonHang add constraint DH_MSDH_FK foreign key(MSDH) references HoaDon(MSDH)
alter table DonHang add constraint DH_MSHH_FK foreign key(MSHH) references Game(MSHH)

alter table HoaDon add constraint HD_MSNV_FK foreign key(MSNV) references NhanVien(MSNV)

alter table TaiKhoan add constraint TK_MSNV_FK foreign key(MSNV) references NhanVien(MSNV)

alter table NhapKho add constraint NK_MSNV_FK foreign key(MSNV) references NhanVien(MSNV)
alter table NhapKho add constraint NK_MSHH_FK foreign key(MSHH) references Game(MSHH)

--Nhập dữ liệu cho bảng thức uống
Insert into Game
values('G001', 'Sekiro: Shadow die twice', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\FinalExam\PictuerGame\sekiro.jpg', SINGLE_CLOB) as Image), 1200000, 1)
Insert into Game
values('G002', 'Demon Souls', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\FinalExam\PictuerGame\demonsouls.jpg', SINGLE_CLOB) as Image), 800000, 1)
Insert into Game
values('G003', 'Dark Soul 2', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\FinalExam\PictuerGame\darksoul2.jpg', SINGLE_CLOB) as Image), 900000, 1)
Insert into Game
values('G004', 'Dark Soul 3', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\FinalExam\PictuerGame\darksoul3.jpg', SINGLE_CLOB) as Image), 1100000, 1)
Insert into Game
values('G005', 'Blood Borne', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\FinalExam\PictuerGame\bloodborne.jpg', SINGLE_CLOB) as Image), 900000, 1)
Insert into Game
values('G006', 'Aragami', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\FinalExam\PictuerGame\aragami.jpg', SINGLE_CLOB) as Image), 200000, 1)
Insert into Game
values('G007', 'Astroneer', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\FinalExam\PictuerGame\astroneer.jpg', SINGLE_CLOB) as Image), 400000, 0)
Insert into Game
values('G008', 'Battle Chasers: Nightwar', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\FinalExam\PictuerGame\battlechasersnightwar.jpg', SINGLE_CLOB) as Image), 200000, 0)
Insert into Game
values('G009', 'Beholder', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\FinalExam\PictuerGame\beholder.jpg', SINGLE_CLOB) as Image), 200000, 1)
Insert into Game
values('G010', 'Blasphemous', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\FinalExam\PictuerGame\blasphemous.jpg', SINGLE_CLOB) as Image), 200000, 1)
Insert into Game
values('G011', 'Catherine Classic', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\FinalExam\PictuerGame\catherine.jpg', SINGLE_CLOB) as Image), 150000, 1)
Insert into Game
values('G012', 'Civilization V', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\FinalExam\PictuerGame\civilization5.jpg', SINGLE_CLOB) as Image), 650000, 1)
Insert into Game
values('G013', 'Dark Deception', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\FinalExam\PictuerGame\darkdeception.jpg', SINGLE_CLOB) as Image), 120000, 1)
Insert into Game
values('G014', 'Divinity: Original Sin 2 - Definitive Edition', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\FinalExam\PictuerGame\divinity2.jpg', SINGLE_CLOB) as Image), 300000, 0)
Insert into Game
values('G015', 'Darkest Dungeon', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\FinalExam\PictuerGame\darkestdungeon.jpg', SINGLE_CLOB) as Image), 450000, 1)
Insert into Game
values('G016', 'Dont Starve', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\FinalExam\PictuerGame\dontstarve.jpg', SINGLE_CLOB) as Image), 150000, 1)
Insert into Game
values('G017', 'Frostpunk', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\FinalExam\PictuerGame\frostpunk.jpg', SINGLE_CLOB) as Image), 200000, 1)
Insert into Game
values('G018', 'Gorogoa', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\FinalExam\PictuerGame\gorogoa.jpg', SINGLE_CLOB) as Image), 80000, 1)
Insert into Game
values('G019', 'Gris', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\FinalExam\PictuerGame\gris.jpg', SINGLE_CLOB) as Image), 150000, 1)
Insert into Game
values('G020', 'Katana Zero', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\FinalExam\PictuerGame\katanazero.jpg', SINGLE_CLOB) as Image), 180000, 1)
Insert into Game
values('G021', 'My Friend Pedro', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\FinalExam\PictuerGame\myfriendpedro.jpg', SINGLE_CLOB) as Image), 180000, 1)
Insert into Game
values('G022', 'Ori And The Blind Forest', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\FinalExam\PictuerGame\ori1.jpg', SINGLE_CLOB) as Image), 120000, 1)
Insert into Game
values('G023', 'Ori And The Will Of The Wisps', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\FinalExam\PictuerGame\ori2.jpg', SINGLE_CLOB) as Image), 300000, 1)
Insert into Game
values('G024', 'Oxygen Not Included', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\FinalExam\PictuerGame\oxygennotincluded.jpg', SINGLE_CLOB) as Image), 180000, 1)
Insert into Game
values('G025', 'Stardew Valley', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\FinalExam\PictuerGame\stardewvalley.jpg', SINGLE_CLOB) as Image), 180000, 1)
Insert into Game
values('G026', 'This War Of Mine', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\FinalExam\PictuerGame\thiswarofmine.jpg', SINGLE_CLOB) as Image), 180000, 0)
Insert into Game
values('G027', 'Total War: Shogun2', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\FinalExam\PictuerGame\totalwarshogun2.jpg', SINGLE_CLOB) as Image), 500000, 1)
Insert into Game
values('G028', 'Total War: Three Kingdom Lady Trieu', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\FinalExam\PictuerGame\totalwarthreekingdom.jpg', SINGLE_CLOB) as Image), 880000, 1)
Insert into Game
values('G029', 'Total War Sage: Troy', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\FinalExam\PictuerGame\totalwartroy.jpg', SINGLE_CLOB) as Image), 1200000, 0)

--Nhập dữ liệu bảng đơn hàng

--Nhập dữ liệu bảng hoá đơn

--Nhập dữ liệu bảng Nhân viên
Insert into NhanVien
Values('NV01', N'Nguyễn Quốc Bằng', 0)
Insert into NhanVien
Values('NV02', N'Bùi Nguyên Phúc', 1)
Insert into NhanVien
Values('NV03', N'Đỗ Đức Minh', 1)
Insert into NhanVien
Values('NV04', N'Huỳnh Thanh Hoài', 1)
Insert into NhanVien
Values('NV05', N'Nguyễn Thanh Minh Duy', 1)
Insert into NhanVien
Values('NV06', N'Nguyễn Trường An', 1)
Insert into NhanVien
Values('NV07', N'Trần Trung Chiến', 1)
Insert into NhanVien
Values('NV08', N'Võ Hoài Lâm', 1)
Insert into NhanVien
Values('NV09', N'Nguyễn Hoài Lâm', 1)
Insert into NhanVien
Values('NV10', N'Lâm Thục Tường Vi', 1)
Insert into NhanVien
Values('NV11', N'Huỳnh Kha Tường', 1)

--Nhập dữ liệu bảng Account
--Nhập bằng app Sale Game

--Nhập dữ liệu bảng Nhập Kho

select * from TaiKhoan

drop table TaiKhoan 