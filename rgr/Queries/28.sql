-- 28. Вывести список названий дисциплин (поле Name_subject из таблицы Subjects)
-- и имен преподавателей (поле Name_lector из таблицы Lectors), которые принимали по этим дисциплинам экзамены.

USE RGR
GO

SELECT DISTINCT S.Name_subject, L.Name_lector
FROM Subjects AS S, Progress AS P, Lectors AS L
WHERE P.Code_subject = S.Code_subject
AND P.Code_lector = L.Code_lector