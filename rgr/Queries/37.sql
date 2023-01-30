-- 37. Вывести фамилии и имена студентов (поля Surname, Name из таблицы Students)
-- с максимальным средним баллом за весь период обучения (условие по полю Estimate из таблицы Progress).

USE RGR
GO

WITH T AS
(
    SELECT AVG(CONVERT (float, P.Estimate)) AS 'Mark', S.Lastname, S.Name
    FROM Students AS S, Progress AS P
    WHERE P.Code_stud = S.Code_stud
    GROUP BY S.Lastname, S.Name
)
SELECT T.Lastname, T.Name FROM T WHERE T.Mark = (SELECT MAX(T.Mark) FROM T)
