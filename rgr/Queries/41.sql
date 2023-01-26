-- 41. Вывести список преподавателей (Name_lector), их ученые степени (поле Science)
-- и срок их работы в годах (использовать поле Date_ из таблицы Lectors), поместив резльтат в поле Old_years.


USE RGR
GO

SELECT Name_lector, Science, DATEDIFF(year, Date_, GETDATE()) AS Old_years
FROM Lectors