-- 47. Вывести имена студентов (поля Surname, Name),
-- названия и коды преподавателей (поля Name_lector, Code_lector из таблицы Lectors), которым сдавали студенты экзамены,
-- а также оценки за предметы (поле Estimate),
-- причем таблица Students будет использоваться с именем ‘A’, таблица Progress будет использоваться с именем ‘B’,
-- а таблица Lectors будет использоваться с именем ‘C’.



USE RGR
GO

SELECT A.Lastname, Name, C.Name_lector, C.Code_lector, B.Estimate
FROM Students AS A, Progress AS B, Lectors AS C
WHERE A.Code_stud = B.Code_stud
AND B.Code_lector = C.Code_lector