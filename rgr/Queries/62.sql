-- 62. Добавить в таблицу преподавателей Lectors новую запись,
-- причем вместо ключевого поля поставить код (по полю Code_lector),
-- автоматически увеличенный на единицу от максимального кода в таблице,
-- вместо имени (поле Name_lector) – ‘Петров Савелий Яковлевич’,
-- вместо ученой степени (поле Science) – ‘к.т.н.’.



USE RGR
GO

DECLARE @CODE int
SELECT @CODE = MAX(Code_lector) FROM Lectors
SET @CODE += 1

-- SELECT @CODE

SET IDENTITY_INSERT Lectors ON

INSERT INTO Lectors (Code_Lector, Name_lector, Science, Post, Date_)
    VALUES (@CODE, 'Петров С.Я.', 'к.т.н.', 'доцент', '04/04/2003')

SET IDENTITY_INSERT Lectors OFF

SELECT * FROM Lectors