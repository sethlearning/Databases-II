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