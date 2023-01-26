-- 49. Вывести список групп и специальности (поля Name_group, Name_speciality из таблицы Groups),
-- у которых номер курса = 2 (условие по полю Num_course), поместить результат в курсор с названием Temp2.


USE RGR
GO

DECLARE Temp2 CURSOR
FOR
    SELECT Name_group, Name_speciality
    FROM Groups
    WHERE Num_course = 3

OPEN Temp2

FETCH NEXT FROM Temp2

CLOSE Temp2

DEALLOCATE Temp2
