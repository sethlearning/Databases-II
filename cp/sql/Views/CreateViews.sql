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
