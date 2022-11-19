USE master;
GO

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'CPDB')
    CREATE DATABASE CPDB
        ON PRIMARY
        (
            Name = CPDB,
            FILENAME = 'C:\db\CPDB\cpdb.mdb',
            SIZE = 1 MB,
            MAXSIZE = 100 MB,
            FILEGROWTH = 1 MB
        )
        LOG ON
        (
            NAME = CPDB_log,
            FILENAME = 'C:\db\CPDB\cpdb.ldf',
            SIZE = 1 MB
        )

IF EXISTS (SELECT name FROM sys.databases WHERE name = N'DatabaseName')
    ALTER DATABASE CPDB SET RECOVERY SIMPLE