-- 63. Удалить из таблицы Students все записи,
-- код группы которых равен 35, или 15, или 19 (условие по полю Code_group).



USE RGR
GO

SELECT * FROM Students

DELETE FROM Students
WHERE Code_group IN (3, 4, 5)

SELECT * FROM Students