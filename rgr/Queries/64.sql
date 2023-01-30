-- 64. Удалить из таблицы Subjects все записи, в которых в поле
-- Name_subject нет данных или в поле содержится пустое значение.


USE RGR
GO

SELECT * FROM Subjects

DELETE FROM Subjects
WHERE Name_subject IS NULL
OR Name_subject = ''

SELECT * FROM Subjects
