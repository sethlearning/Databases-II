-- 35. Вывести список всех групп (поле Name_group из таблицы Groups)
-- и количество студентов в каждой группе (по любому полю из таблицы Students).

USE RGR
GO

SELECT G.Name_group, COUNT(S.Code_stud) AS 'Count'
FROM Students AS S, Groups AS G
WHERE S.Code_group = G.Code_group
GROUP BY G.Name_group
