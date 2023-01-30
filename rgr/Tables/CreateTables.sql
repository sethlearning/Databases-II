USE RGR
GO

-- Groups
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Groups')
    BEGIN
        CREATE TABLE dbo.Groups
        (
            Code_group INT IDENTITY(1, 1) CONSTRAINT PK_Groups PRIMARY KEY,
            Name_group VARCHAR(64) NOT NULL,
            Num_course INT NOT NULL,
            Name_speciality VARCHAR(64) NOT NULL
        )

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Справочник групп',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Groups'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Код группы',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Groups',
                                        @level2type=N'COLUMN',   @level2name=N'Code_group'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Название группы',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Groups',
                                        @level2type=N'COLUMN',   @level2name=N'Name_group'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Номер курса',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Groups',
                                        @level2type=N'COLUMN',   @level2name=N'Num_course'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Название специальности',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Groups',
                                        @level2type=N'COLUMN',   @level2name=N'Name_speciality'
    END


-- Students
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Students')
    BEGIN
        CREATE TABLE dbo.Students
        (
            Code_stud CHAR(10) CONSTRAINT PK_Students PRIMARY KEY,
            Lastname VARCHAR(64) NOT NULL,
            Name VARCHAR(64) NOT NULL,
            Middlename VARCHAR(64) NOT NULL,
            Code_group INT NOT NULL CONSTRAINT FK_Students_Groups FOREIGN KEY REFERENCES Groups (Code_group) ON DELETE NO ACTION ON UPDATE NO ACTION,
            Birthday DATE,
            Phone NUMERIC(11, 0)
        )

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Справочник студентов',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Students'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Номер зачетной книжки',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Students',
                                        @level2type=N'COLUMN',   @level2name=N'Code_stud'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Фамилия студента',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Students',
                                        @level2type=N'COLUMN',   @level2name=N'Lastname'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Имя студента',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Students',
                                        @level2type=N'COLUMN',   @level2name=N'Name'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Отчество студента',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Students',
                                        @level2type=N'COLUMN',   @level2name=N'Middlename'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Код группы',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Students',
                                        @level2type=N'COLUMN',   @level2name=N'Code_group'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Дата рождения студента',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Students',
                                        @level2type=N'COLUMN',   @level2name=N'Birthday'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Контактный телефон студента',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Students',
                                        @level2type=N'COLUMN',   @level2name=N'Phone'
    END


-- Lectors
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Lectors')
    BEGIN
        CREATE TABLE dbo.Lectors
        (
            Code_lector INT IDENTITY(1, 1) CONSTRAINT PK_Lectors PRIMARY KEY,
            Name_lector VARCHAR(64) NOT NULL,
            Science VARCHAR(64) NOT NULL,
            Post VARCHAR(64) NOT NULL,
            Date_ DATE NOT NULL
        )

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Справочник преподавателей',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Lectors'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Код преподавателя',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Lectors',
                                        @level2type=N'COLUMN',   @level2name=N'Code_lector'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Фамилия, имя, отчество преподавателя',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Lectors',
                                        @level2type=N'COLUMN',   @level2name=N'Name_lector'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ученая степень',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Lectors',
                                        @level2type=N'COLUMN',   @level2name=N'Science'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Должность',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Lectors',
                                        @level2type=N'COLUMN',   @level2name=N'Post'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Дата приема на работу',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Lectors',
                                        @level2type=N'COLUMN',   @level2name=N'Date_'
    END


-- Subjects
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Subjects')
    BEGIN
        CREATE TABLE dbo.Subjects
        (
            Code_subject INT IDENTITY(1, 1) CONSTRAINT PK_Subjects PRIMARY KEY,
            Name_subject VARCHAR(64) NOT NULL,
            Count_hours INT NOT NULL
        )

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Справочник изучаемых дисциплин',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Subjects'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Код дисциплины',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Subjects',
                                        @level2type=N'COLUMN',   @level2name=N'Code_subject'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Назавние дисциплины',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Subjects',
                                        @level2type=N'COLUMN',   @level2name=N'Name_subject'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Количество часов в курсе',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Subjects',
                                        @level2type=N'COLUMN',   @level2name=N'Count_hours'

    END


-- Progress
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Progress')
    BEGIN
        CREATE TABLE dbo.Progress
        (
            Code_progress INT IDENTITY(1, 1) CONSTRAINT PK_Progress PRIMARY KEY,
            Code_stud CHAR(10) NOT NULL CONSTRAINT FK_Progress_Students FOREIGN KEY REFERENCES Students (Code_stud) ON DELETE NO ACTION ON UPDATE NO ACTION,
            Code_subject INT NOT NULL CONSTRAINT FK_Progress_Subjects FOREIGN KEY REFERENCES Subjects (Code_subject) ON DELETE NO ACTION ON UPDATE NO ACTION,
            Code_lector INT NOT NULL CONSTRAINT FK_Progress_Lectors FOREIGN KEY REFERENCES Lectors (Code_lector) ON DELETE NO ACTION ON UPDATE NO ACTION,
            Date_exam DATE NOT NULL,
            Estimate INT NOT NULL
        )

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Журнал успеваемости',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Progress'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ключевое поле',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Progress',
                                        @level2type=N'COLUMN',   @level2name=N'Code_progress'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Номер зачетной книжки',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Progress',
                                        @level2type=N'COLUMN',   @level2name=N'Code_stud'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Код дисциплины',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Progress',
                                        @level2type=N'COLUMN',   @level2name=N'Code_subject'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Код преподавателя',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Progress',
                                        @level2type=N'COLUMN',   @level2name=N'Code_lector'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Дата сдачи экзамена',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Progress',
                                        @level2type=N'COLUMN',   @level2name=N'Date_exam'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Оценка',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Progress',
                                        @level2type=N'COLUMN',   @level2name=N'Estimate'

    END

