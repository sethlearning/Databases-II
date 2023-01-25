-- 13. Вывести список групп (поле Name_group) из таблицы Groups,
-- которые не относятся к специальности ‘электротехника’ (условие по полю Name_speciality).

USE RGR
GO

SELECT Name_group FROM Groups
WHERE Name_speciality != 'электротехника'