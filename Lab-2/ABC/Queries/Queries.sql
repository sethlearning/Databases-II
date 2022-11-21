USE ABCCompany
GO

-- Task 1
SELECT LastName, FirstNme, DeptName
FROM Employee, Department
WHERE Employee.WorkDept = Department.DeptNo
ORDER BY DeptName, LastName, FirstNme

-- Task 2
SELECT DISTINCT P.ProjNo, P.ProjName, EPA.ActNo
FROM Project AS P, EmpProjAct AS EPA
WHERE P.ProjNo LIKE 'PP%' AND P.ProjNo = EPA.ProjNo
ORDER BY P.ProjNo, EPA.ActNo

-- Task 3
SELECT EPA.ActNo, D.MgrNo, EPA.EmStDate, EPA.ProjNo, E.LastName
FROM EmpProjAct AS EPA, Employee AS E, Project AS P, Department AS D
WHERE EmStDate >= '04/01/2022' AND
      EPA.EmpNo = E.EmpNo AND
      EPA.ProjNo = P.ProjNo AND
      P.DeptNo = D.DeptNo
ORDER BY EPA.ActNo, EPA.EmStDate