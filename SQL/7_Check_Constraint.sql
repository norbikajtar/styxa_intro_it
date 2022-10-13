USE [Exams]

ALTER TABLE Students
	CHECK CONSTRAINT FK__Students__Group___31EC6D26; --check exact name in the DB

ALTER TABLE Marks
	CHECK CONSTRAINT FK__Students__Group___31EC6D26; --check exact name in the DB

ALTER TABLE Marks
	CHECK CONSTRAINT FK__Students__Group___31EC6D26; --check exact name in the DB

ALTER TABLE Marks
	CHECK CONSTRAINT FK__Students__Group___31EC6D26; --check exact name in the DB