-- 22. Вывести список дисциплин (поле Name_subject) из таблицы Subjects, которые начинаются на букву ‘М’.

USE RGR
GO

SELECT Name_subject FROM Subjects
WHERE Name_subject LIKE 'М%'