-- 21. Вывести список студентов (поля Surname, Name, Lastname) из таблицы Students,
-- которые сдавали экзамены по дисциплинам со следующими кодами 5, 8, 12, 25 (условие по полю Code_subject).

USE RGR
GO

SELECT S.Lastname, S.Name, S.Middlename
FROM Students AS S, Progress AS P
WHERE S.Code_stud = P.Code_stud
AND P.Code_subject IN (1, 2)