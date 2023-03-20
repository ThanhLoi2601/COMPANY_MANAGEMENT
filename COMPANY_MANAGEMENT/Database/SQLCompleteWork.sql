CREATE TABLE CompleteWork(
	IDUser varchar(10),
	IDJob varchar(10),
	KPI int
)

SELECT SUM(KPI) FROM CompleteWork WHERE IDUser = 'MAN12345'
