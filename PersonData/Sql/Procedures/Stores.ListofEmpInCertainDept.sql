--1Q: I want to see all of the employees in certain department
CREATE OR ALTER PROCEDURE Stores.ListofEmpInCertainDept
   @DepartmentName NVARCHAR(32)
AS
SELECT D.DepartmentName, E.EmployeeName
FROM Stores.Department D
	INNER JOIN Stores.Employee E ON E.DepartmentID = D.DepartmentID
WHERE D.DepartmentName = @DepartmentName
ORDER BY E.EmployeeName ASC;