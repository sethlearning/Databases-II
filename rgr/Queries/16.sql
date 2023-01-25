-- 16. Вывести список преподавателей (поле Name_lector) из таблицы Lectors и их должности (поле Post),
-- которые были устроены на работу в период с 12.03.2000 по 15.06.2000 (условие по полю Date_).

USE RGR
GO

SELECT Name_lector, Post FROM Lectors
WHERE Date_ BETWEEN '01/01/2000' AND '02/02/2001'