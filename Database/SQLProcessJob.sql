CREATE TABLE ProcessJob(
	IDJob varchar(10),
	Content varchar(500),
	Process float
)

INSERT INTO ProcessJob(IDJob,Content,Process) VALUES ('JOB2345','Ve so do thiet ke',0)
INSERT INTO ProcessJob(IDJob,Content,Process) VALUES ('JOB2346','Ve so do',0)
INSERT INTO ProcessJob(IDJob,Content,Process) VALUES ('JOB2347','Ve so do thiet ke may',0)
SELECT * FROM ProcessJob WHERE IDJob = 'JOB2344';