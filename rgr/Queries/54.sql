-- 54. Вывести список студентов (поля Surname, Name, Lastname из таблицы Students),
-- которые сдали все экзамены без двоек (подзапрос по таблице Progress).


USE RGR
GO

SELECT S.Lastname, S.Name, S.Middlename
FROM Students AS S
WHERE NOT EXISTS
(
    SELECT *
    FROM Progress AS P
    WHERE P.Code_stud = S.Code_stud
    AND P.Estimate = 2
)