-- 9. Вывести список преподавателей (поле Name_lector) из таблицы Lectors с ученой степенью кандидат каких-либо наук,
-- т.е. у которых значение поля Science начинается с ‘к’.

USE RGR
GO

SELECT Name_lector FROM Lectors
WHERE Science LIKE 'к%'