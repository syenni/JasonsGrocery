CREATE OR ALTER PROCEDURE Stores.CreateEmployee
   @EmployeeName NVARCHAR(128),
   @WorkPositionID INT,
   @DepartmentID INT,
   @HourlyPay FLOAT,
   @EmployeeID INT OUTPUT
AS

INSERT Stores.Employee(DepartmentID, WorkPositionID, HourlyPay, EmployeeName)
VALUES(@DepartmentID, @WorkPositionID, @HourlyPay, @EmployeeName);

SET @EmployeeID = SCOPE_IDENTITY();
GO
