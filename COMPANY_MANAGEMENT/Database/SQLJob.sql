CREATE TABLE Job (
	ID varchar(10),
	Name  varchar(100),
	Content varchar(500),
	DateStart Date,
	DateEnd Date,
	Bonus int
);

INSERT INTO Job(ID,Name,Content,DateStart,DateEnd,Bonus) values ('JOB2345','DRAW','Ve so do thiet ke','3/1/2023','3/17/2023',10000);
INSERT INTO Job(ID,Name,Content,DateStart,DateEnd,Bonus) values ('JOB2346','DRAW','Ve so do','3/1/2023','3/27/2023',0);
INSERT INTO Job(ID,Name,Content,DateStart,DateEnd,Bonus) values ('JOB2347','DRAW','Ve so do thiet ke may','2/3/2023','2/13/2023',50000);
INSERT INTO Job(ID,Name,Content,DateStart,DateEnd,Bonus) values ('JOB2348','DRAW','Ve so do thiet ke code','3/1/2023','3/29/2023',0);
INSERT INTO Job(ID,Name,Content,DateStart,DateEnd,Bonus) values ('JOB2349','DRAW','Ve so do thiet ke do hoa','3/1/2023','3/12/2023',10000);
INSERT INTO Job(ID,Name,Content,DateStart,DateEnd,Bonus) values ('JOB2341','DRAW','Ve so do thiet ke game','3/10/2023','3/17/2023',20000);
INSERT INTO Job(ID,Name,Content,DateStart,DateEnd,Bonus) values ('JOB2342','DRAW','Ve so do thiet ke phan mem','3/21/2023','3/22/2023',100000);
INSERT INTO Job(ID,Name,Content,DateStart,DateEnd,Bonus) values ('JOB2343','DRAW','Ve so do thiet ke phan cung','4/1/2023','4/10/2023',30000);
INSERT INTO Job(ID,Name,Content,DateStart,DateEnd,Bonus) values ('JOB2344','DRAW','Ve so do thiet ke so do','3/16/2023','3/22/2023',50000);
INSERT INTO Job(ID,Name,Content,DateStart,DateEnd,Bonus) values ('JOM2344','DRAW','Ve so do thiet ke so do','2/16/2023','4/22/2023',150000);
INSERT INTO Job(ID,Name,Content,DateStart,DateEnd,Bonus) values ('JOM2345','DRAW','Ve so do thiet ke phan cung','2/16/2023','3/22/2023',100000);
SELECT *FROM Job WHERE ID like 'JOM%';
