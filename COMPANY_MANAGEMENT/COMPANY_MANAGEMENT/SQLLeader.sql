CREATE TABLE Leader (
	ID varchar(10),
	Name  varchar(100),
	Birth date,
	ID_Card varchar(50),
	Email varchar(100),
	Address varchar(255),
	Basic_salary int,
	Password varchar(20)
);

INSERT Leader(ID,Name,Birth,ID_Card,Email,Address,Basic_salary,Password) values ('LD12345','Tran Van A','9/8/1999','0228192992','tva@gmail.com','TPHCM',150000,'12345678')
INSERT Leader(ID,Name,Birth,ID_Card,Email,Address,Basic_salary,Password) values ('LD12346','Tran Van B','10/8/1998','0228192993','tvb@gmail.com','TPHCM',150000,'12345678')
select * from tasks