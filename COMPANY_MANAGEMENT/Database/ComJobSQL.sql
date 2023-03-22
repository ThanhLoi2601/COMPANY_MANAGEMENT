CREATE TABLE CompleteJob (
	IDJob varchar(10),
	Content varchar(500),
	CompleDate Date
)

INSERT INTO CompleteJob(IDJob,Content,CompleDate) VALUES('JOB2346','Ve so do','2023-02-02')
SELECT * FROM CompleteJob