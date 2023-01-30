-- 12. Вывести список преподавателей (поле Name_lector) из таблицы Lectors и их должности (поле Post),
-- которые не являются докторами технических наук, т.е. значение поля Science не равно ‘д.т.н.’.

USE RGR
GO

SELECT Name_lector, Post FROM Lectors
WHERE Science != 'д.т.н.'