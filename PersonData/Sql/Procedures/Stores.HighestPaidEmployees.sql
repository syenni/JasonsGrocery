--6Q: I want to see the highest paid employees
CREATE OR ALTER PROCEDURE Stores.HighestPaidEmployees
AS
SELECT D.DepartmentName, E.EmployeeName, WP.PositionName, E.HourlyPay
FROM Stores.Department D
	INNER JOIN Stores.Employee E ON E.DepartmentID = D.DepartmentID
	INNER JOIN Stores.WorkPosition WP ON WP.WorkPositionID = E.WorkPositionID
ORDER BY E.HourlyPay DESC;