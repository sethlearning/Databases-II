-- 29. Вывести список студентов (поля Surname, Name из таблицы Students)
-- и номер курса (поле Num_course из таблицы Groups), учащихся в группе ‘Ас-31’ (условие по полю Name_group).

USE RGR
GO

SELECT S.Lastname, S.Name, S.Middlename, G.Num_course
FROM Students AS S, Groups AS G
WHERE S.Code_group = G.Code_group