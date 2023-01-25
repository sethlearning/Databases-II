-- 7. Вывести даты экзаменов (поле Date_exam) из таблицы Progress
-- и фамилии, имена, отчества преподавателей (поле Name_lector) из таблицы Lectors, принимавших в эти даты экзамены.

USE RGR
GO

SELECT DISTINCT P.Date_exam, L.Name_lector
FROM Progress AS P, Lectors AS L
WHERE P.Code_lector = L.Code_lector