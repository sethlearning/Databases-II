-- 31. Вывести список названий дисциплин (поле Name_subject из таблицы Subjects)
-- и имен преподавателей (поле Name_lector из таблицы Lectors),
-- которые принимали по этим дисциплинам экзамены в период с 15.01.2003 по 16.02.2003 (условие по полю Date_exam из таблицы Progress).

USE RGR
GO

SELECT DISTINCT S.Name_subject, L.Name_lector
FROM Subjects AS S, Progress AS P, Lectors AS L
WHERE P.Code_subject = S.Code_subject
AND P.Code_lector = L.Code_lector
AND P.Date_exam BETWEEN '12/29/2022' AND '12/30/2022'