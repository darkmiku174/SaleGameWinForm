
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
	GioiTinh bit, -- 1 là nữ, 0 là nam
	Loai BIT, --1 là nhân viên, 0 là chủ
	Constraint NV_MSNV_PK Primary Key(MSNV)
)

--Tạo bảng account
Create Table TaiKhoan
(
	MSNV VARCHAR(20),
	MatKhau NVARCHAR(128),
	Constraint TK_PK Primary Key(MSNV)
)

--Tạo bảng Lịch sử login logout
Create Table LichSuLogin
(
	ID VARCHAR(20),
	MSNV VARCHAR(20),
    Login DATETIME,
	Logout DATETIME,
	Constraint NK_PK Primary Key(ID)
)

--Tạo khoá ngoại
alter table DonHang add constraint DH_MSDH_FK foreign key(MSDH) references HoaDon(MSDH)
alter table DonHang add constraint DH_MSHH_FK foreign key(MSHH) references Game(MSHH)

alter table HoaDon add constraint HD_MSNV_FK foreign key(MSNV) references NhanVien(MSNV)

alter table TaiKhoan add constraint TK_MSNV_FK foreign key(MSNV) references NhanVien(MSNV)

alter table LichSuLogin add constraint LS_MSNV_FK foreign key(MSNV) references NhanVien(MSNV)


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

--Nhập dữ liệu bảng Nhân viên
Insert into NhanVien
Values('NV01', N'Nguyễn Quốc Bằng', 0, 0)
Insert into NhanVien
Values('NV02', N'Bùi Nguyên Phúc', 0, 1)
Insert into NhanVien
Values('NV03', N'Đỗ Đức Minh', 0, 1)
Insert into NhanVien
Values('NV04', N'Huỳnh Thanh Hoài', 0, 1)
Insert into NhanVien
Values('NV05', N'Nguyễn Thanh Minh Duy', 0, 1)
Insert into NhanVien
Values('NV06', N'Nguyễn Trường An', 0, 1)
Insert into NhanVien
Values('NV07', N'Trần Trung Chiến', 0, 1)
Insert into NhanVien
Values('NV08', N'Võ Hoài Lâm', 0, 1)
Insert into NhanVien
Values('NV09', N'Nguyễn Hoài Lâm', 0, 1)
Insert into NhanVien
Values('NV10', N'Lâm Thục Tường Vi', 1, 1)
Insert into NhanVien
Values('NV11', N'Huỳnh Kha Tường', 1, 1)
Insert into NhanVien
Values('NV12', N'Nguyễn Phước An', 1, 1)

--Nhập dữ liệu bảng Account
Insert into TaiKhoan
Values('NV01',N'Bangbang@123')

--Nhập dữ liệu login logout
Insert into LichSuLogin
Values('1','NV01','2019/8/8 9:30:03', '2019/8/8 21:05:00')
Insert into LichSuLogin
Values('2','NV02','2019/8/13 7:30:03', '2019/8/13 14:00:45')
Insert into LichSuLogin
Values('3','NV05','2019/8/13 14:05:13', '2019/8/13 21:00:45')
Insert into LichSuLogin
Values('4','NV03','2019/8/14 7:31:42', '2019/8/14 14:10:35')
Insert into LichSuLogin
Values('5','NV05','2019/8/14 14:15:12', '2019/8/14 21:10:35')
Insert into LichSuLogin
Values('6','NV02','2019/8/15 7:29:22', '2019/8/15 14:05:15')
Insert into LichSuLogin
Values('7','NV04','2019/8/15 14:7:19', '2019/8/15 21:00:15')
Insert into LichSuLogin
Values('8','NV02','2019/8/16 7:30:24', '2019/8/16 14:03:31')
Insert into LichSuLogin
Values('9','NV04','2019/8/16 14:7:50', '2019/8/16 21:10:15')
Insert into LichSuLogin
Values('10','NV02','2019/8/17 7:33:04', '2019/8/17 14:08:36')
Insert into LichSuLogin
Values('11','NV03','2019/8/17 14:10:05', '2019/8/17 21:00:15')

--Nhập dữ liệu bảng hoá đơn
Insert into HoaDon
Values('HD1', 'NV02', '2019/8/13 8:30:15')
Insert into HoaDon
Values('HD2', 'NV02', '2019/8/17 8:3:45')
Insert into HoaDon
Values('HD3', 'NV05', '2019/8/17 20:50:02')
Insert into HoaDon
Values('HD4', 'NV07', '2019/8/18 16:33:15')
Insert into HoaDon
Values('HD5', 'NV04', '2019/8/23 10:24:18')
Insert into HoaDon
Values('HD6', 'NV05', '2019/8/25 13:07:57')

--Nhập dữ liệu bảng đơn hàng
Insert into DonHang
Values('HD1', 'G001', 1, 0)
Insert into DonHang
Values('HD1', 'G003', 2, 0)
Insert into DonHang
Values('HD1', 'G002', 1, 0)
Insert into DonHang
Values('HD1', 'G004', 3, 0)
Insert into DonHang
Values('HD2', 'G011', 1, 0)
Insert into DonHang
Values('HD2', 'G017', 1, 0)
Insert into DonHang
Values('HD3', 'G025', 3, 10)
Insert into DonHang
Values('HD4', 'G027', 1, 0)
Insert into DonHang
Values('HD4', 'G023', 1, 20)
Insert into DonHang
Values('HD5', 'G003', 1, 0)
Insert into DonHang
Values('HD5', 'G010', 2, 0)
Insert into DonHang
Values('HD6', 'G005', 5, 20)
Insert into DonHang
Values('HD6', 'G001', 1, 0)
Insert into DonHang
Values('HD6', 'G013', 1, 0)
Insert into DonHang
Values('HD6', 'G009', 1, 0)

select MSNV, TenNV,
case	
	When GioiTinh=1 then N'Nữ'
	else 'Nam' end as GioiTinh,
case	
	When Loai=1 then N'Nhân viên'
	else N'Chủ' end as Loai 
from NhanVien
select * from NhanVien