-- 30. Вывести список имен преподавателей (поле Name_lector из таблицы Lectors),
-- которые принимали экзамены у студентов с кодами групп 10, 12, 15 (условие по полю Code_group из таблицы Students).

USE RGR
GO

SELECT DISTINCT L.Name_lector
FROM Lectors AS L, Progress AS P, Students AS S
WHERE P.Code_lector = L.Code_lector
AND P.Code_stud = S.Code_stud
AND S.Code_stud IN ('Ф12346', 'Ф12347', 'Ф12348')