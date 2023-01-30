-- 60. Добавить в таблицу Student новую запись,
-- причем так, чтобы код студента (по полю Code_stud) был автоматически увеличен на единицу,
-- а ФИО = ‘Иванов’ ‘Павел’ ‘Сергеевич’ (поля Surname, Name, LastName).


USE RGR
GO

DECLARE @CODE CHAR(10)
DECLARE @CODEINT int

SELECT @CODE = MAX(Code_stud) FROM Students

SELECT @CODEINT = SUBSTRING(@CODE, 2, LEN(@CODE)-1)
SET @CODEINT += 1
-- SELECT @CODEINT

SELECT @CODE = CONCAT('Ф', @CODEINT)
-- SELECT @CODE

INSERT INTO Students (Code_stud, Lastname, Name, Middlename, Code_group)
    VALUES (@CODE, 'Иванов', 'Павел', 'Сергеевич', 2)

SELECT * FROM Students
