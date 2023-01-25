-- 14. Вывести все сведения о всех предметах из таблицы Subjects,
-- кроме предмета ‘высшая математика’ (условие по полю Name_subject).

USE RGR
GO

SELECT * FROM Subjects
WHERE Name_subject != 'высшая математика'