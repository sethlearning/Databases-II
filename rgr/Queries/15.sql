-- 15. Вывести даты экзаменов (поле Date_exam) из таблицы Progress
-- и список дисциплин (поле Name_subject) из таблицы Subjects,
-- по которым сдавали экзамены в период с 01.01.2003 по 01.02.2003 (условие по полю Date_exam).

USE RGR
GO

SELECT P.Date_exam, S.Name_subject
FROM Progress AS P, Subjects AS S
WHERE P.Code_subject = S.Code_subject
AND P.Date_exam BETWEEN '12/29/2022' AND '12/30/2022'