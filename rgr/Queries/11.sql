-- 11. Вывести список дисциплин (поле Name_subject) из таблицы Subjects, значение которых начинается с ‘математ’.

USE RGR
GO

SELECT Name_subject FROM Subjects
WHERE Name_subject LIKE 'математ%'