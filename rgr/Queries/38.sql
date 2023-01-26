-- 38. Вывести все сведения о преподавателях (все поля таблицы Lectors)
-- с максимальным общим стажем работы (использовать поле Date_).


USE RGR
GO

SELECT *
FROM Lectors
WHERE Date_ = (SELECT MIN(Date_) FROM Lectors)