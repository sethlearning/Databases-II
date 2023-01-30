-- 19. Вывести список групп и названия специальностей (поля Name_group и Name_speciality из таблицы Groups),
-- в которых учатся студенты со следующими номерами зачетной книжки
-- ‘АС-12-02’, ‘ПИ-14- 03’, ‘АС-21-03’, ‘БИ-12-02’ (условие по полю Code_stud из таблицы Students).

USE RGR
GO

SELECT DISTINCT G.Name_group, G.Name_speciality
FROM Groups AS G, Students AS S
WHERE S.Code_group = G.Code_group
AND Code_stud IN ('Ф12345', 'Ф12347', 'Ф12348')