-- 59. Изменить в таблице Subjects значение поля Name_subject на ‘математический анализ’, если название дисциплины – ‘высшая математика’.


USE RGR
GO

UPDATE Subjects
SET Name_subject = 'Высшая математика'
WHERE Name_subject = 'Математика'

SELECT * FROM Subjects