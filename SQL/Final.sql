create database DoAnRapChieuPhim03
go
use DoAnRapChieuPhim03

go
create table PHONGBAN
(
MaPB char(4) not null, --PB..
TenPB nvarchar(20) not null,
constraint PK_PHONGBAN primary key(MaPB)
);
go
create table NHANVIEN
(
MaNV char(12) not null, --NV..
TenNV nvarchar(50) not null, 
MaPB char(4) not null,
GioiTinh bit not null,
NamSinh datetime not null,
DiaChi nvarchar(50) not null,
SDT char(12) not null,
constraint PK_NHANVIEN primary key(MaNV),
constraint FK_NHANVIEN_PHONGBAN foreign key(MaPB) references PHONGBAN(MaPB)
);

go 
create table PHIM
(
MaPhim char(4) not null, --P***
TenPhim nvarchar(50) not null,
ThoiLuong int not null
constraint PK_PHIM primary key(MaPhim)
);


go
create table DOAN
(
MaDoAn char(4) not null, --DA**
TenMon nvarchar(20) not null, 
Gia int not null,
constraint PK_COMBO primary key(MaDoAn)
);

go
create table PHONGCHIEU
(
MaPC char(4) not null, --PC00
SucChua int not null,
TrangThai bit not null,
constraint PK_PHONGCHIEU primary key(MaPC),
);

go
create table GHE
(
MaGhe char(7) not null, --G001122 (00= Phòng, 11 = Hàng, 22 = Dãy)
LoaiGhe bit not null,
MaPC char(4) not null,
TrangThai bit not null,
constraint PK_GHE primary key(MaGhe),
constraint FK_GHE_PHONGCHIEU foreign key(MaPC) references PHONGCHIEU(MaPC)
);

go
create table LICHCHIEU
(
MaLC char(12) not null,
MaPhim char(4) not null,
MaPC char(4) not null,
NgayKhoiChieu DateTime not null,
SoTien int not null,
constraint PK_LICHCHIEU primary key(MaLC),
constraint FK_LICHCHIEU_PHIM foreign key(MaPhim) references PHIM(MaPhim),
constraint FK_LICHCHIEU_PHONGCHIEU foreign key(MaPC) references PHONGCHIEU(MaPC)
)
go
create table KHACHHANG
(
MaKH char(12) not null, --KH**
TenKH nvarchar(20) not null, 
GioiTinh bit not null,
NamSinh Date not null,
LoaiKH bit not null,
Diem int not null,
constraint PK_KHACHHANG primary key(MaKH)
);
go
create table VE
(
MaVe char(12) not null, --VE***
MaNV char(12),
MaKH char(12) not null,
MaLC char(12) not null,
MaDoAn char(4),
MaGhe char(7) not null,
NgayDatVe Date not null,
GiaVe int not null,
constraint PK_VE primary key(MaVe),
constraint FK_VE_NHANVIEN foreign key(MaNV) references NHANVIEN(MaNV),
constraint FK_VE_KHACHHANG foreign key(MaKH) references KHACHHANG(MaKH),
constraint FK_VE_GHE foreign key(MaGhe) references GHE(MaGhe),
constraint FK_VE_DOAN foreign key(MaDoAn) references DOAN(MaDoAn),
constraint FK_VE_LICHCHIEU foreign key(MaLC) references LICHCHIEU(MaLC)
);
GO



----------  NHANVIEN  ---------------------
------------Thêm Nhân Viên-----------------
CREATE PROCEDURE nhanvien_insert
(
@MaNV Char(12),
@TenNV nvarchar(50),
@MaPB char(4),
@GioiTinh bit,
@NamSinh datetime,
@DiaChi nvarchar(50),
@SDT char(12)
)
AS
BEGIN
	INSERT INTO NHANVIEN
           (
		   [MaNV], 
		   [TenNV], 
		   [MaPB], 
		   [GioiTinh], 
		   [NamSinh], 
		   [DiaChi], 
		   [SDT]
		   )
     VALUES
           (
		    @MaNV,
			@TenNV,
			@MaPB,
			@GioiTinh,
			@NamSinh,
			@DiaChi,
			@SDT
		   )
END

GO
------------Cập Nhật Nhân Viên-----------------
CREATE PROCEDURE nhanvien_updates
(
@MaNV char(12),
@TenNV nvarchar(18),
@MaPB char(4),
@GioiTinh bit,
@NamSinh datetime,
@DiaChi nvarchar(50),
@SDT char(12)
)
AS
BEGIN
	UPDATE NHANVIEN
    SET 
	[TenNV] = @TenNV,
	[MaPB] = @MaPB,
	[GioiTinh] = @GioiTinh,
	[NamSinh] = @NamSinh,
	[DiaChi] = @DiaChi,
	[SDT] = @SDT
    WHERE MaNV = @MaNV
END

GO
------------Xóa Nhân Viên-----------------
CREATE PROCEDURE nhanvien_delete
(
@MaNV Char(12)
)
AS
BEGIN
	DELETE FROM NHANVIEN
      WHERE MaNV = @MaNV
END


GO
-----------------------------TRIGGER XÓA NHÂN VIÊN NULL VÉ---------------

GO
CREATE TRIGGER Trigger_delete_nhanvien_trong_ve ON NHANVIEN
AFTER DELETE
AS 
declare @del char(12)
SELECT @del = ol.MaNV
FROM deleted ol
BEGIN
    UPDATE VE
	SET	[MaNV] = NULL
	WHERE [MaNV] = @del
END
go
-------------------------------Hàm-------------------------
go
CREATE FUNCTION timkiemnhanvien_TenPhongBang(@MaPB char(4))
RETURNS TABLE
AS
RETURN
(
SELECT *
FROM NHANVIEN
WHERE MaPB = @MaPB
)
go















----------  PHONGBAN  ---------------------
------------Thêm Phòng Ban-----------------
CREATE PROCEDURE phongban_insert
(
@MaPB Char(4),
@TenPhongBan nvarchar(20)
)
AS
BEGIN
	INSERT INTO PHONGBAN
           (
		   [MaPB],
		   [TenPB]
		   )
     VALUES
           (
		   @MaPB,
		   @TenPhongBan
		   )
END

GO
------------Cập Nhật Phòng Ban-----------------
CREATE PROCEDURE phongban_updates
(
@MaPB Char(4),
@TenPhongBan nvarchar(20)
)
AS
BEGIN
	UPDATE PHONGBAN
    SET 
		[MaPB] = @MaPB,
		[TenPB] = @TenPhongBan
    WHERE [MaPB] = @MaPB
END

GO
------------Xóa Phòng Ban-----------------
CREATE PROCEDURE phongban_delete
(
@MaPB Char(4)
)
AS
BEGIN
	DELETE FROM PHONGBAN
      WHERE MaPB = @MaPB
END

GO
----------------Trigger--------------------------------------
----------------Xoa phong ban khi k con nhan vien nao------------------
GO
CREATE TRIGGER Trigger_delete_phongban_trong_nhanvien ON PHONGBAN
INSTEAD OF DELETE
AS 
declare @del int,
		@SLNV int = 0
	SELECT @del = ol.MaPB
	FROM deleted ol, NHANVIEN
	WHERE NHANVIEN.MaPB != @del

	SELECT @SLNV = count([MaNV]) FROM NHANVIEN
	WHERE [MaPB] = @del
BEGIN
	if(@SLNV = 0)
		DELETE FROM PHONGBAN
		WHERE [MaPB] = @del
END
go
















----------  GHẾ  ---------------------
------------Thêm Ghế-----------------
CREATE PROCEDURE ghe_insert
(
@MaGhe Char(7),
@LoaiGhe bit,
@MaPC char(4),
@TrangThai bit
)
AS
BEGIN
	INSERT INTO GHE
           ([MaGhe]
           ,[LoaiGhe],
		   [MaPC], [TrangThai])
     VALUES
           (
		   @MaGhe,
		   @LoaiGhe,
		   @MaPC,
		   @TrangThai
		   )
END
GO
------------Cập Nhật Ghế-----------------
CREATE PROCEDURE ghe_updates
(
@MaGhe Char(7),
@LoaiGhe bit,
@MaPC char(4),
@TrangThai bit
)
AS
BEGIN
	UPDATE GHE
    SET [LoaiGhe] = @LoaiGhe,
		[MaPC] = @MaPC,
		[TrangThai] = @TrangThai
    WHERE MaGhe = @MaGhe
END
GO
------------Xóa Ghế-----------------
CREATE PROCEDURE ghe_delete
(
@MaGhe char(7)
)
AS
BEGIN
	DELETE FROM GHE
      WHERE MaGhe = @MaGhe 
END
GO
-----------------------Ham--------------
-------------------Ham lay ghe trong cua phong chieu-----------
go
Create function GetGheTrong(@MaPC char(4)) returns table
as return SELECT * FROM GHE
			WHERE [MaPC] = @MaPC AND [TrangThai] = 0
go
















------------   PHÒNG CHIÊU  -----------------
------------Thêm Phòng Chiếu-----------------
CREATE PROCEDURE phongchieu_insert
	(
	@MaPhongChieu char(4),
	@SucChua int,
	@TrangThai bit
	)
AS
BEGIN
	INSERT INTO PHONGCHIEU
           ([MaPC],[SucChua],[TrangThai])
     VALUES
           (
		   @MaPhongChieu,
		   @SucChua,
		   @TrangThai
		   )
END
GO
------------Cập Nhật Phòng Chiếu-----------------
CREATE PROCEDURE phongchieu_update
	(
	@MaPhongChieu char(4),
	@SucChua int,
	@TrangThai bit
	)
AS
BEGIN
	UPDATE PHONGCHIEU
    SET    [MaPC] = @MaPhongChieu
           ,[SucChua] = @SucChua
           ,[TrangThai] = @TrangThai
    WHERE [MaPC] = @MaPhongChieu
END
GO
------------Xóa Phòng Chiếu-----------------
CREATE PROCEDURE phongchieu_delete
	(
	@MaPhongChieu char(4)
	)
AS
BEGIN
	DELETE FROM PHONGCHIEU
      WHERE [MaPC] = @MaPhongChieu
END
GO
----------------------Trigger--------------------
--------------------Add ghe moi khi add phong chieu--------
go
Create Trigger Add_ghe_PHONGCHIEU ON PHONGCHIEU after INSERT
AS
	DECLARE @SoLuong int = 10,
			@Count int = 0,
			@MaPC char(4)
	Select @MaPC = inserted.MaPC FROM inserted
BEGIN
	while(@Count < @SoLuong)
	begin
		if(@Count > 4)
			INSERT INTO GHE([MaGhe],[LoaiGhe],[MaPC],[TrangThai]) VALUES ('G'+ @MaPC + CONVERT(char(4), @Count),1,@MaPC,0);
		else
			INSERT INTO GHE([MaGhe],[LoaiGhe],[MaPC],[TrangThai]) VALUES ('G'+ @MaPC + CONVERT(char(4), @Count),0,@MaPC,0);
		SET @Count = @Count + 1;
		print @Count
	end
END


go
--------------------Xoa ghe cua PC moi khi xoa phong chieu--------
go
Create Trigger Del_ghe_PHONGCHIEU 
	ON PHONGCHIEU
	INSTEAD OF DELETE
AS
	DECLARE @MaPC char(4)
	Select @MaPC = deleted.MaPC FROM deleted
BEGIN
	DELETE FROM GHE
	WHERE [MaPC] = @MaPC

	DELETE FROM PHONGCHIEU
	WHERE [MaPC] = @MaPC
END
go















------------  PHIM  ------------------
------------Thêm Phim-----------------
CREATE PROCEDURE phim_insert
	(
	@MaPhim char (4),
	@TenPhim nvarchar(50),
	@ThoiLuong int
	)
AS
BEGIN
	INSERT INTO PHIM
           ([MaPhim]
           ,[TenPhim]
           ,[ThoiLuong])
     VALUES
           (
		   @MaPhim,
		   @TenPhim,
		   @ThoiLuong
		   )
END
GO
------------Cập Nhật Phim-----------------
CREATE PROCEDURE phim_update
	(
	@MaPhim char (4),
	@TenPhim nvarchar(50),
	@ThoiLuong int
	)
AS
BEGIN
	UPDATE PHIM
    SET    [MaPhim] = @MaPhim
           ,[TenPhim] = @TenPhim
           ,[ThoiLuong] = @ThoiLuong
    WHERE MaPhim = @MaPhim
END
GO
----------------Xóa Phim-----------------
CREATE PROCEDURE phim_delete
	(
	@MaPhim char(4)
	)
AS
BEGIN
	DELETE FROM PHIM
      WHERE [MaPhim] = @MaPhim
END
GO
---------------Hàm----------------
-------------Tìm theo mã----------
create function FindWithMaPhim(@MaPhim char(4)) returns table
as return SELECT * FROM PHIM
			WHERE [MaPhim] = @MaPhim
go 
------------Tìm theo thời lượng-----------------
create function FindWithThoiLuong(@max int, @min int) returns table
as return SELECT * FROM PHIM
			WHERE [ThoiLuong] BETWEEN @min AND @max
go
---------------Tìm theo tên phim-------------------
create function FindWithTenPhim(@TenPhim char(20)) returns table
as return SELECT * FROM PHIM
			WHERE [TenPhim] LIKE '%'+@TenPhim+'%'
go







------------Do an--------------------
-----------Thêm-----------------
Create PROC doan_insert
	(
	@MaDA char(4),
	@TenMon char(20),
	@Gia int
	)
As
Begin
	INSERT INTO DOAN(
		[MaDoAn],
		[TenMon],
		[Gia]
		)
	VALUES 
		(
		@MaDA,
		@TenMon,
		@Gia
		)
End
Go
---------------Update------------------
Create PROC doan_update
	(
	@MaDA char(4),
	@TenMon char(20),
	@Gia int
	)
As
Begin
	UPDATE DOAN
	SET 
		[TenMon] = @TenMon,
		[Gia] = @Gia
	WHERE
		[MaDoAn] = @MaDA
End

go
--------------Xoa-------------------
Create PROC doan_del
	(
	@MaDA char(4)
	)
As
Begin
	DELETE FROM DOAN
	WHERE [MaDoAn] = @MaDA

End
go
----------------Hàm tìm kiếm--------------
go
create function AllDoAn() returns table
as return select * from DOAN

go
create function find_MaDA(@MaDA char(6)) returns table ----Tìm theo mã đồ ăn
as return select * from DOAN where [MaDoAn] = @MaDA
go
create function find_SoTien(@Max int, @Min int) returns table ---Tìm theo khoảng tiền
as return select * from DOAN where [Gia] >= @Min AND [Gia] <= @Max
go








-----------------KHACHHANG-----------------
----------------Thêm---------------------
Create PROC khachhang_insert
	(
	@MaKH char(12),
	@TenKH nvarchar(20),
	@GioiTinh bit,
	@NamSinh date,
	@LoaiKH bit,
	@Diem int
	)
as
begin
	INSERT INTO KHACHHANG([MaKH], [TenKH], [GioiTinh], [NamSinh], [LoaiKH], [Diem])
	VALUES (@MaKH, @TenKH, @GioiTinh, @NamSinh, @LoaiKH, @Diem)
end
go
----------------Sửa-------------------------
Create PROC khachhang_update
	(
	@MaKH char(12),
	@TenKH nvarchar(20),
	@GioiTinh bit,
	@NamSinh date,
	@LoaiKH bit,
	@Diem int
	)
as
begin
	UPDATE KHACHHANG
	SET	[TenKH] = @TenKH, [GioiTinh] = @GioiTinh, [NamSinh] = @NamSinh, [LoaiKH] = @LoaiKH, [Diem] = @Diem
	WHERE [MaKH] = @MaKH
end
go
---------------Xóa----------------------------
Create PROC khachhang_del
	(
	@MaKH char(12)
	)
as
begin
	DELETE FROM KHACHHANG
	WHERE [MaKH] = @MaKH
end
go
-----------------Trigger----------------------
-- Xóa Khách Hàng sẽ xóa vé của họ
GO
CREATE TRIGGER Trig_XoaKhachHang ON KHACHHANG
AFTER DELETE
AS 
declare @del char(14)
SELECT @del = ol.MaKH
FROM deleted ol
BEGIN
    DELETE VE
	WHERE VE.MaKH = @del
END
go
--------Update điểm lên vip-------------
CREATE TRIGGER Trig_UpdateKhachHang ON KHACHHANG
AFTER UPDATE
AS 
declare @diem int,
		@makh char(12)
SELECT @diem = [Diem] FROM KHACHHANG
SELECT @makh = [MaKH] FROM KHACHHANG
BEGIN
    if(@diem >= 10)
	begin
		UPDATE KHACHHANG
		SET [LoaiKH] = 1
		WHERE [MaKH] = @makh
	end
END
go
------------------Hàm tìm kiếm-----------------
--toan bo kh--
go
create function AllKH() returns table
as return select * from KHACHHANG 

--theo ma khach hang--
go
create function findMKH(@MaKH char(12)) returns table
as return select * from KHACHHANG where [MaKH] = @MaKH

--tim theo ten--
go
create function findTKH(@TenKH nvarchar(20)) returns table
as return SELECT * FROM KHACHHANG Where KHACHHANG.TenKH LIKE @TenKH+'%'
go

--theo gioi tinh
go
create function findfemale(@GioiTinh bit) returns table
as	 return select * from KHACHHANG Where [GioiTinh] = @GioiTinh 
go
--tim kh vip
go
create function findVip(@LoaiKH bit) returns table
as	 return select * from KHACHHANG Where [LoaiKH] = @LoaiKH
go






------------------LICHCHIEU--------------------
------------------Thêm----------------------
Create PROC lichchieu_insert
	(
	@MaLC char(12),
	@MaPC char(4),
	@MaPhim char(4),
	@NgayChieu date,
	@SoTien int
	)
as
begin
	INSERT INTO LICHCHIEU([MaLC], [MaPC], [MaPhim], [NgayKhoiChieu], [SoTien])
	VALUES (@MaLC, @MaPC, @MaPhim, @NgayChieu, @SoTien)
end
go
--------------------Sửa----------------------
Create PROC lichchieu_update
	(
	@MaLC char(12),
	@MaPC char(4),
	@MaPhim char(4),
	@NgayChieu date,
	@SoTien int
	)
as
begin
	UPDATE LICHCHIEU
	SET [MaPC] = @MaPC, [MaPhim] = @MaPhim, [NgayKhoiChieu] = @NgayChieu, [SoTien] = @SoTien
	WHERE [MaLC] = @MaLC
end
go
-----------------Xóa-----------------------
Create PROC lichchieu_del
	(
	@MaLC char(12)
	)
as
begin
	DELETE FROM LICHCHIEU
	WHERE [MaLC] = @MaLC
end
go
-------------------Tìm với mã phim-------------
create function findWithMaPhim_LICHCHIEU(@MaPhim char(12)) returns table
as	 return select * from LICHCHIEU Where [MaPhim] = @MaPhim
go
-----------------Tìm với mã LC--------------
Create function findWithMaLC_LICHCHIEU(@MaLC char(12)) returns table
as return select * from LICHCHIEU Where [MaLC] = @MaLC
go
--------------------Trigger xóa lịch chiếu sẽ xóa vé------------------
create TRIGGER Trig_XoaLC ON LICHCHIEU
AFTER DELETE
AS 
	declare 
		@delMaLC char(12)
	SELECT @delMaLC = deleted.MaLC
	FROM deleted
BEGIN
    DELETE VE
	WHERE VE.MaLC = @delMaLC 
END
go










-----------------VE--------------------------
-----------------Thêm-----------------------
Create PROC ve_insert
	(
	@MaVe char(12),
	@MaNV char(12),
	@MaKH char(12),
	@MaLC char(12),
	@MaDoAn char(4),
	@MaGhe char(7),
	@NgayDatVe date,
	@GiaVe int
	)
as
begin
	INSERT INTO VE([MaVe], [MaNV], [MaKH], [MaLC],[MaDoAn], [MaGhe], [NgayDatVe], [GiaVe])
	VALUES			(@MaVe, @MaNV, @MaKH, @MaLC, @MaDoAn, @MaGhe, @NgayDatVe, @GiaVe)
end
go

go
-----------------Xóa-------------------------
Create PROC ve_del
	(
	@MaVe char(12)
	)
as
begin
	DELETE FROM VE
	WHERE [MaVe] = @MaVe
end
go
-------------------Sửa----------------------
Create PROC ve_update
	(
	@MaVe char(12),
	@MaNV char(12),
	@MaKH char(12),
	@MaLC char(12),
	@MaDoAn char(4),
	@MaGhe char(4),
	@NgayDatVe date,
	@GiaVe int
	)
as
begin
	UPDATE VE
	SET [MaNV] = @MaNV, [MaKH] = @MaKH, [MaLC] = @MaLC,[MaDoAn] = @MaDoAn, [MaGhe] = @MaGhe, [NgayDatVe] = @NgayDatVe, [GiaVe] = @GiaVe
	WHERE [MaVe] = @MaVe
end
go
-----------------hàm trên bảng vé--------------
-----------------Tìm theo mã vé------------------
create function findWithMaVe(@MaVe char(12)) returns table
as	 return select * from VE Where [MaVe] = @MaVe
go
-----------------Tìm theo tên phim-----------------


go
------------------TRIGGER--------------------------
-----------------ADD vé sẽ tính tiền vé và cộng điểm cho người đặt-----------------
Create trigger Add_ve_AddDiemVaTinhTien ON VE after INSERT
as
BEGIN
	Declare @MaVe char(12),
			@MaKH char(12),
			@LoaiKH bit,
			@GiaLC int,
			@GheVip bit,
			@GiaDoAn int,
			@GiaVe float = 0,
			@Diem int,
			@MaGhe char(7)
	SELECT @MaVe = inserted.MaVe FROM inserted
	SELECT @MaKH = inserted.MaKH FROM inserted
	SELECT @LoaiKH = KHACHHANG.LoaiKH FROM inserted INNER JOIN KHACHHANG ON inserted.MaKH = KHACHHANG.MaKH
	SELECT @GiaLC = LICHCHIEU.SoTien FROM inserted INNER JOIN LICHCHIEU ON inserted.MaLC = LICHCHIEU.MaLC
	SELECT @GheVip = GHE.LoaiGhe FROM inserted INNER JOIN GHE ON inserted.MaGhe = GHE.MaGhe
	SELECT @GiaDoAn = DOAN.Gia FROM inserted INNER JOIN DOAN ON inserted.MaDoAn = DOAN.MaDoAn
	SELECT @Diem = KHACHHANG.Diem FROM KHACHHANG WHERE [MaKH] = @MaKH
	SELECT @MaGhe = inserted.MaGhe FROM inserted
	
	BEGIN
		if(@GheVip = 1)
			SET @GiaVe = @GiaVe + @GiaLC * 0.95
		else
			SET @GiaVe = @GiaVe + @GiaLC
		if(@LoaiKH = 1)
			SET @GiaVe = @GiaVe + @GiaDoAn * 0.9;
		else
		SELECT @GiaVe = @GiaVe + @GiaDoAn

		UPDATE VE
		SET [GiaVe] = @GiaVe
		WHERE [MaVe] = @MaVe

		UPDATE KHACHHANG
		SET [Diem] = @Diem + 1
		WHERE [MaKH] = @MaKH

		UPDATE GHE
		SET [TrangThai] = 1
		WHERE [MaGhe] = @MaGhe
	END
	
END

go
----------------Trigger xóa vé trả chỗ-------------
Create trigger XoaVE_TraCho ON VE
INSTEAD OF DELETE
as
BEGIN
	DECLARE @MaGhe char(7),
			@MaVe char(12)
	SELECT @MaVe = deleted.MaVe FROM deleted
	BEGIN
		UPDATE GHE
		SET [TrangThai] = 0
		WHERE [MaGhe] = @MaGhe

		DELETE FROM VE
		WHERE [MaVe] = @MaVe
	END
END