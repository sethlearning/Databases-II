-- 65. Удалить из таблицы Progress все записи, в которых не указана дата экзамена (поле Date_exam пустое).


USE RGR
GO

SELECT * FROM Progress

DELETE FROM Progress
WHERE Date_exam IS NULL
-- OR Date_exam = ''
-- OR Date_exam = '12/12/2022'

SELECT * FROM Progress