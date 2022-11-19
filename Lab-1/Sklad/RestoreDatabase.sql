RESTORE DATABASE Sklad
    FROM DISK = 'c:\db\Sklad.bak'
    WITH RECOVERY,
    MOVE 'TestDB' TO 'c:\db\sklad\TestDB.mdf',
    MOVE 'TestDB_log' TO 'c:\db\sklad\TestDB.ldf',
    REPLACE