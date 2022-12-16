USE CPDB
GO

CREATE VIEW dbo.vActiveUsers AS
    SELECT Code, UserName, PasswordHash, Role
    FROM dbo.Users
    WHERE Enabled = 1
GO

CREATE VIEW dbo.vUsersList AS
    SELECT U.Code AS Код, U.UserName AS [Имя пользователя], R.Name AS Роль, U.Enabled AS Активен
    FROM dbo.Users AS U, dbo.Roles AS R
    WHERE U.Role = R.Code
GO

CREATE VIEW dbo.vRolesList AS
    SELECT R.Code AS Код, R.Name AS Роль, R.AccessControl AS Доступ
    FROM dbo.Roles AS R
GO

CREATE VIEW dbo.vWorkCategoriesList AS
    SELECT W.Code AS Код, W.Name AS Категория, W.ChangeTime AS [Дата изменения], U.UserName AS Пользователь
    FROM dbo.WorkCategories AS W, dbo.Users AS U
    WHERE W.ChangedBy = U.Code
GO

CREATE VIEW dbo.vEmployersList AS
    SELECT E.Code AS Код, E.Name AS Название, E.Address AS Адрес, E.Phone AS Телефон, E.ChangeTime AS [Дата изменения], U.UserName AS Пользователь
    FROM dbo.Employers AS E, dbo.Users AS U
    WHERE E.ChangedBy = U.Code
GO

CREATE VIEW dbo.vVacanciesList AS
    SELECT V.Code AS Код, W.Name AS [Вид деятельности], V.Position AS Должность, V.Salary AS [Заработная плата], E.Name AS Работодатель, V.ChangeTime AS [Дата изменения], U.UserName AS Пользователь
    FROM dbo.Vacancies AS V, dbo.WorkCategories AS W, dbo.Employers AS E, dbo.Users AS U
    WHERE V.WorkCategory = W.Code AND V.Employer = E.Code AND V.ChangedBy = U.Code
GO

CREATE VIEW dbo.vJobSeekersList AS
    SELECT J.Code AS Код, J.LastName AS Фамилия, J.FirstName AS Имя, J.MiddleName AS Отчество, W.Name AS [Вид деятельности], J.Qualification AS Квалификация, J.DesiredSalary AS [Желаемая зарплата], J.Notes AS [Иные данные], J.ChangeTime AS [Дата изменения], U.UserName AS Пользователь
    FROM dbo.JobSeekers AS J, dbo.WorkCategories AS W, dbo.Users AS U
    WHERE J.WorkCategory = W.Code AND J.ChangedBy = U.Code
GO

CREATE VIEW dbo.vDealsList AS
    SELECT D.Code AS Код, E.Name AS Работодатель, W.Name AS [Вид деятельности], V.Position AS Должность, dbo.fGetFullName(J.LastName, J.FirstName, J.MiddleName) AS Соискатель, D.Commission AS Комиссионные, D.ChangeTime AS [Дата изменения], U.UserName AS Пользователь
    FROM dbo.Deals AS D, dbo.Employers AS E, dbo.WorkCategories AS W, dbo.Vacancies AS V, dbo.JobSeekers AS J, dbo.Users AS U
    WHERE D.JobSeeker = J.Code AND D.Vacancy = V.Code AND V.Employer = E.Code AND V.WorkCategory = W.Code AND D.ChangedBy = U.Code
GO

CREATE VIEW dbo.vJobSeekersWithFIOList AS
    SELECT J.Code AS Код, CONCAT_WS(' ', J.LastName, J.FirstName, J.MiddleName) AS ФИО, W.Name AS [Вид деятельности], J.Qualification AS Квалификация, J.DesiredSalary AS [Желаемая зарплата], J.Notes AS [Иные данные], J.ChangeTime AS [Дата изменения], U.UserName AS Пользователь
    FROM dbo.JobSeekers AS J, dbo.WorkCategories AS W, dbo.Users AS U
    WHERE J.WorkCategory = W.Code AND J.ChangedBy = U.Code
GO