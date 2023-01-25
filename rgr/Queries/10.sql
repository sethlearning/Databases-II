-- 10. Вывести список студентов (поля Surname, Name, Lastname) из таблицы Students
-- и названия групп (поле Name_group) из таблицы Groups, значения которых начинаются с сочетания ‘АС’.

USE RGR
GO

SELECT S.Lastname, S.Name, S.Middlename, G.Name_group
FROM Students as S, Groups AS G
WHERE S.Code_group = G.Code_group
AND G.Name_group LIKE '%31'