create table Customer (
	MaKH varchar(10),
    Ten varchar(50),
    CCCD varchar(12),
    Email varchar(50),
    Sdt varchar(10),
    DiaChi varchar(100)
)
INSERT INTO Customer (MaKH, Ten, CCCD, Email, Sdt, DiaChi) 
VALUES ('KH001', 'Nguyễn Văn A', '123456789012', 'nguyenvana@gmail.com', '0912345678', '123 Đường ABC, Quận 1, TP.HCM'),
       ('KH002', 'Trần Thị B', '234567890123', 'tranthib@gmail.com', '0987654321', '456 Đường XYZ, Quận 2, TP.HCM'),
       ('KH003', 'Lê Văn C', '345678901234', 'levanc@gmail.com', '0909090909', '789 Đường KLM, Quận 3, TP.HCM'),
       ('KH004', 'Phạm Thị D', '456789012345', 'phamthid@gmail.com', '0123456789', '456 Đường HIJ, Quận 4, TP.HCM'),
       ('KH005', 'Đỗ Văn E', '567890123456', 'dovane@gmail.com', '0123456789', '789 Đường NOP, Quận 5, TP.HCM');
