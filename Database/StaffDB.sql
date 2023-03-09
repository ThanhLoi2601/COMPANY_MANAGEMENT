CREATE TABLE Staff (
	ID varchar(10),
	Name  varchar(100),
	Birth date,
	ID_Card varchar(50),
	Email varchar(100),
	PhoneNumber varchar(10),
	Address varchar(255),
	Manager_ID varchar(10),
	Basic_salary int,
	KPI float,
	Password varchar(20)
);

INSERT Staff(ID,Name,Birth,ID_Card,Email,PhoneNumber,Address,Manager_ID,Basic_salary,KPI,Password) values ('EMP12345','Nguyen Van A','9/8/1999','1238192992','nva@gmail.com','0123456789','TPHCM','MAN12345',50000,'0.8','12345678')
INSERT Staff(ID,Name,Birth,ID_Card,Email,PhoneNumber,Address,Manager_ID,Basic_salary,KPI,Password) values ('EMP12346','Nguyen Van B','10/8/1998','1238192993','nvb@gmail.com','0123456782','TPHCM','MAN12346',50000,'1.1','12345678')
INSERT Staff(ID,Name,Birth,ID_Card,Email,PhoneNumber,Address,Manager_ID,Basic_salary,KPI,Password) values ('EMP12347','Nguyen Van C','9/9/1997','1238192994','nvc@gmail.com','0123456723','TPHCM','MAN12347',50000,'1.3','12345678')
INSERT Staff(ID,Name,Birth,ID_Card,Email,PhoneNumber,Address,Manager_ID,Basic_salary,KPI,Password) values ('EMP12348','Nguyen Van D','9/10/1996','1238192995','nvd@gmail.com','0123456764','TPHCM','MAN12348',50000,'0.9','12345678')
INSERT Staff(ID,Name,Birth,ID_Card,Email,PhoneNumber,Address,Manager_ID,Basic_salary,KPI,Password) values ('EMP12349','Nguyen Van E','11/8/1995','1238192996','nve@gmail.com','0123456777','TPHCM','MAN12349',50000,'1.2','12345678')

Select* from Staff