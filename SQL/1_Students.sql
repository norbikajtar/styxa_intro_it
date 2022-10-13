USE [Exams]

CREATE TABLE Students (
	Stud_Id int,
	Name varchar(50),
	Surname varchar(50),
	Gender char(1),
	Date_of_Birth datetime,
	Group_Id int,
	PRIMARY KEY (Stud_Id)
);
