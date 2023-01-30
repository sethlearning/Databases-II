-- 45. Вывести коды студентов (поле Code_stud) и имена (поля Surname, Name),
-- названия и коды групп (поля Name_group, Code_group из таблицы Groups),
-- причем таблица Students будет использоваться с именем ‘A’, а таблица Groups будет использоваться с именем ‘B’.



USE RGR
GO

SELECT A.Code_stud, A.Lastname, A.Name, B.Name_group, B.Code_group
FROM Students AS A, Groups AS B
WHERE A.Code_group = B.Code_group