USE ABCCompany
GO

IF OBJECT_ID('dbo.Employee') IS NOT NULL
    INSERT INTO dbo.Employee(EmpNo, FirstNme, MidInit, LastName, WorkDept, PhoneNo, HireDate, Job, EdLevel, Sex, Birthdate, Salary, Bonus, Comm)
        VALUES ('ABC000' ,'John', 'S', 'Smith', 'D00', '0001', '01/01/2000', 'Top Manager', 5, 0, '01/01/1969', 200000, 10000, 20000),
               ('ABC001' ,'James', 'A', 'Jefferson', 'D01', '1001', '01/10/2002', 'Manager', 5, 0, '01/01/1970', 100000, 5000, 10000),
               ('ABC002' ,'Sybil', 'B', 'Johnson', 'D01', '1002', '02/11/2003', 'Manager', 5, 1, '02/02/1980', 90000, 5000, 9000),
               ('ABC003' ,'Salvatore', 'C', 'Marino', 'D01', '1003', '03/12/2004', 'Manager', 5, 0, '03/03/1975', 100000, 5000, 10000),
               ('ABC004' ,'Maria', 'D', 'Perez', 'D01', '1004', '04/13/2005', 'Manager', 5, 1, '04/04/1976', 80000, 4000, 8000),
               ('ABC005' ,'Eva', 'E', 'Pulaski', 'D01', '1005', '05/14/2006', 'Manager', 5, 1, '05/05/1977', 100000, 5000, 10000),
               ('ABC006' ,'Daniel', 'F', 'Smith', 'D01', '1006', '06/15/2007', 'Manager', 5, 0, '06/06/1978', 110000, 5000, 11000),
               ('ABC007' ,'Sally', 'G', 'Kwan', 'D02', '2001', '07/16/2008', 'Manager', 5, 0, '07/07/1979', 90000, 5000, 9000),
               ('ABC008' ,'Heather', 'H', 'Nicholls', 'D02', '2002', '08/17/2009', 'Manager', 5, 1, '08/08/1980', 90000, 5000, 9000),
               ('ABC009' ,'Dolores', 'I', 'Quintana', 'D02', '2003', '09/18/2010', 'Manager', 5, 1, '09/09/1982', 95000, 5000, 10000),
               ('ABC010' ,'Bruce', 'J', 'Adamson', 'D03', '3001', '10/20/2011', 'Manager', 5, 0, '10/10/1983', 110000, 5000, 11000),
               ('ABC011' ,'David', 'K', 'Brown', 'D03', '3002', '11/12/2012', 'Manager', 5, 0, '11/11/1984', 105000, 5000, 15000)

SELECT * FROM dbo.Employee

IF OBJECT_ID('dbo.Department') IS NOT NULL
    INSERT INTO dbo.Department (DeptNo, DeptName, MgrNo, AdmRDept, Location)
        VALUES ('D00', 'Head Department', 'ABC000', NULL, 'XXXXX'),
               ('D01', 'Administration Systems', 'ABC001', 'D00', 'Bld01'),
               ('D02', 'Information Center', 'ABC007', 'D00', 'Bld02'),
               ('D03', 'Manufacturing Systems', 'ABC010', 'D00', 'Bld03')

SELECT * FROM dbo.Department

IF OBJECT_ID('dbo.Project') IS NOT NULL
    INSERT INTO dbo.Project (ProjNo, ProjName, DeptNo, RespEmp, PrStaff, PrStDate, PrEnDate, MajProj)
        VALUES ('AS3100', 'Admin services', 'D01', 'ABC001', 0.5, '01/01/2022', '12/31/2022', NULL),
               ('GAS310', 'General AD systems', 'D01', 'ABC002', 0.25, '02/02/2022', '11/31/2022', NULL),
               ('PP3100', 'Payroll programming', 'D02', 'ABC007', 0.9, '03/03/2022', '10/31/2022', NULL),
               ('PP3200', 'Personnel programming', 'D03', 'ABC010', 0.85, '04/04/2022', '09/31/2022', NULL)

SELECT * FROM dbo.Project

IF OBJECT_ID('dbo.Act') IS NOT NULL
    INSERT INTO dbo.Act (ActNo, ActWD, ActDesc)
        VALUES (1, 2, 'Prepare'),
               (2, 3, 'Supply'),
               (3, 4, 'Develop'),
               (4, 5, 'Build'),
               (5, 4, 'Test'),
               (6, 3, 'QA')

SELECT * FROM dbo.Act

IF OBJECT_ID('dbo.EmpProjAct') IS NOT NULL
    INSERT INTO dbo.EmpProjAct (EmpNo, ProjNo, ActNo, EmPTime, EmStDate, EmEnDate)
        VALUES (1, '01/31/2022', 10, 0, 10.05, 30),
               (2, '02/28/2022', 9, 1, 11.03, 3),
               (3, '03/27/2022', 8, 0, 8.51, 40),
               (4, '04/26/2022', 7, 1, 7.49, 4),
               (5, '05/25/2022', 6, 0, 10.25, 25),
               (6, '06/24/2022', 5, 1, 11.24, 5),
               (7, '07/23/2022', 4, 0, 5.15, 18),
               (8, '08/22/2022', 3, 1, 3.21, 4),
               (9, '09/21/2022', 2, 0, 8.52, 15),
               (10, '10/20/2022', 1, 1, 10, 3)
    
SELECT * FROM dbo.EmpProjAct