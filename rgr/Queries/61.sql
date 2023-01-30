-- 61. Добавить в таблицу успеваемости Progress новую запись,
-- вместо кода студента (поле Code_stud) поставить 45,
-- вместо кода предмета (поле Code_subject) – 12,
-- вместо кода лектора (поле Code_lector) – 11,
-- вместо даты экзамена (поле Date_exam) –’12.03.2003’.



USE RGR
GO

INSERT INTO Progress (Code_stud, Code_subject, Code_lector, Date_exam, Estimate)
    VALUES ('Ф12348', 3, 3, '03/12/2003', 5)

SELECT * FROM Progress