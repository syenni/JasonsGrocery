CREATE OR ALTER PROCEDURE Stores.CreateEmployee
   @PositionName NVARCHAR(32),
   @DepartmentName NVARCHAR(64),
   @HourlyPay FLOAT,
   @EmployeeName NVARCHAR(128),
   @EmployeeID INT OUTPUT
AS

INSERT Stores.Employee(DepartmentID, WorkPositionID, HourlyPay, EmployeeName)
SELECT D.DepartmentID, WP.WorkPositionID, Emp.HourlyPay, Emp.EmployeeName
FROM 
	(
		VALUES	
			(@PositionName, @DepartmentName, @HourlyPay , @EmployeeName)
	)Emp(PositionName, DepartmentName, HourlyPay, EmployeeName)
	INNER JOIN Stores.Department D ON D.DepartmentName = Emp.DepartmentName
	INNER JOIN Stores.WorkPosition WP ON WP.PositionName = Emp.PositionName;

SET @EmployeeID = SCOPE_IDENTITY();
GO


