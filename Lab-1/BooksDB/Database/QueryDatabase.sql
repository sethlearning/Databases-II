USE master
GO

SELECT DB_ID('BooksDB');

exec sp_helpdb BooksDB;

-- exec sp_dboption Books; - deprecated

SELECT * from sys.databases WHERE name = 'BooksDB'
SELECT name, recovery_model, recovery_model_desc from sys.databases WHERE name = 'BooksDB'