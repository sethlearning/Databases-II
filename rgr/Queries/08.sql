-- 8. Вывести даты экзаменов (поле Date_exam) из таблицы Progress и названия дисциплин (поле Name_subject) из таблицы Subjects,
-- по которым сдавали экзамены в указанные даты.

USE RGR
GO

SELECT DISTINCT P.Date_exam, S.Name_subject
FROM Progress AS P, Subjects AS S
WHERE P.Code_subject = S.Code_subject