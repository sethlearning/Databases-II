-- 18. Вывести список дисциплин (поле Name_subject) из таблицы Subjects,
-- у которых название начинается на одну из букв диапазона ‘В’–‘Г’ (условие по полю Name_subject).

USE RGR
GO

SELECT Name_subject FROM Subjects
WHERE Name_subject BETWEEN 'И' AND 'Н'