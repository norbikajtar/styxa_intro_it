USE [Exams]

ALTER TABLE Students
	ADD FOREIGN KEY (Group_Id) REFERENCES Groups(Gr_Id);

ALTER TABLE Marks
	ADD FOREIGN KEY (Student_Id) REFERENCES Students(Stud_Id);

ALTER TABLE Marks
	ADD FOREIGN KEY (Teacher_Id) REFERENCES Teachers(Teacher_Id);

ALTER TABLE Marks
	ADD FOREIGN KEY (Disc_Id) REFERENCES Disciplines(Discipline_Id);