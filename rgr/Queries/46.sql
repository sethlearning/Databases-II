-- 46. Вывести имена студентов (поля Surname, Name),
-- названия и коды предметов (поля Name_subject, Code_subject из таблицы Subjects),
-- которые сдавали студенты, а также оценки за предметы (поле Estimate),
-- причем таблица Students будет использоваться с именем ‘A’, таблица Progress будет использоваться с именем ‘B’,
-- а таблица Subjects будет использоваться с именем ‘C’.



USE RGR
GO

SELECT A.Lastname, A.Name, C.Name_subject, C.Code_subject, B.Estimate
FROM Students AS A, Progress AS B, Subjects AS C
WHERE A.Code_stud = B.Code_stud
AND B.Code_subject = C.Code_subject