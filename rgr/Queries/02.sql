-- 2. Вывести список фамилий, имен, отчеств преподавателей (поле Name_lector), их должности (поле Post) и ученые степени (поле Science) из таблицы Lectors,
-- отсортировать результат по названиям должностей по возрастанию (использовать поле Post) и по ученым степеням по убыванию (использовать поле Science).

USE RGR
GO

SELECT Name_lector, Post, Science FROM Lectors
ORDER BY Post ASC, Science DESC