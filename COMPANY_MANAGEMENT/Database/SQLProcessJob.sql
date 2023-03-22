CREATE TABLE ProcessJob(
	IDJob varchar(10),
	Content varchar(500),
	Process float
)

INSERT INTO ProcessJob(IDJob,Conent,Process) VALUES ('JOB2345','Ve so do thiet ke',15/100)
INSERT INTO ProcessJob(IDJob,Conent,Process) VALUES ('JOB2346','Ve so do',20/100)
INSERT INTO ProcessJob(IDJob,Conent,Process) VALUES ('JOB2347','Ve so do thiet ke may',30/100)
SELECT * FROM ProcessJob WHERE IDJob = 'JOB2344';