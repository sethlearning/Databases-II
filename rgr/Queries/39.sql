-- 39. Вывести список групп (поле Name_group из таблицы Groups)
-- и количество студентов в каждой группе (по любому полю из таблицы Students),
-- поместив результат в новое поле Count_Students.


USE RGR
GO

SELECT G.Name_group, COUNT(S.Code_stud) AS Count_Students
FROM Students AS S, Groups AS G
WHERE S.Code_group = G.Code_group
GROUP BY G.Name_group