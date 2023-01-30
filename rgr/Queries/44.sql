-- 44. Вывести список студентов (поля Surname, Name, Lastname) и названия их групп (поле Name_group)
-- для значений кодов групп (поле Code_group), находящихся в диапазоне,
-- хранящемся в переменных Group_begin и Group_end.
-- Например, пусть Group_begin = 12, а Group_end = 35.



USE RGR
GO

DECLARE @Group_begin int = 1, @Group_end int = 2

SELECT S.Lastname, S.Name, S.Middlename, G.Name_group
FROM Students AS S, Groups AS G
WHERE S.Code_group = G.Code_group
AND G.Code_group BETWEEN @Group_begin AND @Group_end