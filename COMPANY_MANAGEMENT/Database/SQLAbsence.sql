CREATE TABLE Absence (
	ID varchar(10),
	Name varchar(100),
	Reason varchar(100),
	StartDate date,
	EndDate date
)
SELECT * FROM Absence WHERE  ID LIKE 'MAN%'