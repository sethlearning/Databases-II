USE ABCCompany
GO

IF OBJECT_ID('dbo.Employee') IS NOT NULL
    INSERT INTO dbo.Employee(EmpNo, FirstNme, MidInit, LastName, WorkDept, PhoneNo, HireDate, Job, EdLevel, Sex, Birthdate, Salary, Bonus, Comm)
        VALUES ('ABC000' ,'John', 'S', 'Smith', NULL, '0001', '01/01/2000', 'Sr. Mgr', 5, 0, '01/01/1969', 200000, 10000, 20000),
               ('ABC999' ,'Jason', 'T', 'Smith', NULL, '0001', '01/01/2000', 'Sr. Mgr', 5, 0, '01/01/1969', 200000, 10000, 20000),
               ('ABC001' ,'James', 'A', 'Jefferson', NULL, '1001', '01/10/2002', 'Manager', 5, 0, '01/01/1970', 100000, 5000, 10000),
               ('ABC002' ,'Sybil', 'B', 'Johnson', NULL, '1002', '02/11/2003', 'Manager', 5, 1, '02/02/1980', 90000, 5000, 9000),
               ('ABC003' ,'Salvatore', 'C', 'Marino', NULL, '1003', '03/12/2004', 'Manager', 5, 0, '03/03/1975', 100000, 5000, 10000),
               ('ABC004' ,'Maria', 'D', 'Perez', NULL, '1004', '04/13/2005', 'Manager', 5, 1, '04/04/1976', 80000, 4000, 8000),
               ('ABC005' ,'Eva', 'E', 'Pulaski', NULL, '1005', '05/14/2006', 'Manager', 5, 1, '05/05/1977', 100000, 5000, 10000),
               ('ABC006' ,'Daniel', 'F', 'Smith', NULL, '1006', '06/15/2007', 'Manager', 5, 0, '06/06/1978', 110000, 5000, 11000),
               ('ABC007' ,'Sally', 'G', 'Kwan', NULL, '2001', '07/16/2008', 'Manager', 5, 0, '07/07/1979', 90000, 5000, 9000),
               ('ABC008' ,'Heather', 'H', 'Nicholls', NULL, '2002', '08/17/2009', 'Manager', 5, 1, '08/08/1980', 90000, 5000, 9000),
               ('ABC009' ,'Dolores', 'I', 'Quintana', NULL, '2003', '09/18/2010', 'Manager', 5, 1, '09/09/1982', 95000, 5000, 10000),
               ('ABC010' ,'Bruce', 'J', 'Adamson', NULL, '3001', '10/20/2011', 'Manager', 5, 0, '10/10/1983', 110000, 5000, 11000),
               ('ABC011' ,'David', 'K', 'Brown', NULL, '3002', '11/12/2012', 'Manager', 5, 0, '11/11/1984', 105000, 5000, 15000)

SELECT * FROM dbo.Employee

IF OBJECT_ID('dbo.Department') IS NOT NULL
    INSERT INTO dbo.Department (DeptNo, DeptName, MgrNo, AdmRDept, Location)
        VALUES ('D00', 'Head Department', 'ABC000', NULL, 'XXXXX'),
               ('D01', 'Administration Systems', 'ABC001', 'D00', 'Bld01'),
               ('D02', 'Information Center', 'ABC007', 'D00', 'Bld02'),
               ('D03', 'Manufacturing Systems', 'ABC010', 'D00', 'Bld03')

SELECT * FROM dbo.Department

UPDATE dbo.Employee SET WorkDept = 'D00' WHERE EmpNo IN ('ABC000', 'ABC999')
UPDATE dbo.Employee SET WorkDept = 'D01' WHERE EmpNo IN ('ABC001', 'ABC002', 'ABC003', 'ABC004', 'ABC005', 'ABC006')
UPDATE dbo.Employee SET WorkDept = 'D02' WHERE EmpNo IN ('ABC007', 'ABC008', 'ABC009')
UPDATE dbo.Employee SET WorkDept = 'D03' WHERE EmpNo IN ('ABC010', 'ABC011')


IF OBJECT_ID('dbo.Project') IS NOT NULL
    INSERT INTO dbo.Project (ProjNo, ProjName, DeptNo, RespEmp, PrStaff, PrStDate, PrEnDate, MajProj)
        VALUES ('AS3100', 'Admin services', 'D01', 'ABC001', 0.5, '01/01/2022', '12/31/2022', NULL),
               ('GAS310', 'General AD systems', 'D01', 'ABC002', 0.25, '02/02/2022', '11/30/2022', NULL),
               ('PP3100', 'Payroll programming', 'D02', 'ABC007', 0.9, '03/03/2022', '10/31/2022', NULL),
               ('PP3200', 'Personnel programming', 'D03', 'ABC010', 0.85, '04/04/2022', '09/30/2022', NULL)

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
        VALUES ('ABC001', 'AS3100', 1, 0.2, '01/01/2022', '01/31/2022'),
               ('ABC002', 'AS3100', 2, 0.2, '02/01/2022', '02/28/2022'),
               ('ABC003', 'AS3100', 3, 0.2, '03/01/2022', '03/31/2022'),
               ('ABC004', 'AS3100', 4, 0.2, '04/01/2022', '04/30/2022'),
               ('ABC005', 'AS3100', 5, 0.2, '05/01/2022', '05/03/2022'),
               ('ABC006', 'GAS310', 4, 0.8, '02/02/2022', '06/30/2022'),
               ('ABC001', 'GAS310', 5, 0.2, '07/01/2022', '07/31/2022'),
               ('ABC007', 'PP3100', 1, 0.4, '03/03/2022', '03/31/2022'),
               ('ABC008', 'PP3100', 2, 0.4, '04/01/2022', '04/30/2022'),
               ('ABC009', 'PP3100', 3, 0.2, '05/01/2022', '05/31/2022'),
               ('ABC010', 'PP3200', 5, 0.8, '04/04/2022', '04/30/2022'),
               ('ABC011', 'PP3200', 5, 0.8, '04/14/2022', '04/30/2022'),
               ('ABC011', 'PP3200', 6, 0.2, '05/01/2022', '05/31/2022')

SELECT * FROM dbo.EmpProjAct