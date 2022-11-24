USE CPDB
GO

CREATE VIEW dbo.ActiveUsers AS
    SELECT Code, UserName, PasswordHash, Role
    FROM dbo.Users
    WHERE Enabled = 1

CREATE VIEW dbo.UsersList AS
    SELECT U.Code AS Код, U.UserName AS [Имя пользователя], R.Name AS Роль, U.Enabled AS Активен
    FROM dbo.Users AS U, dbo.Roles AS R
    WHERE U.Role = R.Code