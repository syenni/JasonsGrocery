--1R: Average Employee Salary for department....logic in C#
CREATE OR ALTER PROCEDURE Stores.AvgEmpSalary
	@PositionName NVARCHAR(32)
AS
--DECLARE @PositionName NVARCHAR(32) = N'Manager';
WITH AVGCTE(EmployeeID, DepartmentName, WorkPosition, HourlyPay) AS
	(
		SELECT E.EmployeeID, D.DepartmentName, WP.PositionName, E.HourlyPay
		FROM Stores.Store S
			INNER JOIN Stores.Department D ON D.StoreID = S.StoreID
			INNER JOIN Stores.Employee E ON E.DepartmentID = D.DepartmentID
			INNER JOIN Stores.WorkPosition WP ON WP.WorkPositionID = E.WorkPositionID
	)
SELECT AC.DepartmentName, AC.WorkPosition,
	AVG(AC.HourlyPay) OVER(
		PARTITION BY AC.EmployeeID
	) AS AverageEmployeePay
FROM AVGCTE AC
--WHERE @PositionName = AC.WorkPosition
WHERE AC.WorkPosition = @PositionName
ORDER BY WorkPosition ASC;