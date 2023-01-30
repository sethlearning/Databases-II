-- 53. Вывести список групп (поле Name_group), в которых студентов больше 25.


USE RGR
GO

SELECT G.Name_group
FROM Groups AS G
WHERE 2 <=
(
    SELECT COUNT(*)
    FROM Students AS S
    WHERE S.Code_group = G.Code_group
)