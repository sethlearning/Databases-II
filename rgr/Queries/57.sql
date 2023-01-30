-- 57. Увеличить номер курса (поле Num_course) у всех групп на единицу в таблице Groups,
-- если системная дата равна значению «первое сентября нового учебного года».


USE RGR
GO

UPDATE Groups
SET Num_course += 1
WHERE MONTH(GETDATE()) = 9
AND DAY(GETDATE()) = 1

SELECT * FROM Groups