-- 6. Вывести список фамилий (поле Surname), имен (поле Name), отчеств (поле Lastname) студентов из таблицы Students
-- и названий групп (поле Name_group) из таблицы Groups, в которых они обучаются.

USE RGR
GO

SELECT S.Lastname, S.Name, S.Middlename, G.Name_group
FROM Students AS S, Groups AS G
WHERE S.Code_group = G.Code_group