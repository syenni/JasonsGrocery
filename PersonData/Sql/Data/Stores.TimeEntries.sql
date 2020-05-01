

/***************************** Modify values here *****************************/

--insert TimeEntry for employee Jason Byrne(wait to see how we want to test clocking out)....C#
DECLARE @ClockIn AS DATETIMEOFFSET = '2020-04-13 02:30:00',
		@ClockOut AS DATETIMEOFFSET = '2020-04-13 08:30:00';
INSERT Stores.TimeEntry(EmployeeID, ClockIn, ClockOut)
SELECT E.EmployeeID, T.ClockIn, T.ClockOut
FROM 
	(
		VALUES
			(N'Jason Byrne', @ClockIn, @ClockOut)
	) T(EmployeeName, ClockIn, ClockOut)
	INNER JOIN Stores.Employee E ON E.EmployeeName = T.EmployeeName;
/******************************************************************************/

--insert TimeEntry for employee Jason Byrne(wait to see how we want to test clocking out)....C#
DECLARE @ClockIn2 AS DATETIMEOFFSET = '2020-04-14 02:30:00',
		@ClockOut2 AS DATETIMEOFFSET = '2020-04-14 08:30:00';
INSERT Stores.TimeEntry(EmployeeID, ClockIn, ClockOut)
SELECT E.EmployeeID, T.ClockIn, T.ClockOut
FROM 
	(
		VALUES
			(N'Jason Byrne', @ClockIn2, @ClockOut2)
			(N'Kate Upton', '2020-04-14 08:30:00', '2020-04-14 08:30:00')
			(N'Kate Upton', '2020-04-15 08:30:00', '2020-04-15 08:30:00')
			(N'Kate Upton', '2020-04-16 08:30:00', '2020-04-16 08:30:00')
			(N'Kate Upton', '2020-04-17 08:30:00', '2020-04-17 08:30:00')
			(N'Kate Upton', '2020-04-18 08:30:00', '2020-04-18 08:30:00')
			
	) T(EmployeeName, ClockIn, ClockOut)
	INNER JOIN Stores.Employee E ON E.EmployeeName = T.EmployeeName;

	INSERT Stores.TimeEntry(EmployeeID, ClockIn, ClockOut)
SELECT E.EmployeeID, T.ClockIn, T.ClockOut
FROM 
	(
		VALUES
			(N'Jason Byrne', @ClockIn2, @ClockOut2)
			(N'Kate Upton', '2020-04-14 08:30:00', '2020-04-14 08:30:00')
			(N'Kate Upton', '2020-04-15 08:30:00', '2020-04-15 08:30:00')
			(N'Kate Upton', '2020-04-16 08:30:00', '2020-04-16 08:30:00')
			(N'Kate Upton', '2020-04-17 08:30:00', '2020-04-17 08:30:00')
			(N'Kate Upton', '2020-04-18 08:30:00', '2020-04-18 08:30:00')
			
	) T(EmployeeName, ClockIn, ClockOut)
	INNER JOIN Stores.Employee E ON E.EmployeeName = T.EmployeeName;

	INSERT Stores.TimeEntry(EmployeeID, ClockIn, ClockOut)
SELECT E.EmployeeID, T.ClockIn, T.ClockOut
FROM 
	(
		VALUES
			(N'Jason Byrne', @ClockIn2, @ClockOut2)
			(N'Kate Upton', '2020-04-14 08:30:00', '2020-04-14 08:30:00')
			(N'Kate Upton', '2020-04-15 08:30:00', '2020-04-15 08:30:00')
			(N'Kate Upton', '2020-04-16 08:30:00', '2020-04-16 08:30:00')
			(N'Kate Upton', '2020-04-17 08:30:00', '2020-04-17 08:30:00')
			(N'Kate Upton', '2020-04-18 08:30:00', '2020-04-18 08:30:00')
			
	) T(EmployeeName, ClockIn, ClockOut)
	INNER JOIN Stores.Employee E ON E.EmployeeName = T.EmployeeName;