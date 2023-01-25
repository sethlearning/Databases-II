USE RGR
GO

-- Groups
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Groups')
    INSERT INTO dbo.Groups (Name_group, Num_course, Name_speciality)
        VALUES  ('ИВТ-31', 3, 'Информатика и вычислительная техника'),
                ('ИВТ-32', 3, 'Информатика и вычислительная техника'),
                ('ИВТ-21', 2, 'Информатика и вычислительная техника')

SELECT * FROM dbo.Groups

-- Students
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Students')
    INSERT INTO dbo.Students (Code_stud, Lastname, Name, Middlename, Code_group, Birthday, Phone)
        VALUES  ('Ф12345', 'Иванов', 'Иван', 'Иванович', 1, '01/01/2000', 79876543210),
                ('Ф12346', 'Петров', 'Петр', 'Петрович', 1, '02/02/2000', 78765432109),
                ('Ф12347', 'Сидоров', 'Сидор', 'Сидорович', 2, '03/03/2000', 77654321098),
                ('Ф12348', 'Панкратов', 'Панкрат', 'Панкратович', 2, '04/04/2000', 76543210987)

SELECT * FROM dbo.Students

-- Lectors
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Lectors')
    INSERT INTO dbo.Lectors (Name_lector, Science, Post, Date_)
        VALUES  ('Иванов И.И.', 'д.т.н.', 'профессор', '01/01/2000'),
                ('Петров П.П.', 'д.т.н.', 'доцент', '02/02/2001'),
                ('Сидоров С.С.', 'к.т.н.', 'доцент', '03/03/2002')

SELECT * FROM dbo.Lectors

-- Subjects
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Subjects')
    INSERT INTO dbo.Subjects (Name_subject, Count_hours)
        VALUES  ('Математика', 180),
                ('Информатика', 190),
                ('Программирование', 200)

SELECT * FROM dbo.Subjects


-- Progress
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Progress')
    INSERT INTO dbo.Progress (Code_stud, Code_subject, Code_lector, Date_exam, Estimate)
        VALUES  ('Ф12345', 1, 1, '12/29/2022', 5),
                ('Ф12346', 2, 2, '12/30/2022', 5),
                ('Ф12347', 3, 3, '12/31/2022', 5),
                ('Ф12348', 3, 3, '12/31/2022', 5)

SELECT * FROM dbo.Progress