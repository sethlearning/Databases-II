-- 56. Вывести список студентов (поля Surname, Name, Lastname из таблицы Students),
-- которые сдали все экзамены на "отлично" (подзапрос по таблице Progress).


USE RGR
GO

SELECT S.Lastname, S.Name, S.Middlename
FROM Students AS S
WHERE 5 = ALL
(
    SELECT P.Estimate
    FROM Progress AS P
    WHERE P.Code_stud = S.Code_stud
)
