
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
Insert into LichSuLogin
Values(23,'NV12','Login','2019/8/18', '7:32:43')
Insert into LichSuLogin
Values(24,'NV12','Logout','2019/8/18', '14:00:23')
Insert into LichSuLogin
Values(25,'NV07','Login','2019/8/18', '14:04:45')
Insert into LichSuLogin
Values(26,'NV07','Logout','2019/8/18', '21:00:07')
Insert into LichSuLogin
Values(27,'NV02','Login','2019/8/19', '7:35:42')
Insert into LichSuLogin
Values(28,'NV02','Logout','2019/8/19', '14:01:25')
Insert into LichSuLogin
Values(29,'NV05','Login','2019/8/19', '14:05:07')
Insert into LichSuLogin
Values(30,'NV05','Logout','2019/8/19', '21:06:07')
Insert into LichSuLogin
Values(31,'NV02','Login','2019/8/20', '7:29:53')
Insert into LichSuLogin
Values(32,'NV02','Logout','2019/8/20', '14:01:25')
Insert into LichSuLogin
Values(33,'NV11','Login','2019/8/20', '14:05:07')
Insert into LichSuLogin
Values(34,'NV11','Logout','2019/8/20', '21:06:07')
Insert into LichSuLogin
Values(35,'NV04','Login','2019/8/21', '7:29:53')
Insert into LichSuLogin
Values(36,'NV04','Logout','2019/8/21', '14:01:25')
Insert into LichSuLogin
Values(37,'NV12','Login','2019/8/21', '14:05:07')
Insert into LichSuLogin
Values(38,'NV12','Logout','2019/8/21', '21:06:07')
Insert into LichSuLogin
Values(39,'NV03','Login','2019/8/22', '7:29:53')
Insert into LichSuLogin
Values(40,'NV03','Logout','2019/8/22', '14:01:25')
Insert into LichSuLogin
Values(41,'NV02','Login','2019/8/22', '14:05:07')
Insert into LichSuLogin
Values(42,'NV02','Logout','2019/8/22', '21:06:07')
Insert into LichSuLogin
Values(43,'NV05','Login','2019/8/23', '7:29:53')
Insert into LichSuLogin
Values(44,'NV05','Logout','2019/8/23', '14:01:25')
Insert into LichSuLogin
Values(45,'NV04','Login','2019/8/23', '14:05:07')
Insert into LichSuLogin
Values(46,'NV04','Logout','2019/8/23', '21:06:07')
Insert into LichSuLogin
Values(47,'NV06','Login','2019/8/24', '7:29:53')
Insert into LichSuLogin
Values(48,'NV06','Logout','2019/8/24', '14:01:25')
Insert into LichSuLogin
Values(49,'NV07','Login','2019/8/24', '14:05:07')
Insert into LichSuLogin
Values(50,'NV07','Logout','2019/8/24', '21:06:07')
Insert into LichSuLogin
Values(51,'NV05','Login','2019/8/25', '7:29:53')
Insert into LichSuLogin
Values(52,'NV05','Logout','2019/8/25', '14:01:25')
Insert into LichSuLogin
Values(53,'NV08','Login','2019/8/25', '14:05:07')
Insert into LichSuLogin
Values(54,'NV08','Logout','2019/8/25', '21:06:07')
Insert into LichSuLogin
Values(55,'NV13','Login','2019/8/26', '7:29:53')
Insert into LichSuLogin
Values(56,'NV13','Logout','2019/8/26', '14:01:25')
Insert into LichSuLogin
Values(57,'NV09','Login','2019/8/26', '14:05:07')
Insert into LichSuLogin
Values(58,'NV09','Logout','2019/8/26', '21:06:07')
Insert into LichSuLogin
Values(59,'NV04','Login','2019/8/27', '7:29:53')
Insert into LichSuLogin
Values(60,'NV04','Logout','2019/8/27', '14:01:25')
Insert into LichSuLogin
Values(61,'NV12','Login','2019/8/27', '14:05:07')
Insert into LichSuLogin
Values(62,'NV12','Logout','2019/8/27', '21:06:07')
Insert into LichSuLogin
Values(63,'NV10','Login','2019/8/28', '7:29:53')
Insert into LichSuLogin
Values(64,'NV10','Logout','2019/8/28', '14:01:25')
Insert into LichSuLogin
Values(65,'NV12','Login','2019/8/28', '14:05:07')
Insert into LichSuLogin
Values(66,'NV12','Logout','2019/8/28', '21:06:07')
Insert into LichSuLogin
Values(67,'NV11','Login','2019/8/29', '7:29:53')
Insert into LichSuLogin
Values(68,'NV11','Logout','2019/8/29', '14:01:25')
Insert into LichSuLogin
Values(69,'NV03','Login','2019/8/29', '14:05:07')
Insert into LichSuLogin
Values(70,'NV03','Logout','2019/8/29', '21:06:07')
Insert into LichSuLogin
Values(71,'NV02','Login','2019/8/30', '7:29:53')
Insert into LichSuLogin
Values(72,'NV02','Logout','2019/8/30', '14:01:25')
Insert into LichSuLogin
Values(73,'NV05','Login','2019/8/30', '14:05:07')
Insert into LichSuLogin
Values(74,'NV05','Logout','2019/8/30', '21:06:07')
Insert into LichSuLogin
Values(75,'NV07','Login','2019/8/31', '7:29:53')
Insert into LichSuLogin
Values(76,'NV07','Logout','2019/8/31', '14:01:25')
Insert into LichSuLogin
Values(77,'NV09','Login','2019/8/31', '14:05:07')
Insert into LichSuLogin
Values(78,'NV09','Logout','2019/8/31', '21:06:07')
Insert into LichSuLogin
Values(79,'NV12','Login','2019/9/1', '7:29:53')
Insert into LichSuLogin
Values(80,'NV12','Logout','2019/9/1', '14:01:25')
Insert into LichSuLogin
Values(81,'NV10','Login','2019/9/1', '14:05:07')
Insert into LichSuLogin
Values(82,'NV10','Logout','2019/9/1', '21:06:07')
Insert into LichSuLogin
Values(83,'NV08','Login','2019/9/2', '7:29:53')
Insert into LichSuLogin
Values(84,'NV08','Logout','2019/9/2', '14:01:25')
Insert into LichSuLogin
Values(85,'NV10','Login','2019/9/2', '14:05:07')
Insert into LichSuLogin
Values(86,'NV10','Logout','2019/9/2', '21:06:07')
Insert into LichSuLogin
Values(87,'NV03','Login','2019/9/3', '7:29:53')
Insert into LichSuLogin
Values(88,'NV03','Logout','2019/9/3', '14:01:25')
Insert into LichSuLogin
Values(89,'NV09','Login','2019/9/3', '14:05:07')
Insert into LichSuLogin
Values(90,'NV09','Logout','2019/9/3', '21:06:07')
Insert into LichSuLogin
Values(91,'NV07','Login','2019/9/4', '7:29:53')
Insert into LichSuLogin
Values(92,'NV07','Logout','2019/9/4', '14:01:25')
Insert into LichSuLogin
Values(93,'NV04','Login','2019/9/4', '14:05:07')
Insert into LichSuLogin
Values(94,'NV04','Logout','2019/9/4', '21:06:07')
Insert into LichSuLogin
Values(95,'NV11','Login','2019/9/5', '7:29:53')
Insert into LichSuLogin
Values(96,'NV11','Logout','2019/9/5', '14:01:25')
Insert into LichSuLogin
Values(97,'NV03','Login','2019/9/5', '14:05:07')
Insert into LichSuLogin
Values(98,'NV03','Logout','2019/9/5', '21:06:07')
Insert into LichSuLogin
Values(99,'NV13','Login','2019/9/6', '7:29:53')
Insert into LichSuLogin
Values(100,'NV13','Logout','2019/9/6', '14:01:25')
Insert into LichSuLogin
Values(101,'NV10','Login','2019/9/6', '14:05:07')
Insert into LichSuLogin
Values(102,'NV10','Logout','2019/9/6', '21:06:07')
Insert into LichSuLogin
Values(103,'NV07','Login','2019/9/7', '7:29:53')
Insert into LichSuLogin
Values(104,'NV07','Logout','2019/9/7', '14:01:25')
Insert into LichSuLogin
Values(105,'NV05','Login','2019/9/7', '14:05:07')
Insert into LichSuLogin
Values(106,'NV05','Logout','2019/9/7', '21:06:07')
Insert into LichSuLogin
Values(107,'NV04','Login','2019/9/8', '7:29:53')
Insert into LichSuLogin
Values(108,'NV04','Logout','2019/9/8', '14:01:25')
Insert into LichSuLogin
Values(109,'NV02','Login','2019/9/8', '14:05:07')
Insert into LichSuLogin
Values(110,'NV02','Logout','2019/9/8', '21:06:07')
Insert into LichSuLogin
Values(111,'NV12','Login','2019/9/9', '7:29:53')
Insert into LichSuLogin
Values(112,'NV12','Logout','2019/9/9', '14:01:25')
Insert into LichSuLogin
Values(113,'NV06','Login','2019/9/9', '14:05:07')
Insert into LichSuLogin
Values(114,'NV06','Logout','2019/9/9', '21:06:07')

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
Insert into HoaDon
Values('HD21', 'NV03', '2019/9/5 15:27:55')
Insert into HoaDon
Values('HD22', 'NV03', '2019/9/5 19:51:07')
Insert into HoaDon
Values('HD23', 'NV13', '2019/9/6 11:05:15')
Insert into HoaDon
Values('HD24', 'NV10', '2019/9/6 16:09:39')
Insert into HoaDon
Values('HD25', 'NV07', '2019/9/7 9:13:06')
Insert into HoaDon
Values('HD26', 'NV05', '2019/9/7 20:15:43')
Insert into HoaDon
Values('HD27', 'NV04', '2019/9/8 11:03:12')
Insert into HoaDon
Values('HD28', 'NV02', '2019/9/8 14:57:26')
Insert into HoaDon
Values('HD29', 'NV06', '2019/9/9 20:27:31')
Insert into HoaDon
Values('HD30', 'NV06', '2019/9/9 20:30:07')


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
Insert into DonHang
Values('HD7', 'G059', 1, 15)
Insert into DonHang
Values('HD7', 'G041', 1, 30)
Insert into DonHang
Values('HD7', 'G003', 1, 0)
Insert into DonHang
Values('HD7', 'G037', 2, 25)
Insert into DonHang
Values('HD7', 'G015', 1, 0)
Insert into DonHang
Values('HD8', 'G012', 1, 0)
Insert into DonHang
Values('HD8', 'G067', 3, 35)
Insert into DonHang
Values('HD9', 'G056', 2, 0)
Insert into DonHang
Values('HD10', 'G069', 1, 0)
Insert into DonHang
Values('HD10', 'G067', 1, 0)
Insert into DonHang
Values('HD10', 'G043', 1, 5)
Insert into DonHang
Values('HD11', 'G056', 2, 0)
Insert into DonHang
Values('HD11', 'G033', 1, 0)
Insert into DonHang
Values('HD11', 'G064', 1, 0)
Insert into DonHang
Values('HD11', 'G069', 1, 0)
Insert into DonHang
Values('HD12', 'G013', 3, 50)
Insert into DonHang
Values('HD12', 'G041', 1, 20)
Insert into DonHang
Values('HD12', 'G036', 2, 20)
Insert into DonHang
Values('HD12', 'G047', 1, 20)
Insert into DonHang
Values('HD10', 'G004', 1, 10)
Insert into DonHang
Values('HD12', 'G001', 1, 10)
Insert into DonHang
Values('HD13', 'G011', 1, 0)
Insert into DonHang
Values('HD14', 'G021', 1, 0)
Insert into DonHang
Values('HD15', 'G010', 1, 40)
Insert into DonHang
Values('HD16', 'G051', 1, 0)
Insert into DonHang
Values('HD16', 'G063', 1, 0)
Insert into DonHang
Values('HD16', 'G014', 2, 35)
Insert into DonHang
Values('HD17', 'G005', 1, 0)
Insert into DonHang
Values('HD17', 'G007', 1, 0)
Insert into DonHang
Values('HD18', 'G043', 1, 50)
Insert into DonHang
Values('HD19', 'G038', 1, 0)
Insert into DonHang
Values('HD19', 'G018', 1, 0)
Insert into DonHang
Values('HD19', 'G021', 1, 0)
Insert into DonHang
Values('HD19', 'G035', 1, 0)
Insert into DonHang
Values('HD19', 'G007', 1, 0)
Insert into DonHang
Values('HD20', 'G001', 1, 0)
Insert into DonHang
Values('HD20', 'G002', 1, 0)
Insert into DonHang
Values('HD21', 'G002', 1, 0)
Insert into DonHang
Values('HD21', 'G003', 1, 0)
Insert into DonHang
Values('HD21', 'G004', 1, 0)
Insert into DonHang
Values('HD22', 'G012', 1, 50)
Insert into DonHang
Values('HD22', 'G006', 1, 10)
Insert into DonHang
Values('HD23', 'G010', 3, 0)
Insert into DonHang
Values('HD23', 'G017', 1, 0)
Insert into DonHang
Values('HD23', 'G002', 4, 20)
Insert into DonHang
Values('HD23', 'G052', 1, 0)
Insert into DonHang
Values('HD24', 'G022', 1, 0)
Insert into DonHang
Values('HD24', 'G023', 4, 0)
Insert into DonHang
Values('HD24', 'G029', 1, 20)
Insert into DonHang
Values('HD24', 'G030', 1, 0)
Insert into DonHang
Values('HD25', 'G017', 2, 0)
Insert into DonHang
Values('HD25', 'G023', 1, 0)
Insert into DonHang
Values('HD25', 'G019', 1, 0)
Insert into DonHang
Values('HD26', 'G049', 5, 0)
Insert into DonHang
Values('HD26', 'G001', 1, 10)
Insert into DonHang
Values('HD26', 'G063', 2, 30)
Insert into DonHang
Values('HD26', 'G019', 2, 0)
Insert into DonHang
Values('HD27', 'G035', 1, 30)
Insert into DonHang
Values('HD27', 'G037', 1, 0)
Insert into DonHang
Values('HD27', 'G045', 1, 0)
Insert into DonHang
Values('HD27', 'G007', 2, 40)
Insert into DonHang
Values('HD28', 'G021', 1, 20)
Insert into DonHang
Values('HD29', 'G017', 1, 0)
Insert into DonHang
Values('HD30', 'G049', 2, 75)
