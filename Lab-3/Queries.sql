USE Sklad
GO

SELECT *
FROM CUSTOMERS
WHERE CNUM IN
    (
        SELECT DISTINCT CNUM
        FROM ORDERS AS O1
        WHERE EXISTS
            (
                SELECT *
                FROM ORDERS AS O2
                WHERE O1.ODATE = O2.ODATE AND
                O1.SNUM <> O2.SNUM AND
                O1.CNUM = O2.CNUM
            )
    ) AND
    CITY IN ('Москва', 'Санкт-Петербург')
ORDER BY CNUM