-- 27. Вывести список групп (поле Name_group) и номера курсов (поле Num_course) из таблицы Groups,
-- в которых учатся студенты с датами рождения с 01.01.1976 по 01.01.1978 (условие по полю Birthday из таблицы Students)
-- и кодами из диапазона 10 – 150 (условие по полю Code_stud из таблицы Students).

USE RGR
GO

SELECT DISTINCT G.Name_group, G.Num_course
FROM Groups AS G, Students AS S
WHERE   S.Code_group = G.Code_group
    AND S.Birthday BETWEEN '01/01/2000' AND '03/03/2000'
    AND S.Code_stud BETWEEN 'Ф12345' AND 'Ф12346'