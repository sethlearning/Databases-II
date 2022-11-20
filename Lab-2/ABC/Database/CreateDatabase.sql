USE master
GO

IF DB_ID('ABCCompany') IS NULL
	CREATE DATABASE ABCCompany
		ON PRIMARY
		(
			NAME = ABCCompany,
			FILENAME = 'C:\db\ABCCompany\abccompany.mdb',
			SIZE = 1 MB,
			MAXSIZE = 100 MB,
			FILEGROWTH = 1 MB
		)
		LOG ON
		(
			NAME = ABCCompany_log,
			FILENAME = 'C:\db\ABCCompany\abccompany.ldb',
			SIZE = 1 MB
		)

IF DB_ID('ABCCompany') IS NOT NULL
	ALTER DATABASE ABCCompany SET RECOVERY SIMPLE