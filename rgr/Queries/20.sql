-- 20. Вывести список преподавателей (поле Name_lector) из таблицы Lectors и их должности (поле Post),
-- у которых есть одна из следующих ученых степеней: ‘к.т.н.’, ‘к.э.н.’, ‘д.т.н.’ (условие по полю Science).

USE RGR
GO

SELECT Name_lector, Post
FROM Lectors
WHERE Science IN ('к.т.н.', 'д.т.н.')