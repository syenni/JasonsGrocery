--1Q: I want to see all of the employees in certain department
CREATE OR ALTER PROCEDURE Stores.ListofEmpInCertainDept
   @DepartmentID INT
AS
SELECT E.EmployeeID, E.EmployeeName, WP.PositionName
FROM Stores.Department D
	INNER JOIN Stores.Employee E ON E.DepartmentID = D.DepartmentID
	INNER JOIN Stores.WorkPosition WP ON WP.WorkPositionID = E.WorkPositionID
WHERE D.DepartmentID = @DepartmentID
ORDER BY E.EmployeeName ASC;