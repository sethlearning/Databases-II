-- 26. Вывести список преподавателей (поле Name_lector) из таблицы Lectors,
-- которые принимали экзамены по дисциплинам с кодами (условие по полю Code_subject из таблицы Progress) 5 – 12
-- и в период с 01.01.2003 по 01.02.2003 (условие по полю Date_exam из таблицы Progress).

USE RGR
GO

SELECT L.Name_lector
FROM Lectors AS L, Progress AS P
WHERE   L.Code_lector = P.Code_lector
    AND P.Code_subject BETWEEN 1 AND 2
    AND P.Date_exam BETWEEN '12/30/2022' AND '12/31/2022'