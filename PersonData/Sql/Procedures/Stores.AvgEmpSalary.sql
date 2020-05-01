--1R: Average Employee Salary for department....logic in C#
CREATE OR ALTER PROCEDURE Stores.AvgEmpSalary
AS
--DECLARE @PositionName NVARCHAR(32) = N'Manager';
WITH AVGCTE(EmployeeID, PositionName, AverageEmployeePay) AS
	(
		SELECT E.EmployeeID, WP.PositionName, 
			AVG(E.HourlyPay) OVER(
				PARTITION BY WP.PositionName
			) AS AverageEmployeePay
		FROM Stores.Employee E
			INNER JOIN Stores.WorkPosition WP ON WP.WorkPositionID = E.WorkPositionID
		GROUP BY E.EmployeeID, WP.PositionName, E.HourlyPay
	)
SELECT DISTINCT AC.PositionName,
	ROUND(AC.AverageEmployeePay, 2) AS AverageHourlyPay
FROM AVGCTE AC
GROUP BY AC.PositionName, AC.AverageEmployeePay
ORDER BY PositionName ASC;