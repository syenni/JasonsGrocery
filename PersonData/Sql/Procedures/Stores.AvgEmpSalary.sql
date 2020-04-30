--1R: Average Employee Salary for department....logic in C#
CREATE OR ALTER PROCEDURE Stores.AvgEmpSalary
	@PositionName NVARCHAR(32)
AS
--DECLARE @PositionName NVARCHAR(32) = N'Manager';
WITH AVGCTE(EmployeeID, PositionName, HourlyPay) AS
	(
		SELECT E.EmployeeID, WP.PositionName, E.HourlyPay
		FROM Stores.Employee E
			INNER JOIN Stores.WorkPosition WP ON WP.WorkPositionID = E.WorkPositionID
		WHERE WP.PositionName = @PositionName
		GROUP BY E.EmployeeID, WP.PositionName, E.HourlyPay
	)
SELECT DISTINCT AC.PositionName,
	AVG(AC.HourlyPay) OVER(
		PARTITION BY AC.EmployeeID
	) AS AverageEmployeePay
FROM AVGCTE AC
GROUP BY AC.PositionName, AC.EmployeeID, AC.HourlyPay
ORDER BY PositionName ASC;