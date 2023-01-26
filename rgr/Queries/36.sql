-- 36. Вывести средний балл (использовать поле Estimate из таблицы Progress) по результатам экзаменов каждого студента
-- и имена студентов (поля Surname, Name из таблицы Students)
-- за период сдачи экзаменов с 05.01.2003 по 25.01.2003 (условие по полю Date_exam из таблицы Progress).

USE RGR
GO

SELECT AVG(CONVERT(float, P.Estimate)), S.Lastname, S.Name
FROM Progress AS P, Students AS S
WHERE P.Code_stud = S.Code_stud
AND P.Date_exam BETWEEN '12/29/2022' AND '12/30/2022'
GROUP BY S.Lastname, S.Name
