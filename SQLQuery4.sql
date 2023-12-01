USE [WinFormDb]

CREATE TABLE Employee(
	EmployeeID int primary key IDENTITY(1,1) NOT NULL,
	FirstName nvarchar(50) NULL,
	LastName nvarchar(50) NULL,
	MobileNo nvarchar(15) NULL,
	JobTitle nvarchar(100) NULL,
	Salary decimal(10, 2) NULL 
)

CREATE TABLE JobTitle (
    JobTitleID int primary key IDENTITY(1,1) NOT NULL,
    Title nvarchar(100) NULL
)

INSERT INTO JobTitle (Title)
VALUES 
    ('Manager'),
    ('Developer'),
    ('Analyst'),
    ('UI/UX Designer'),
    ('HR Manager'),
    ('Finance Manager'),
    ('Tester')

	ALTER TABLE Employee
ADD JobTitleID int NULL REFERENCES JobTitle(JobTitleID)
ALTER TABLE Employee
DROP COLUMN JobTitle
UPDATE Employee
SET JobTitleID = (SELECT JobTitleID FROM JobTitle WHERE Title = Employee.JobTitle)

select * from Employee
select * from JobTitle
