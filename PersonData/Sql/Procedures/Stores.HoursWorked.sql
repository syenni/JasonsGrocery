--4R: list of employees who worked most hours in specific month
CREATE OR ALTER PROCEDURE Stores.HoursWorked
   @EmployeeID INT,
   @Month DATETIME
AS
SELECT E.EmployeeName, 
	SUM(DATEDIFF(
		HOUR,
		TE.ClockIn,
		TE.ClockOut
	)) AS HoursWorked
FROM Stores.Employee E
	INNER JOIN Stores.TimeEntry TE ON TE.EmployeeID = E.EmployeeID
WHERE MONTH(TE.ClockIn) = @Month AND E.EmployeeID = @EmployeeID
GROUP BY E.EmployeeName;