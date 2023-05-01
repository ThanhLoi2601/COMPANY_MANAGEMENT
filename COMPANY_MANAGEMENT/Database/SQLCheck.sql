CREATE TABLE SQLCheck (
  ID varchar(10),
  Name  varchar(100),
  DateCheck DATE,
  CheckIn BIT,
  CheckOut BIT,
  TimesLate int
)

ALTER TABLE SQLCheck
ADD TimeCheckIn DATETIME,
    TimeCheckOut DATETIME;