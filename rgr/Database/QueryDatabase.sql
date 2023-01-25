USE master
GO

SELECT DB_ID('RGR')

exec sp_helpdb RGR

SELECT name FROM sys.databases WHERE name = N'RGR'