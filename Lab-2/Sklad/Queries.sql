USE Sklad
GO

SELECT DISTINCT C.*
FROM ORDERS AS O, CUSTOM AS C
WHERE O.SUMM > ( SELECT AVG(SUMM) FROM ORDERS  WHERE ODATE = '09/01/2001' ) AND
      O.TNUM = C.TNUM
ORDER BY C.TNUM

SELECT DISTINCT C.TNUM, C.VID, C.NAMET, C.COUNT, C.CINA, CAST(C.ZDATA AS DATE) AS ZDATA, CAST(C.RDATA AS DATE) AS RDATA
FROM ORDERS AS O, CUSTOM AS C
WHERE O.SUMM > ( SELECT AVG(SUMM) FROM ORDERS  WHERE ODATE = '09/01/2001' ) AND
      O.TNUM = C.TNUM
ORDER BY C.TNUM


-- SELECT *
-- FROM ORDERS

-- SELECT AVG(SUMM)
-- FROM ORDERS

-- SELECT *
-- FROM ORDERS
-- ORDER BY SUMM DESC

-- SELECT *
-- FROM ORDERS
-- WHERE SUMM > ( SELECT AVG(SUMM) FROM ORDERS )
-- ORDER BY SUMM DESC


SELECT *
FROM ORDERS 
WHERE ODATE = '09/01/2001'

SELECT AVG(SUMM)
FROM ORDERS 
WHERE ODATE = '09/01/2001'

SELECT O.*
FROM ORDERS AS O
WHERE SUMM > ( SELECT AVG(SUMM) FROM ORDERS  WHERE ODATE = '09/01/2001' )
ORDER BY SUMM DESC

-- SELECT *
-- FROM CUSTOM

