-- 51. Вывести список преподавателей (все поля из таблицы Lectors),
-- дата устройства которых меньше средней даты устройства всех преподавателей в таблице (условие по полю Date_).


USE RGR
GO

SELECT *, DATEDIFF(day, Date_, GETDATE()) AS Days FROM Lectors
WHERE DATEDIFF(day, Date_, GETDATE()) <
(
    SELECT AVG(DATEDIFF(day, Date_, GETDATE()))
    FROM Lectors
)