-- 34. Вывести список всех студентов (поля Surname, Name, Lastname из таблицы Students) и номер курса, на котором они занимаются,
-- а также количество лет оставшейся учебы (использовать поле Num_course из таблицы Groups).

USE RGR
GO

SELECT S.Lastname, S.Name, S.Middlename, (4 - G.Num_course) AS Years
FROM Students AS S, Groups AS G
WHERE S.Code_group = G.Code_group
