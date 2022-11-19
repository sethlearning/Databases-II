USE master
GO

SELECT DB_ID('CPDB')

exec sp_helpdb CPDB

select * from sys.databases WHERE name = 'CPDB'