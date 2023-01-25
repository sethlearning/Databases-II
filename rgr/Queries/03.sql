-- 3. Выбрать из таблицы Groups названия групп и номера курсов (поля Name_group, Num_course)
-- и отсортировать результат по полю Name_course по убыванию.

USE RGR
GO

SELECT Name_group, Num_course FROM Groups
ORDER BY Num_Course DESC