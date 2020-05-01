

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
			(N'Jason Byrne', @ClockIn2, @ClockOut2),
			(N'Kate Upton', '2020-04-14 08:30:00', '2020-04-14 08:30:00'),
			(N'Kate Upton', '2020-04-15 08:30:00', '2020-04-15 08:30:00'),
			(N'Kate Upton', '2020-04-16 08:30:00', '2020-04-16 08:30:00'),
			(N'Kate Upton', '2020-04-17 08:30:00', '2020-04-17 08:30:00'),
			(N'Kate Upton', '2020-04-18 08:30:00', '2020-04-18 08:30:00')
			
	) T(EmployeeName, ClockIn, ClockOut)
	INNER JOIN Stores.Employee E ON E.EmployeeName = T.EmployeeName;

	INSERT Stores.TimeEntry(EmployeeID, ClockIn, ClockOut)
SELECT E.EmployeeID, T.ClockIn, T.ClockOut
FROM 
	(
		VALUES
			(N'Jason Byrne', @ClockIn2, @ClockOut2),
			(N'Kate Upton', '2020-04-14 08:30:00', '2020-04-14 08:30:00'),
			(N'Kate Upton', '2020-04-15 08:30:00', '2020-04-15 08:30:00'),
			(N'Kate Upton', '2020-04-16 08:30:00', '2020-04-16 08:30:00'),
			(N'Kate Upton', '2020-04-17 08:30:00', '2020-04-17 08:30:00'),
			(N'Kate Upton', '2020-04-18 08:30:00', '2020-04-18 08:30:00')
			
	) T(EmployeeName, ClockIn, ClockOut)
	INNER JOIN Stores.Employee E ON E.EmployeeName = T.EmployeeName;

	INSERT Stores.TimeEntry(EmployeeID, ClockIn, ClockOut)
SELECT E.EmployeeID, T.ClockIn, T.ClockOut
FROM 
	(
		VALUES
			(N'Ben Hartman', '2020-04-01 08:30:00', '2020-04-01 18:30:00'),
			(N'Ben Hartman', '2020-03-01 08:30:00', '2020-04-01 18:30:00'),
			(N'Ben Hartman', '2020-04-15 09:45:00', '2020-04-15 17:30:00'),
			(N'Ben Hartman', '2020-03-10 08:45:00', '2020-03-10 15:30:00'),
			(N'Ben Hartman', '2020-03-30 11:30:00', '2020-03-30 12:30:00'),
			(N'Ben Hartman', '2020-04-03 11:30:00', '2020-04-03 15:30:00'),
			(N'Ben Hartman', '2020-04-10 11:30:00', '2020-04-10 18:45:00'),
			(N'Robert Downey Jr', '2020-04-05 09:30:00', '2020-04-05 14:30:00'),
			(N'Robert Downey Jr', '2020-04-08 09:45:00', '2020-04-08 14:15:00'),
			(N'Robert Downey Jr', '2020-03-08 09:45:00', '2020-03-08 14:15:00'),
			(N'Robert Downey Jr', '2020-03-10 09:45:00', '2020-03-10 14:15:00'),
			(N'Robert Downey Jr', '2020-03-31 07:45:00', '2020-03-31 12:15:00'),
			(N'Robert Downey Jr', '2020-04-28 07:45:00', '2020-04-28 14:15:00'),
			(N'Robert Downey Jr', '2020-04-13 11:45:00', '2020-04-13 19:15:00'),
			(N'Dave Chappelle', '2020-04-10 10:30:00', '2020-04-10 20:45:00'),
			(N'Dave Chappelle', '2020-03-08 11:30:00', '2020-03-08 15:45:00'),
			(N'Dave Chappelle', '2020-03-11 11:30:00', '2020-03-11 15:45:00'),
			(N'Dave Chappelle', '2020-03-15 09:30:00', '2020-03-15 15:45:00'),
			(N'Dave Chappelle', '2020-04-15 10:30:00', '2020-04-15 17:45:00'),
			(N'Dave Chappelle', '2020-04-12 10:30:00', '2020-04-12 17:45:00'),
			(N'Dave Chappelle', '2020-04-20 10:00:00', '2020-04-20 15:45:00'),
			(N'Dave Chappelle', '2020-03-18 09:30:00', '2020-03-18 16:45:00'),
			(N'Dave Chappelle', '2020-04-01 10:15:00', '2020-04-01 17:15:00'),
			(N'Kevin Hart', '2020-04-13 09:00:00', '2020-04-13 19:30:00'),
			(N'Kevin Hart', '2020-04-21 09:00:00', '2020-04-21 16:30:00'),
			(N'Kevin Hart', '2020-03-21 09:00:00', '2020-03-21 16:30:00'),
			(N'Kevin Hart', '2020-03-14 09:00:00', '2020-03-14 16:30:00'),
			(N'Kevin Hart', '2020-03-02 09:00:00', '2020-03-02 16:30:00'),
			(N'Kevin Hart', '2020-04-02 08:00:00', '2020-04-02 14:30:00'),
			(N'Kevin Hart', '2020-04-08 09:00:00', '2020-04-08 19:30:00'),
			(N'Kevin Hart', '2020-04-10 09:00:00', '2020-04-10 16:30:00'),
			(N'Kevin Hart', '2020-03-08 08:00:00', '2020-03-08 17:00:00'),
			(N'Kevin Hart', '2020-04-18 09:15:00', '2020-04-18 19:30:00'),
			(N'David Hasselhoff', '2020-03-15 07:30:00', '2020-03-15 22:30:00'),
			(N'David Hasselhoff', '2020-04-15 08:30:00', '2020-04-15 20:30:00'),
			(N'David Hasselhoff', '2020-03-01 07:30:00', '2020-03-01 23:30:00'),
			(N'David Hasselhoff', '2020-03-02 08:00:00', '2020-03-02 22:30:00'),
			(N'David Hasselhoff', '2020-03-03 08:00:00', '2020-03-03 23:30:00'),
			(N'David Hasselhoff', '2020-03-04 07:00:00', '2020-03-04 22:45:00'),
			(N'David Hasselhoff', '2020-03-05 07:00:00', '2020-03-05 22:45:00'),
			(N'David Hasselhoff', '2020-03-06 07:00:00', '2020-03-06 22:45:00'),
			(N'David Hasselhoff', '2020-03-07 07:00:00', '2020-03-07 23:45:00'),
			(N'David Hasselhoff', '2020-03-08 07:00:00', '2020-03-08 23:45:00'),
			(N'David Hasselhoff', '2020-03-09 07:00:00', '2020-03-09 23:45:00'),
			(N'Drake', '2020-03-25 09:15:00', '2020-03-25 10:00:00'),	
			(N'Drake', '2020-04-25 09:15:00', '2020-04-25 09:45:00'),
			(N'Drake', '2020-04-01 09:15:00', '2020-04-01 09:20:00'),
			(N'Drake', '2020-03-01 13:15:00', '2020-03-01 14:00:00'),
			(N'Drake', '2020-03-10 11:15:00', '2020-03-10 11:45:00')

	) T(EmployeeName, ClockIn, ClockOut)
	INNER JOIN Stores.Employee E ON E.EmployeeName = T.EmployeeName;