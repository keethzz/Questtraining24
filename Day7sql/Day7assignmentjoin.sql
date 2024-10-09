SELECT Studentbasic.fname,subject.name,marks.mark,exam.max_mark 
FROM STUDENTbasic
INNER JOIN subject
ON STUDENTbasic.id=SUBJECT.id inner join marks on marks.id = SUBJECT.id inner join exam on EXAM.id=SUBJECT.id;

SELECT  subject.name AS subject_name, studentbasic.fname AS student_name, marks.mark
FROM marks
INNER JOIN subject ON marks.subject_id = subject.id
INNER JOIN STUDENTbasic ON marks.student_id = STUDENTbasic.id;
select STUDENTbasic.id as studentid, exam.id as examid
from STUDENTbasic
inner join marks on marks.student_id= STUDENTbasic.id 
inner join EXAM on marks.exam_id = exam.id;

