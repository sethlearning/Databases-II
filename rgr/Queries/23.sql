-- 23. Вывести список студентов (поля Surname, Name, Lastname) и даты рождения (поле Birthday) из таблицы Students,
-- которые содержат в фамилии сочетание букв ‘нова’ (условие по полю Surname).

USE RGR
GO

SELECT Lastname, Name, Middlename, Birthday
FROM Students
WHERE Lastname LIKE '%нов%'