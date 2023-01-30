-- 52. Вывести все сведения о сдачах экзаменов (все поля из таблицы Progress)
-- и список студентов (поля Surname, Name из таблицы Students),
-- которые по таблице Progress сдавали экзамены самыми последними (дата сдачи экзаменов Date_exam максимальна).


USE RGR
GO

SELECT P.*, S.Lastname, S.Name
FROM Students AS S, Progress AS P
WHERE P.Code_stud = S.Code_stud
AND P.Date_exam = 
(
    SELECT MAX(Date_exam) FROM Progress
)