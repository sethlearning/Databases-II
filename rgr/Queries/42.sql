-- 42. Вывести список студентов (поля Surname, Name, Lastname) и их телефоны (поле Phone) из таблицы Students,
-- если значения телефонов находятся в диапазоне, хранящемся в переменных Phone_begin и Phone_end.
-- Например, пусть Phone_begin = 125478, а Phone_end = 352456.



USE RGR
GO

DECLARE @Phone_begin NUMERIC(11, 0) = 77654321098
DECLARE @Phone_end NUMERIC(11, 0) = 79876543210

SELECT Lastname, Name, Middlename, Phone
FROM Students
WHERE Phone BETWEEN @Phone_begin AND @Phone_end