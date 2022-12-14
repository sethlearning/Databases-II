USE TStation
GO

SELECT C.NAME AS Категория, COUNT(*) AS Количество, 'Звонки менее 3 минут' AS Комментарий
FROM ZVONKI AS Z, ABONETS AS A, KATEGOR AS C
WHERE CAST(O_TIME - N_TIME AS TIME) < CAST('00:03:00' AS TIME) AND
      Z.C_AB = A.C_AB AND
      A.KAT_C = C.CODE
GROUP BY C.NAME
ORDER BY Количество DESC

SELECT C.NAME AS Категория, COUNT(*) AS Количество, 'Звонки от 3 до 5 минут' AS Комментарий
FROM ZVONKI AS Z, ABONETS AS A, KATEGOR AS C
WHERE CAST(O_TIME - N_TIME AS TIME) >= CAST('00:03:00' AS TIME) AND
      CAST(O_TIME - N_TIME AS TIME) < CAST('00:05:00' AS TIME) AND
      Z.C_AB = A.C_AB AND
      A.KAT_C = C.CODE
GROUP BY C.NAME
ORDER BY Количество DESC

SELECT C.NAME AS Категория, COUNT(*) AS Количество, 'Звонки от 5 до 10 минут' AS Комментарий
FROM ZVONKI AS Z, ABONETS AS A, KATEGOR AS C
WHERE CAST(O_TIME - N_TIME AS TIME) >= CAST('00:05:00' AS TIME) AND
      CAST(O_TIME - N_TIME AS TIME) < CAST('00:10:00' AS TIME) AND
      Z.C_AB = A.C_AB AND
      A.KAT_C = C.CODE
GROUP BY C.NAME
ORDER BY Количество DESC

SELECT C.NAME AS Категория, COUNT(*) AS Количество, 'Звонки от 5 до 10 минут' AS Комментарий
FROM ZVONKI AS Z, ABONETS AS A, KATEGOR AS C
WHERE CAST(O_TIME - N_TIME AS TIME) >= CAST('00:10:00' AS TIME) AND
      Z.C_AB = A.C_AB AND
      A.KAT_C = C.CODE
GROUP BY C.NAME
ORDER BY Количество DESC





-- SELECT * FROM TARIF

-- SELECT * FROM ZVONKI

-- SELECT *, CAST(O_TIME - N_TIME AS TIME) AS Diff
-- FROM ZVONKI
-- WHERE CAST('00:03:00' AS TIME) > CAST(O_TIME - N_TIME AS TIME)
-- -- ORDER BY CAST(O_TIME - N_TIME AS TIME) DESC

SELECT *, CAST(O_TIME - N_TIME AS TIME) AS Diff
FROM ZVONKI
WHERE CAST(O_TIME - N_TIME AS TIME) >= CAST('00:03:00' AS TIME) AND
      CAST(O_TIME - N_TIME AS TIME) < CAST('00:05:00' AS TIME)
-- ORDER BY CAST(O_TIME - N_TIME AS TIME) DESC

-- SELECT Z.*, A.IO_AB, A.ADDRESS, C.NAME, CAST(O_TIME - N_TIME AS TIME) AS Diff
-- FROM ZVONKI AS Z, ABONETS AS A, KATEGOR AS C
-- WHERE CAST('00:03:00' AS TIME) > CAST(O_TIME - N_TIME AS TIME) AND
--       Z.C_AB = A.C_AB AND
--       A.KAT_C = C.CODE
-- ORDER BY C.NAME

