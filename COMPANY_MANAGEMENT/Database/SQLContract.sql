
create table HopDong (
    MaHD varchar(10) ,
    TenHD nvarchar(100),
    NgayKy Date,
    NgayCoHieuLuc Date,
    NgayHetHan Date,
    GiaTri int,
    NoiDung nvarchar(1500),
    MaNV varchar(10),
    MaKH varchar(10)
)

INSERT INTO HopDong (MaHD, TenHD, NgayKy, NgayCoHieuLuc, NgayHetHan, GiaTri, NoiDung, MaNV, MaKH)
VALUES ('HD001', 'Hop dong dich vu IT', '2022-01-01', '2022-01-10', '2023-01-01', 100000000, 'Cung cap dich vu IT cho cong ty ABC', 'EMP12345', 'KH001');
INSERT INTO HopDong (MaHD, TenHD, NgayKy, NgayCoHieuLuc, NgayHetHan, GiaTri, NoiDung, MaNV, MaKH)
VALUES ('HD002', 'Hop dong cung cap vat tu', '2022-02-01', '2022-02-05', '2023-02-01', 50000000, 'Cung cap vat tu cho cong trinh X', 'EMP12345', 'KH002');

--CREATE TRIGGER tr_HopDong_CapNhatTrangThai
--ON HopDong
--AFTER INSERT, UPDATE
--AS
--BEGIN
--  SET NOCOUNT ON;

--  UPDATE HopDong
--  SET TrangThai = 
--      CASE 
--          WHEN NgayHetHan < GETDATE() THEN 'Da het han'
--          ELSE 'Dang co hieu luc'
--      END
--  FROM HopDong
--  INNER JOIN inserted ON HopDong.MaHD = inserted.MaHD;

--END;