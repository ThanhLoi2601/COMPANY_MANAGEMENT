
create table HopDong (
    MaHD varchar(10) primary key,
    TenHD varchar(100),
    NgayKy Date,
    NgayCoHieuLuc Date,
    NgayHetHan Date,
    GiaTri int,
    NoiDung varchar(1500),
    MaNV varchar(10) foreign key references Staff(ID),
    MaKH varchar(10)  foreign key references Customer(MaKH),
    TrangThai varchar(50)
)

INSERT INTO HopDong (MaHD, TenHD, NgayKy, NgayCoHieuLuc, NgayHetHan, GiaTri, NoiDung, MaNV, MaKH)
VALUES ('HD001', 'Hợp đồng dịch vụ IT', '2022-01-01', '2022-01-10', '2023-01-01', 100000000, 'Cung cấp dịch vụ IT cho công ty ABC', 'EMP12345', 'KH001');
INSERT INTO HopDong (MaHD, TenHD, NgayKy, NgayCoHieuLuc, NgayHetHan, GiaTri, NoiDung, MaNV, MaKH)
VALUES ('HD002', 'Hợp đồng cung cấp vật tư', '2022-02-01', '2022-02-05', '2023-02-01', 50000000, 'Cung cấp vật tư cho công trình X', 'EMP12345', 'KH002');

--CREATE TRIGGER tr_HopDong_CapNhatTrangThai
--ON HopDong
--AFTER INSERT, UPDATE
--AS
--BEGIN
--  SET NOCOUNT ON;

--  UPDATE HopDong
--  SET TrangThai = 
--      CASE 
--          WHEN NgayHetHan > NgayCoHieuLuc THEN 'Da het han'
--          ELSE 'Dang co hieu luc'
--      END
--  FROM HopDong
--  INNER JOIN inserted ON HopDong.MaHD = inserted.MaHD;

--END;