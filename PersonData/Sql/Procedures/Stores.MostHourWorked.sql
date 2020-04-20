--4R: list of employees who worked most hours in specific month
SELECT E.EmployeeName, 
	SUM(DATEDIFF(
		HOUR,
		TE.ClockIn,
		TE.ClockOut
	)) AS HoursWorked
FROM Stores.Employee E
	INNER JOIN Stores.TimeEntry TE ON TE.EmployeeID = E.EmployeeID
WHERE MONTH(TE.ClockIn) = 04
GROUP BY E.EmployeeName;