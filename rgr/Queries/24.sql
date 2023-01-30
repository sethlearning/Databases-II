-- 24. Выбрать список групп (поле Name_group) из таблицы Groups, у которых значение оканчивается на ‘0’ (ноль).

USE RGR
GO

SELECT Name_group FROM Groups
WHERE Name_group LIKE '%1'