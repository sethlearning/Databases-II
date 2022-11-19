USE master
GO


IF DB_ID('BooksDB') IS NULL
	CREATE DATABASE BooksDB
		ON PRIMARY
		(
			NAME = BooksDB,
			FILENAME = 'C:\db\BooksDB\booksdb.mdb',
			SIZE = 1 MB,
			MAXSIZE = 100 MB,
			FILEGROWTH = 1 MB
		)
		LOG ON
		(
			NAME = BooksDB_log,
			FILENAME = 'C:\db\BooksDB\booksdb.ldb',
			SIZE = 1 MB
		)

IF DB_ID('BooksDB') IS NOT NULL
	ALTER DATABASE BooksDB SET RECOVERY SIMPLE