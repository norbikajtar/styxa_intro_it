SELECT Students.Name, Students.Surname, Students.Group_Id
  FROM Students
  WHERE Students.Group_Id = 3;

SELECT Students.Name, Students.Surname,Students.Date_of_Birth, Students.Group_Id
  FROM Students
  WHERE Students.Name LIKE 'A%';

  SELECT Students.Name, Students.Surname, Students.Group_Id
  FROM Students INNER JOIN Marks ON (Students.Stud_Id=Marks.Student_Id)
  INNER JOIN Teachers ON (Marks.Teacher_Id=Teachers.Teacher_Id)
  WHERE Teachers.Name='Adrian';


  SELECT s1.name ,m1.Mark, s1.surname, s1.Group_Id FROM 
  Students as  s1
  JOIN Marks AS m1 ON (s1.Stud_Id=m1.Student_Id)
  JOIN Disciplines AS d1 ON (d1.Discipline_Id= m1.Disc_Id)
  WHERE d1.Disc_name='History' AND m1.Mark > (SELECT TOP 1 m2.mark FROM marks AS m2
  JOIN Disciplines AS d2 ON 
  (d2.Discipline_Id= m2.Disc_Id)
  WHERE Name ='Barbara' AND d2.Disc_name='History')

  SELECT TOP 3 s.Name, s.Surname, s.Group_Id
  FROM Students s
  JOIN Marks m ON m.Student_Id = s.Stud_Id
  JOIN Disciplines d ON m.Disc_Id = d.Discipline_Id
  WHERE d.Disc_name = 'Computer Programming'
  ORDER BY Mark

  SELECT s.Name, s.Surname, AVG(m.Mark) AverageMark
  FROM Students s
  JOIN Marks m ON m.Student_Id = s.Stud_Id
  JOIN Groups g ON s.Group_Id = g.Gr_Id
  WHERE g.Gr_name = 'vestibulum'
  Group By s.Name, s.Surname

  SELECT g.Gr_name, g.Comments, COUNT(s.Stud_Id) StudentCount
  FROM Groups g
  JOIN Students s ON s.Group_Id = g.Gr_Id
  Group By g.Gr_name, g.Comments

