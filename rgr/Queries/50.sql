-- 50. Вывести список всех изучаемых дисциплин (поле Name_subject из таблицы Subjects)
-- и поместить результат в курсор с названием Temp3.


USE RGR
GO

DECLARE Temp3 CURSOR
FOR
    SELECT Name_subject FROM Subjects

OPEN Temp3

FETCH NEXT FROM Temp3

CLOSE Temp3

DEALLOCATE Temp3

