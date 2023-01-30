-- 43. Вывести все сведения о студентах и их даты рождения (поле Birthday) из таблицы Students,
-- значения которых находятся в диапазоне, хранящемся в переменных Birthday_begin и Birthday_end.
-- Например, пусть Birthday_begin = 12.03.1978, а Birthday_end = 12.03.1980.


USE RGR
GO

DECLARE @Birthday_begin date = '02/02/2000', @Birthday_end date = '04/04/2000'

SELECT Lastname, Name, Middlename, Birthday FROM Students
WHERE Birthday BETWEEN @Birthday_begin AND @Birthday_end