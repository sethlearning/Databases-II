-- 17. Вывести список студентов (поля Surname, Name, Lastname) и их телефоны (поле Phone) из таблицы Students,
-- если значения телефонов находятся в диапазоне от 220000 до 226666 (условие по полю Phone).

USE RGR
GO

SELECT Lastname, Name, Middlename, Phone
FROM Students
WHERE Phone BETWEEN 77654321098 AND 78765432109