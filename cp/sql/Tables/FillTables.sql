USE CPDB
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'WorkCategories')
    INSERT INTO dbo.WorkCategories (Category)
        VALUES  ('Информационные технологии'),
                ('Металлообработка'),
                ('Производство продуктов питания'),
                ('Охрана окружающей среды'),
                ('Сельское хозяйство')

SELECT * FROM dbo.WorkCategories


IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Employers')
    INSERT INTO dbo.Employers (Name, Address, Phone)
        VALUES  ('ООО "Рога и копыта"', 'г. Калуга, ул. Окраинная, д. 99', '+7-900-123-4567'),
                ('ООО "Чистый лес"', 'г. Самара, ул. Лесная, д. 1', '+7-901-234-5678'),
                ('ООО "Бублики и чай"', 'г. Владивосток, ул. Морская, д. 15', '+7-902-345-6789'),
                ('ООО "Металлоконструкт"', 'г. Кемерово, ул. Безлюдная, д. 20', '+7-903-456-7890'),
                ('ООО "Байт и восемь бит"', 'г. Санкт-Петербург, Невский пр., д. 1', '+7-904-567-8901')

SELECT * FROM dbo.Employers


IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'JobSeekers')
    INSERT INTO dbo.JobSeekers (LastName, FirstName, MiddleName, WorkCategory, Qualification, DesiredSalary, Notes)
        VALUES  ('Иванов', 'Петр', 'Сидорович', 1, 'Высший разряд', 100000, 'Отличный парень'),
                ('Петров', 'Сидор', 'Иванович', 2, 'Первый разряд', 80000, 'Вроде ничего'),
                ('Сидоров', 'Иван', 'Петрович', 3, 'Второй разряд', 50000, NULL),
                ('Александров', 'Николай', 'Алексеевич', 4, NULL, 90000, 'Способный'),
                ('Николаев', 'Алексей', 'Александрович', 5, 'Высший разряд', 80000, 'Вежливый'),
                ('Алексеев', 'Александр', 'Николаевич', 1, 'Первый разряд', 70000, 'Суетливый'),
                ('Панкратов', 'Афанасий', 'Никифорович', 2, 'Второй разряд', 85000, 'Знает свое дело'),
                ('Афанасьев', 'Никифор', 'Панкратович', 3, NULL, 110000, NULL)

SELECT * FROM dbo.JobSeekers


IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Vacancies')
    INSERT INTO dbo.Vacancies (WorkCategory, Position, Salary, Employer)
        VALUES  (1, 'Директор', 100000, 5),
                (2, 'Заведующий отделом', 80000, 4),
                (3, 'Менеджер', 50000, 3),
                (4, 'Инженер', 90000, 2),
                (5, 'Агроном', 55000, 1),
                (1, 'Разработчик', 45000, 5),
                (2, 'Контролер', 65000, 4),
                (3, 'Технолог', 90000, 3)

SELECT * FROM dbo.Vacancies


IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Deals')
    INSERT INTO dbo.Deals (JobSeeker, Vacancy, Commission, DateClosed)
        VALUES  (1, 1, 10000, '09/08/2022'),
                (2, 2, 8000, '09/09/2022'),
                (3, 3, 5000, '09/10/2022'),
                (4, 4, 9000, '09/12/2022')

SELECT * FROM dbo.Deals

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Roles')
    INSERT INTO dbo.Roles (Name, AccessControl)
        VALUES  ('Администратор', 15),
                ('Руководитель', 15),
                ('Менеджер', 15),
                ('Оператор', 15)

SELECT * FROM dbo.Roles


IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Users')
    INSERT INTO dbo.Users (UserName, PasswordHash, Role, Enabled)
        VALUES  ('Администратор', '6B86B273FF34FCE19D6B804EFF5A3F5747ADA4EAA22F1D49C01E52DDB7875B4B', 1, 1),
                ('Директор Иванов И.И.', 'D4735E3A265E16EEE03F59718B9B5D03019C07D8B6C51F90DA3A666EEC13AB35', 2, 1),
                ('Менеджер Петров П.П.', '4E07408562BEDB8B60CE05C1DECFE3AD16B72230967DE01F640B7E4729B49FCE', 3, 1),
                ('Оператор Сидоров С.С.', '4B227777D4DD1FC61C6F884F48641D02B4D121D3FD328CB08B5531FCACDABF8A', 4, 1),
                ('Оператор Панкратов П.П.', 'EF2D127DE37B942BAAD06145E54B0C619A1F22327B2EBBCFBEC78F5564AFE39D', 4, 0)

SELECT * FROM Users