RESTORE DATABASE TStation
    FROM DISK = 'c:\db\TStation.bak'
    WITH RECOVERY,
    MOVE 'Zvonki' TO 'c:\db\TStation\TStation.mdf',
    MOVE 'Zvonki_log' TO 'c:\db\TStation\TStation.ldf',
    REPLACE