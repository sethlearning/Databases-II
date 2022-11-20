USE master
GO

SELECT DB_ID('ABCCompany');

exec sp_helpdb ABCCompany;

-- exec sp_dboption Books; - deprecated

SELECT * from sys.databases WHERE name = 'ABCCompany'
SELECT name, recovery_model, recovery_model_desc from sys.databases WHERE name = 'ABCCompany'