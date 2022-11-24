USE CPDB
GO

CREATE VIEW [dbo].[ActiveUsers] AS
    SELECT Code, UserName, PasswordHash, Role
    FROM dbo.Users
    WHERE Enabled = 1
