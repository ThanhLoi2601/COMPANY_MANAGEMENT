CREATE TABLE Projects (
  ID VARCHAR(10) PRIMARY KEY,
  Project_Name VARCHAR(50) NOT NULL,
  StartDate DATE,
  EndDate DATE,
  Project_description TEXT,
  Project_status varchar(50) DEFAULT 'NotStarted'
);
CREATE TABLE Tasks (
  ID VARCHAR(10) PRIMARY KEY,
  Task_Name VARCHAR(50) NOT NULL,
  StartDate DATE,
  EndDate DATE,
  Task_description TEXT,
  Task_status varchar(50) DEFAULT 'NotStarted', 
  Project_ID VARCHAR(10),
  FOREIGN KEY (Project_ID) REFERENCES Projects(ID) ON DELETE CASCADE
);