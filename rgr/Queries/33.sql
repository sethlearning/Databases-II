-- 33. Вывести список всех студентов (поля Surname, Name, Lastname)
-- и их возраст в годах (использовать поле Birthday из таблицы Students).

USE RGR
GO

SELECT Lastname, Name, Middlename, DATEDIFF(year, Birthday, GETDATE()) AS 'Years old'
FROM Students
