-- 25. Вывести всех студентов (поля Surname, Name, Code_group) из таблицы Students,
-- которые сдавали экзамен по дисциплине (поле Name_subject из таблицы Subjects) ‘математический анализ’.

USE RGR
GO

SELECT S.Lastname, S.Name, S.Middlename
FROM Students AS S, Subjects AS Sb, Progress AS P
WHERE   S.Code_stud = P.Code_stud
    AND P.Code_subject = Sb.Code_subject
    AND Sb.Name_subject = 'Программирование'