-- 48. Вывести все сведения о сданных экзаменах (все поля из таблицы Progress)
-- для студента с фамилией ‘Васьков’ и именем ‘Павел’ (условия по полям Surname, Name из таблицы Students)
-- и поместить результат в курсор с названием Temp1.


USE RGR
GO

DECLARE Temp1 CURSOR
FOR
    SELECT P.*
    FROM Students AS S, Progress AS P
    WHERE S.Code_stud = P.Code_stud
    AND S.Lastname = 'Иванов'
    AND S.Name = 'Иван'

OPEN Temp1

FETCH NEXT FROM Temp1

CLOSE Temp1

DEALLOCATE Temp1