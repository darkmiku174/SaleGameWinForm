
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
	MatKhau VarBinary(128),
	Constraint TK_PK Primary Key(MSNV)
)

--Tạo bảng Lịch sử login logout
Create Table LichSuLogin
(
	ID bigint,
	MSNV VARCHAR(20),
    Event VARCHAR(6),
	Date DATE,
	Time TIME,
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
values('G001', 'Sekiro: Shadow die twice', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\sekiro.jpg', SINGLE_CLOB) as Image), 1200000, 1)
Insert into Game
values('G002', 'Demon Souls', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\demonsouls.jpg', SINGLE_CLOB) as Image), 800000, 1)
Insert into Game
values('G003', 'Dark Soul 2', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\darksoul2.jpg', SINGLE_CLOB) as Image), 900000, 1)
Insert into Game
values('G004', 'Dark Soul 3', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\darksoul3.jpg', SINGLE_CLOB) as Image), 1100000, 1)
Insert into Game
values('G005', 'Blood Borne', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\bloodborne.jpg', SINGLE_CLOB) as Image), 900000, 1)
Insert into Game
values('G006', 'Aragami', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\aragami.jpg', SINGLE_CLOB) as Image), 200000, 1)
Insert into Game
values('G007', 'Astroneer', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\astroneer.jpg', SINGLE_CLOB) as Image), 400000, 0)
Insert into Game
values('G008', 'Battle Chasers: Nightwar', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\battlechasersnightwar.jpg', SINGLE_CLOB) as Image), 200000, 0)
Insert into Game
values('G009', 'Beholder', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\beholder.jpg', SINGLE_CLOB) as Image), 200000, 1)
Insert into Game
values('G010', 'Blasphemous', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\blasphemous.jpg', SINGLE_CLOB) as Image), 200000, 1)
Insert into Game
values('G011', 'Catherine Classic', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\catherine.jpg', SINGLE_CLOB) as Image), 150000, 1)
Insert into Game
values('G012', 'Civilization V', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\civilization5.jpg', SINGLE_CLOB) as Image), 650000, 1)
Insert into Game
values('G013', 'Dark Deception', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\darkdeception.jpg', SINGLE_CLOB) as Image), 120000, 1)
Insert into Game
values('G014', 'Divinity: Original Sin 2 - Definitive Edition', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\divinity2.jpg', SINGLE_CLOB) as Image), 300000, 0)
Insert into Game
values('G015', 'Darkest Dungeon', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\darkestdungeon.jpg', SINGLE_CLOB) as Image), 450000, 1)
Insert into Game
values('G016', 'Dont Starve', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\dontstarve.jpg', SINGLE_CLOB) as Image), 150000, 1)
Insert into Game
values('G017', 'Frostpunk', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\frostpunk.jpg', SINGLE_CLOB) as Image), 200000, 1)
Insert into Game
values('G018', 'Gorogoa', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\gorogoa.jpg', SINGLE_CLOB) as Image), 80000, 1)
Insert into Game
values('G019', 'Gris', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\gris.jpg', SINGLE_CLOB) as Image), 150000, 1)
Insert into Game
values('G020', 'Katana Zero', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\katanazero.jpg', SINGLE_CLOB) as Image), 180000, 1)
Insert into Game
values('G021', 'My Friend Pedro', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\myfriendpedro.jpg', SINGLE_CLOB) as Image), 180000, 1)
Insert into Game
values('G022', 'Ori And The Blind Forest', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\ori1.jpg', SINGLE_CLOB) as Image), 120000, 1)
Insert into Game
values('G023', 'Ori And The Will Of The Wisps', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\ori2.jpg', SINGLE_CLOB) as Image), 300000, 1)
Insert into Game
values('G024', 'Oxygen Not Included', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\oxygennotincluded.jpg', SINGLE_CLOB) as Image), 180000, 1)
Insert into Game
values('G025', 'Stardew Valley', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\stardewvalley.jpg', SINGLE_CLOB) as Image), 180000, 1)
Insert into Game
values('G026', 'This War Of Mine', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\thiswarofmine.jpg', SINGLE_CLOB) as Image), 180000, 0)
Insert into Game
values('G027', 'Total War: Shogun2', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\totalwarshogun2.jpg', SINGLE_CLOB) as Image), 500000, 1)
Insert into Game
values('G028', 'Total War: Three Kingdom Lady Trieu', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\totalwarthreekingdom.jpg', SINGLE_CLOB) as Image), 880000, 1)
Insert into Game
values('G029', 'Total War Sage: Troy', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\totalwartroy.jpg', SINGLE_CLOB) as Image), 1200000, 0)
Insert into Game
values('G030', 'Animal Crossing: New Horizons', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\animalcrossing.jpg', SINGLE_CLOB) as Image), 1200000, 0)
Insert into Game
values('G031', 'Bloodstained: Ritual Of The Night', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\bloodstained.jpg', SINGLE_CLOB) as Image), 310000, 1)
Insert into Game
values('G032', 'Cyberpunk 2077', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\cyberpunk.jpg', SINGLE_CLOB) as Image), 990000, 0)
Insert into Game
values('G033', 'Code Vein', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\codevein.jpg', SINGLE_CLOB) as Image), 800000, 1)
Insert into Game
values('G034', 'Control', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\CONTROL.jpg', SINGLE_CLOB) as Image), 1200000, 1)
Insert into Game
values('G035', 'Death Strading', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\deathstrading.jpg', SINGLE_CLOB) as Image), 990000, 0)
Insert into Game
values('G036', 'Enter The Gungeon', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\enterthegungeon.jpg', SINGLE_CLOB) as Image), 120000, 1)
Insert into Game
values('G037', 'Final Fantasy 7 Remake', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\ff7r.jpg', SINGLE_CLOB) as Image), 1200000, 1)
Insert into Game
values('G038', 'Ghost Of Tsushima', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\ghostoftsushima.jpg', SINGLE_CLOB) as Image), 1200000, 1)
Insert into Game
values('G039', 'Nioh 2', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\nioh2.jpg', SINGLE_CLOB) as Image), 380000, 1)
Insert into Game
values('G040', 'God of War 3', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\godofwar.jpg', SINGLE_CLOB) as Image), 800000, 1)
Insert into Game
values('G041', 'Hollow Knight', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\hollowknight.jpg', SINGLE_CLOB) as Image), 220000, 1)
Insert into Game
values('G042', 'Metal Gear Solid V: The Phantom Pain', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\metalgear5.jpg', SINGLE_CLOB) as Image), 75000, 1)
Insert into Game
values('G043', 'Monster Hunter: World', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\monsterhunter.jpg', SINGLE_CLOB) as Image), 350000, 1)
Insert into Game
values('G044', 'Orwell: Ignorance Is Strength', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\orwell.jpg', SINGLE_CLOB) as Image), 55000, 1)
Insert into Game
values('G045', 'Personal 4 Golden', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\personal4.jpg', SINGLE_CLOB) as Image), 300000, 1)
Insert into Game
values('G046', 'Risk Of Rain 2', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\riskofrain2.jpg', SINGLE_CLOB) as Image), 180000, 1)
Insert into Game
values('G047', 'Sayonara Wild Hearts', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\SayonaraWildHearts.jpg', SINGLE_CLOB) as Image), 200000, 1)
Insert into Game
values('G048', 'Shadow Tactics: Blades Of The Shogun', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\shadowtactics.jpg', SINGLE_CLOB) as Image), 50000, 1)
Insert into Game
values('G049', 'Spirit Hunter: Death Mark', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\spirithunter.jpg', SINGLE_CLOB) as Image), 165000, 1)
Insert into Game
values('G050', 'The Beast Inside', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\thebeastinside.jpg', SINGLE_CLOB) as Image), 165000, 1)
Insert into Game
values('G051', 'The Last Of Us', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\thelastofus.jpg', SINGLE_CLOB) as Image), 900000, 1)
Insert into Game
values('G052', 'Valiant Hearts: The Great War', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\valianthearts.jpg', SINGLE_CLOB) as Image), 380000, 1)
Insert into Game
values('G053', 'Total War: WARHAMMER II', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\warhammer.jpg', SINGLE_CLOB) as Image), 250000, 1)
Insert into Game
values('G054', 'Dead Cells', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\deadcells.jpg', SINGLE_CLOB) as Image), 250000, 1)
Insert into Game
values('G055', 'DJMAX RESPECT V', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\djmax5.jpg', SINGLE_CLOB) as Image), 1200000, 1)
Insert into Game
values('G056', 'Do Not Feed The Monkey', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\donotfeedthemonkey.jpg', SINGLE_CLOB) as Image), 150000, 0)
Insert into Game
values('G057', 'FAR: Alone Sails', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\faralonesails.jpg', SINGLE_CLOB) as Image), 180000, 1)
Insert into Game
values('G058', 'Five Night At Freddy''s: Sister Location', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\fivenight.jpg', SINGLE_CLOB) as Image), 220000, 1)
Insert into Game
values('G059', 'Florence', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\florence.jpg', SINGLE_CLOB) as Image), 80000, 1)
Insert into Game
values('G060', 'Furi', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\furi.jpg', SINGLE_CLOB) as Image), 180000, 1)
Insert into Game
values('G061', 'God Eater 3', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\godeater3.jpg', SINGLE_CLOB) as Image), 950000, 1)
Insert into Game
values('G062', 'Grim Dawn', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\grimdawn.jpg', SINGLE_CLOB) as Image), 250000, 1)
Insert into Game
values('G063', 'Hades', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\hades.jpg', SINGLE_CLOB) as Image), 300000, 1)
Insert into Game
values('G064', 'ICEY', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\icey.jpg', SINGLE_CLOB) as Image), 220000, 0)
Insert into Game
values('G065', 'Inside', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\inside.jpg', SINGLE_CLOB) as Image), 150000, 1)
Insert into Game
values('G066', 'Interrogation: You Will Be Deceived', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\interrogation.jpg', SINGLE_CLOB) as Image), 180000, 1)
Insert into Game
values('G067', 'Liberated', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\liberated.jpg', SINGLE_CLOB) as Image), 220000, 0)
Insert into Game
values('G068', 'Limbo', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\limbo.jpg', SINGLE_CLOB) as Image), 150000, 1)
Insert into Game
values('G069', 'MO: Astray', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\moastray.jpg', SINGLE_CLOB) as Image), 250000, 1)
Insert into Game
values('G070', 'Paranormal HK', (SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\Lập trình windows\SaleGameWinForm\PictuerGame\paranormalhk.jpg', SINGLE_CLOB) as Image), 250000, 1)


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
Insert into NhanVien
Values('NV13', N'Lê Ngọc Đan Khanh', 1, 1)

--Nhập dữ liệu bảng Account (Nhập bằng app)

--Nhập dữ liệu login logout
Insert into LichSuLogin
Values(1,'NV01', 'Login','2019/8/8', '9:30:03')
Insert into LichSuLogin
Values(2,'NV01','Logout','2019/8/8', '21:05:00')
Insert into LichSuLogin
Values(3,'NV02', 'Login','2019/8/13', '7:30:03')
Insert into LichSuLogin
Values(4,'NV02','Logout','2019/8/13', '14:00:45')
Insert into LichSuLogin
Values(5,'NV05', 'Login','2019/8/13', '14:05:13')
Insert into LichSuLogin
Values(6,'NV05','Logout','2019/8/13', '21:00:45')
Insert into LichSuLogin
Values(7,'NV03', 'Login','2019/8/14', '7:31:42')
Insert into LichSuLogin
Values(8,'NV03','Logout','2019/8/14', '14:10:35')
Insert into LichSuLogin
Values(9,'NV05', 'Login','2019/8/14', '14:15:12')
Insert into LichSuLogin
Values(10,'NV05','Logout','2019/8/14', '21:10:35')
Insert into LichSuLogin
Values(11,'NV02', 'Login','2019/8/15', '7:29:22')
Insert into LichSuLogin
Values(12,'NV02','Logout','2019/8/15', '14:05:15')
Insert into LichSuLogin
Values(13,'NV04', 'Login','2019/8/15', '14:7:19')
Insert into LichSuLogin
Values(14,'NV04','Logout','2019/8/15', '21:00:15')
Insert into LichSuLogin
Values(15,'NV02', 'Login','2019/8/16', '7:30:24')
Insert into LichSuLogin
Values(16,'NV02','Logout','2019/8/16', '14:03:31')
Insert into LichSuLogin
Values(17,'NV04', 'Login','2019/8/16', '14:7:50')
Insert into LichSuLogin
Values(18,'NV04','Logout','2019/8/16', '21:10:15')
Insert into LichSuLogin
Values(19,'NV02', 'Login','2019/8/17', '7:33:04')
Insert into LichSuLogin
Values(20,'NV02','Logout','2019/8/17', '14:08:36')
Insert into LichSuLogin
Values(21,'NV03', 'Login','2019/8/17', '14:10:05')
Insert into LichSuLogin
Values(22,'NV03','Logout','2019/8/17', '21:00:15')

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

Insert into HoaDon
Values('HD7', 'NV09', '2019/8/26 15:15:57')
Insert into HoaDon
Values('HD8', 'NV04', '2019/8/27 9:07:57')
Insert into HoaDon
Values('HD9', 'NV04', '2019/8/27 11:07:45')
Insert into HoaDon
Values('HD10', 'NV12', '2019/8/28 19:37:32')
Insert into HoaDon
Values('HD11', 'NV11', '2019/8/29 10:11:34')
Insert into HoaDon
Values('HD12', 'NV03', '2019/8/29 17:02:05')
Insert into HoaDon
Values('HD13', 'NV03', '2019/8/29 20:19:52')
Insert into HoaDon
Values('HD14', 'NV05', '2019/8/30 15:51:22')
Insert into HoaDon
Values('HD15', 'NV07', '2019/8/31 13:52:41')
Insert into HoaDon
Values('HD16', 'NV12', '2019/9/1 9:45:02')
Insert into HoaDon
Values('HD17', 'NV10', '2019/9/2 20:07:12')
Insert into HoaDon
Values('HD18', 'NV09', '2019/9/3 17:53:01')
Insert into HoaDon
Values('HD19', 'NV07', '2019/9/4 11:16:45')
Insert into HoaDon
Values('HD20', 'NV04', '2019/9/4 19:27:31')

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

select * from LichSuLogin

delete from LichSuLogin where id in (23,24,25,26,27,28,29,30)

select * from game where TinhTrang=0

Select Top 15(MSDH), TenNV, NgayDat
From HoaDon, NhanVien 
Where HoaDon.MSNV=NhanVien.MSNV
Order By NgayDat Desc