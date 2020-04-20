--6Q: I want to see the highest paid employees
SELECT D.DepartmentName, E.EmployeeName, WP.PositionName, WP.HourlyPay
FROM Stores.Department D
	INNER JOIN Stores.Employee E ON E.DepartmentID = D.DepartmentID
	INNER JOIN Stores.WorkPosition WP ON WP.WorkPositionID = E.WorkPositionID
ORDER BY WP.HourlyPay DESC;