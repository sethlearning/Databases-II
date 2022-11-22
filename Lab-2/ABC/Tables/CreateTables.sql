USE ABCCompany
GO

-- Employee table
IF OBJECT_ID('dbo.Employee') IS NULL
    BEGIN
        CREATE TABLE dbo.Employee
        (
            EmpNo CHAR(6) PRIMARY KEY,
            FirstNme VARCHAR(20) NOT NULL,
            MidInit CHAR(1) NOT NULL,
            LastName VARCHAR(15) NOT NULL
        )

    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Справочник сотрудников',
                                    @level0type=N'SCHEMA',   @level0name=N'dbo',
                                    @level1type=N'TABLE',    @level1name=N'Employee'

    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Номер сотрудника',
                                    @level0type=N'SCHEMA',   @level0name=N'dbo',
                                    @level1type=N'TABLE',    @level1name=N'Employee',
                                    @level2type=N'COLUMN',   @level2name=N'EmpNo'

    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Имя сотрудника',
                                    @level0type=N'SCHEMA',   @level0name=N'dbo',
                                    @level1type=N'TABLE',    @level1name=N'Employee',
                                    @level2type=N'COLUMN',   @level2name=N'FirstNme'

    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Первая буква отчества сотрудника',
                                    @level0type=N'SCHEMA',   @level0name=N'dbo',
                                    @level1type=N'TABLE',    @level1name=N'Employee',
                                    @level2type=N'COLUMN',   @level2name=N'MidInit'

    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Фамилия сотрудника',
                                    @level0type=N'SCHEMA',   @level0name=N'dbo',
                                    @level1type=N'TABLE',    @level1name=N'Employee',
                                    @level2type=N'COLUMN',   @level2name=N'LastName'
    END
ELSE
    PRINT('Employee table already exists.')

-- Department table
IF OBJECT_ID('dbo.Department') IS NULL
    BEGIN
        CREATE TABLE dbo.Department
        (
            DeptNo CHAR(3) PRIMARY KEY,
            DeptName VARCHAR(36) NOT NULL,
            MgrNo CHAR(6) NOT NULL FOREIGN KEY REFERENCES Employee (EmpNo),
            AdmRDept CHAR(3) NULL FOREIGN KEY REFERENCES Department (DeptNo),
            Location CHAR(5) NULL
        )
        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Справочник департаментов',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Department'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Номер департамента',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Department',
                                        @level2type=N'COLUMN',   @level2name=N'DeptNo'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Наименование департамента',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Department',
                                        @level2type=N'COLUMN',   @level2name=N'DeptName'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Номер сотрудника - менедера департамента',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Department',
                                        @level2type=N'COLUMN',   @level2name=N'MgrNo'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Номер департамента, которому данный департамент подотчетен',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Department',
                                        @level2type=N'COLUMN',   @level2name=N'AdmRDept'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Код места расположения департамента',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Department',
                                        @level2type=N'COLUMN',   @level2name=N'Location'
    END
ELSE
    PRINT('Department table already exists.')

-- Employee add
IF OBJECT_ID('dbo.Employee') IS NOT NULL
    BEGIN
        ALTER TABLE dbo.Employee ADD
            WorkDept CHAR(3) NULL FOREIGN KEY REFERENCES Department (DeptNo),
            PhoneNo CHAR(4) NULL,
            HireDate DATE NULL,
            Job CHAR(8) NULL,
            EdLevel SMALLINT NULL,
            Sex CHAR(1) NULL,
            Birthdate DATE NULL,
            Salary DECIMAL(9, 2) NULL,
            Bonus DECIMAL(9, 2) NULL,
            Comm DECIMAL(9, 2) NULL

    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Номер департамента сотрудника',
                                    @level0type=N'SCHEMA',   @level0name=N'dbo',
                                    @level1type=N'TABLE',    @level1name=N'Employee',
                                    @level2type=N'COLUMN',   @level2name=N'WorkDept'

    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Номер телефона',
                                    @level0type=N'SCHEMA',   @level0name=N'dbo',
                                    @level1type=N'TABLE',    @level1name=N'Employee',
                                    @level2type=N'COLUMN',   @level2name=N'PhoneNo'

    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Дата приема на работу в компанию',
                                    @level0type=N'SCHEMA',   @level0name=N'dbo',
                                    @level1type=N'TABLE',    @level1name=N'Employee',
                                    @level2type=N'COLUMN',   @level2name=N'HireDate'

    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Должность',
                                    @level0type=N'SCHEMA',   @level0name=N'dbo',
                                    @level1type=N'TABLE',    @level1name=N'Employee',
                                    @level2type=N'COLUMN',   @level2name=N'Job'

    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Количество лет образования',
                                    @level0type=N'SCHEMA',   @level0name=N'dbo',
                                    @level1type=N'TABLE',    @level1name=N'Employee',
                                    @level2type=N'COLUMN',   @level2name=N'EdLevel'

    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Пол сотрудника',
                                    @level0type=N'SCHEMA',   @level0name=N'dbo',
                                    @level1type=N'TABLE',    @level1name=N'Employee',
                                    @level2type=N'COLUMN',   @level2name=N'Sex'

    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Дата рождения',
                                    @level0type=N'SCHEMA',   @level0name=N'dbo',
                                    @level1type=N'TABLE',    @level1name=N'Employee',
                                    @level2type=N'COLUMN',   @level2name=N'Birthdate'

    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Оклад',
                                    @level0type=N'SCHEMA',   @level0name=N'dbo',
                                    @level1type=N'TABLE',    @level1name=N'Employee',
                                    @level2type=N'COLUMN',   @level2name=N'Salary'

    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Бонус (премия)',
                                    @level0type=N'SCHEMA',   @level0name=N'dbo',
                                    @level1type=N'TABLE',    @level1name=N'Employee',
                                    @level2type=N'COLUMN',   @level2name=N'Bonus'

    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ежегодные комиссионные',
                                    @level0type=N'SCHEMA',   @level0name=N'dbo',
                                    @level1type=N'TABLE',    @level1name=N'Employee',
                                    @level2type=N'COLUMN',   @level2name=N'Comm'
    END

-- Project table
IF OBJECT_ID('dbo.Project') IS NULL
    BEGIN
        CREATE TABLE dbo.Project
        (
            ProjNo CHAR(6) PRIMARY KEY,
            ProjName VARCHAR(24) NOT NULL,
            DeptNo CHAR(3) NOT NULL FOREIGN KEY REFERENCES Department (DeptNo),
            RespEmp CHAR(6) NOT NULL FOREIGN KEY REFERENCES Employee (EmpNo),
            PrStaff DECIMAL(5, 2) NULL,
            PrStDate DATE NULL,
            PrEnDate DATE NULL,
            MajProj CHAR(6) NULL FOREIGN KEY REFERENCES Project (ProjNo)
        )
        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Справочник проектов',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Project'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Номер проекта',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Project',
                                        @level2type=N'COLUMN',   @level2name=N'ProjNo'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Наименование проекта',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Project',
                                        @level2type=N'COLUMN',   @level2name=N'ProjName'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Департамент, отвечающий за проект',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Project',
                                        @level2type=N'COLUMN',   @level2name=N'DeptNo'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Номер сотрудника, отвечающего за проект',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Project',
                                        @level2type=N'COLUMN',   @level2name=N'RespEmp'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Средняя оценка кадрового обеспечения проекта',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Project',
                                        @level2type=N'COLUMN',   @level2name=N'PrStaff'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Предполагаемая дата начала проекта',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Project',
                                        @level2type=N'COLUMN',   @level2name=N'PrStDate'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Предполагаемая дата окончания проекта',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Project',
                                        @level2type=N'COLUMN',   @level2name=N'PrEnDate'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Проект, являющийся для данного проекта более старшим',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Project',
                                        @level2type=N'COLUMN',   @level2name=N'MajProj'
    END
ELSE
    PRINT('Project table already exists.')

-- Act table
IF OBJECT_ID('dbo.Act') IS NULL
    BEGIN
        CREATE TABLE dbo.Act
        (
            ActNo SMALLINT PRIMARY KEY,
            ActWD SMALLINT NOT NULL,
            ActDesc VARCHAR(24) NOT NULL
        )
        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Справочник активностей',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Act'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Номер активности',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Act',
                                        @level2type=N'COLUMN',   @level2name=N'ActNo'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Длительность',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Act',
                                        @level2type=N'COLUMN',   @level2name=N'ActWD'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Наименование',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Act',
                                        @level2type=N'COLUMN',   @level2name=N'ActDesc'
    END
ELSE
    PRINT('Act table already exists.')

-- EmpProjAct table
IF OBJECT_ID('dbo.EmpProjAct') IS NULL
    BEGIN
        CREATE TABLE dbo.EmpProjAct
        (
            Code INT IDENTITY(1, 1) PRIMARY KEY,
            EmpNo CHAR(6) NOT NULL FOREIGN KEY REFERENCES Employee (EmpNo),
            ProjNo CHAR(6) NOT NULL FOREIGN KEY REFERENCES Project (ProjNo),
            ActNo SMALLINT NOT NULL FOREIGN KEY REFERENCES Act (ActNo),
            EmPTime DECIMAL(5, 2) NULL,
            EmStDate DATE NULL,
            EmEnDate DATE NULL
        )
        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Журнал работы сотрудников над активностями',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'EmpProjAct'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ключ записи',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'EmpProjAct',
                                        @level2type=N'COLUMN',   @level2name=N'Code'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Номер сотрудника, выполняющего активность',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'EmpProjAct',
                                        @level2type=N'COLUMN',   @level2name=N'EmpNo'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Номер проекта, в рамках которого выполняется активность',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'EmpProjAct',
                                        @level2type=N'COLUMN',   @level2name=N'ProjNo'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Номер активности',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'EmpProjAct',
                                        @level2type=N'COLUMN',   @level2name=N'ActNo'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Какую часть от общего времени проекта составляет время выполнения активности',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'EmpProjAct',
                                        @level2type=N'COLUMN',   @level2name=N'EmPTime'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Дата начала активности',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'EmpProjAct',
                                        @level2type=N'COLUMN',   @level2name=N'EmStDate'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Дата окончания активности',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'EmpProjAct',
                                        @level2type=N'COLUMN',   @level2name=N'EmEnDate'
    END
ELSE
    PRINT('EmpProjAct table already exists.')

