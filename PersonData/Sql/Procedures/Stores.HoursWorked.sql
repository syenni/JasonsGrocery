--4R: list of employees who worked most hours in specific month
CREATE OR ALTER PROCEDURE Stores.HoursWorked
   @SelectedDate DATE
AS
SELECT DISTINCT E.EmployeeName, 
		SUM(DATEDIFF(
				HOUR,
				TE.ClockIn,
				TE.ClockOut
			)) 
		OVER(
			PARTITION BY TE.EmployeeID
	)AS HoursWorked
FROM Stores.TimeEntry TE
	RIGHT JOIN Stores.Employee E ON E.EmployeeID = TE.EmployeeID
WHERE YEAR(TE.ClockIn) = YEAR(@SelectedDate) AND MONTH(TE.ClockIn) = MONTH(@SelectedDate)
GROUP BY E.EmployeeName, TE.EmployeeID, TE.ClockIn, TE.ClockOut
ORDER BY HoursWorked DESC;