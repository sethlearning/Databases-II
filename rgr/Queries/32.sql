-- 32. Вывести список всех преподавателей (Name_lector), их ученые степени (поле Science)
-- и срок их работы в годах (использовать поле Date_ из таблицы Lectors).

USE RGR
GO

SELECT Name_lector, Science, DATEDIFF(year, Date_, GETDATE()) AS 'Years'
FROM Lectors