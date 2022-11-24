USE CPDB
GO

-- WorkCategories
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'WorkCategories')
    BEGIN
        CREATE TABLE dbo.WorkCategories
        (
            Code INT IDENTITY(1, 1) CONSTRAINT PK_WorkCategories PRIMARY KEY,
            Category VARCHAR(60) NOT NULL INDEX Idx_Category NONCLUSTERED WITH (FILLFACTOR = 90)
        )
        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Справочник видов деятельности',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'WorkCategories'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Код категории',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'WorkCategories',
                                        @level2type=N'COLUMN',   @level2name=N'Code'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Наименование категории',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'WorkCategories',
                                        @level2type=N'COLUMN',   @level2name=N'Category'
    END

-- Employers
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Employers')
    BEGIN
        CREATE TABLE dbo.Employers
        (
            Code INT IDENTITY(1, 1) CONSTRAINT PK_Employers PRIMARY KEY,
            Name VARCHAR(60) NOT NULL INDEX Idx_Name NONCLUSTERED WITH (FILLFACTOR = 90),
            Address VARCHAR(120) NULL,
            Phone VARCHAR(15) NULL
        )
        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Справочник работодателей',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Employers'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Код работодателя',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Employers',
                                        @level2type=N'COLUMN',   @level2name=N'Code'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Наименование работодателя',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Employers',
                                        @level2type=N'COLUMN',   @level2name=N'Name'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Адрес',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Employers',
                                        @level2type=N'COLUMN',   @level2name=N'Address'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Телефон',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Employers',
                                        @level2type=N'COLUMN',   @level2name=N'Phone'
    END

-- JobSeekers
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'JobSeekers')
    BEGIN
        CREATE TABLE dbo.JobSeekers
        (
            Code INT IDENTITY(1, 1) CONSTRAINT PK_JobSeekers PRIMARY KEY,
            LastName VARCHAR(60) NOT NULL,
            FirstName VARCHAR(60) NOT NULL,
            MiddleName VARCHAR(60) NOT NULL,
            WorkCategory INT NOT NULL CONSTRAINT FK_JobSeekers_WorkCategory FOREIGN KEY REFERENCES dbo.WorkCategories(Code) ON DELETE NO ACTION ON UPDATE NO ACTION INDEX Idx_WorkCategory NONCLUSTERED WITH (FILLFACTOR = 90),
            Qualification VARCHAR(60) NULL INDEX Idx_Qualification WITH (FILLFACTOR = 90),
            DesiredSalary MONEY NULL,
            Notes VARCHAR(120) NULL,
            INDEX Idx_Name NONCLUSTERED (LastName ASC, FirstName ASC, MiddleName ASC) WITH (FILLFACTOR = 90)
        )
        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Справочник соискателей',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'JobSeekers'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Код соискателя',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'JobSeekers',
                                        @level2type=N'COLUMN',   @level2name=N'Code'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Фамилия соискателя',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'JobSeekers',
                                        @level2type=N'COLUMN',   @level2name=N'LastName'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Имя соискателя',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'JobSeekers',
                                        @level2type=N'COLUMN',   @level2name=N'FirstName'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Отчество соискателя',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'JobSeekers',
                                        @level2type=N'COLUMN',   @level2name=N'MiddleName'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Вид деятельности',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'JobSeekers',
                                        @level2type=N'COLUMN',   @level2name=N'WorkCategory'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Квалификация',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'JobSeekers',
                                        @level2type=N'COLUMN',   @level2name=N'Qualification'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ожидаемый размер заработной платы',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'JobSeekers',
                                        @level2type=N'COLUMN',   @level2name=N'DesiredSalary'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Иные данные',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'JobSeekers',
                                        @level2type=N'COLUMN',   @level2name=N'Notes'
    END

-- Vacancies
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Vacancies')
    BEGIN
        CREATE TABLE dbo.Vacancies
        (
            Code INT IDENTITY (1, 1) CONSTRAINT PK_Vacancies PRIMARY KEY, 
            WorkCategory INT NOT NULL CONSTRAINT FK_Vacancies_WorkCategory FOREIGN KEY REFERENCES dbo.WorkCategories(Code) ON DELETE NO ACTION ON UPDATE NO ACTION INDEX Idx_WorkCategory NONCLUSTERED WITH (FILLFACTOR = 90),
            Position VARCHAR(60) NOT NULL INDEX Idx_Position NONCLUSTERED WITH (FILLFACTOR = 90),
            Salary MONEY NULL,
            Employer INT NOT NULL CONSTRAINT FK_Vacancies_Employer FOREIGN KEY REFERENCES dbo.Employers(Code) ON DELETE NO ACTION ON UPDATE NO ACTION INDEX Idx_Employer NONCLUSTERED WITH (FILLFACTOR = 90)
        )
        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Справочник вакансий',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Vacancies'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Код вакансии',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Vacancies',
                                        @level2type=N'COLUMN',   @level2name=N'Code'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Вид деятельности',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Vacancies',
                                        @level2type=N'COLUMN',   @level2name=N'WorkCategory'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Должность',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Vacancies',
                                        @level2type=N'COLUMN',   @level2name=N'Position'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Размер заработной платы',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Vacancies',
                                        @level2type=N'COLUMN',   @level2name=N'Salary'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Работодатель',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Vacancies',
                                        @level2type=N'COLUMN',   @level2name=N'Employer'
    END

-- Deals
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Deals')
    BEGIN
        CREATE TABLE dbo.Deals
        (
            Code INT IDENTITY (1, 1) CONSTRAINT PK_Deals PRIMARY KEY,
            JobSeeker INT NOT NULL CONSTRAINT FK_Deals_JobSeeker FOREIGN KEY REFERENCES dbo.JobSeekers(Code) ON DELETE NO ACTION ON UPDATE NO ACTION INDEX Idx_JobSeeker NONCLUSTERED WITH (FILLFACTOR = 90),
            Vacancy INT NOT NULL CONSTRAINT FK_Deals_Vacancy FOREIGN KEY REFERENCES dbo.Vacancies(Code) ON DELETE NO ACTION ON UPDATE NO ACTION INDEX Idx_Vacancy NONCLUSTERED WITH (FILLFACTOR = 90),
            Commission MONEY NOT NULL,
            DateClosed DATETIME2 NOT NULL INDEX Idx_Date NONCLUSTERED WITH (FILLFACTOR = 90)
        )
        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Журнал сделок',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Deals'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Код сделки',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Deals',
                                        @level2type=N'COLUMN',   @level2name=N'Code'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Соискатель',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Deals',
                                        @level2type=N'COLUMN',   @level2name=N'JobSeeker'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Вакансия',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Deals',
                                        @level2type=N'COLUMN',   @level2name=N'Vacancy'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Размер комиссионного вознаграждения',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Deals',
                                        @level2type=N'COLUMN',   @level2name=N'Commission'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Дата совершения сделки',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Deals',
                                        @level2type=N'COLUMN',   @level2name=N'DateClosed'
    END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Roles')
    BEGIN
        CREATE TABLE dbo.Roles
        (
            Code INT IDENTITY(1, 1) CONSTRAINT PK_Roles PRIMARY KEY,
            Name VARCHAR(64) NOT NULL,
            AccessControl INT NOT NULL
        )
        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Журнал ролей',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Roles'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Код роли',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Roles',
                                        @level2type=N'COLUMN',   @level2name=N'Code'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Имя роли',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Roles',
                                        @level2type=N'COLUMN',   @level2name=N'Name'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Права доступа',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Roles',
                                        @level2type=N'COLUMN',   @level2name=N'AccessControl'
    END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Users')
    BEGIN
        CREATE TABLE dbo.Users
        (
            Code INT IDENTITY(1, 1) CONSTRAINT PK_Users PRIMARY KEY,
            UserName VARCHAR(64) NOT NULL INDEX Idx_UserName NONCLUSTERED WITH (FILLFACTOR = 90),
            PasswordHash CHAR(128) NOT NULL,
            Role INT NOT NULL CONSTRAINT FK_Users_Role FOREIGN KEY REFERENCES Roles (Code) ON DELETE NO ACTION ON UPDATE NO ACTION,
            Enabled BIT NOT NULL
        )
        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Журнал пользователей',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Users'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Код пользователя',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Users',
                                        @level2type=N'COLUMN',   @level2name=N'Code'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Имя пользователя',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Users',
                                        @level2type=N'COLUMN',   @level2name=N'UserName'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Хэш пароля пользователя',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Users',
                                        @level2type=N'COLUMN',   @level2name=N'PasswordHash'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Код роли',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Users',
                                        @level2type=N'COLUMN',   @level2name=N'Role'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Активность учетной записи',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Users',
                                        @level2type=N'COLUMN',   @level2name=N'Enabled'
    END
