-- 58. Изменить в таблице Students содержимое поля Lastname на ‘нет сведений’, если значение поля является пустым.


USE RGR
GO

UPDATE Students
SET Lastname = 'нет сведений'
WHERE Lastname IS NULL
OR Lastname = ''

SELECT * FROM Students