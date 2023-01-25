USE master
GO

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'RGR')
    CREATE DATABASE RGR
        ON PRIMARY
        (
            Name = RGR,
            FILENAME = 'C:\db\RGR\rgr.mdb',
            SIZE = 1 MB,
            MAXSIZE = 100 MB,
            FILEGROWTH = 1 MB
        )
        LOG ON
        (
            NAME = RGR_log,
            FILENAME = 'C:\db\RGR\rgr.ldf',
            SIZE = 1 MB
        )

IF EXISTS (SELECT name FROM sys.databases WHERE name = N'RGR')
    ALTER DATABASE RGR SET RECOVERY SIMPLE