﻿

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
			(N'Jason Byrne', '2020-03-03 08:30:00', '2020-03-03 08:30:00'),
			(N'Jason Byrne', '2020-03-08 06:30:00', '2020-03-08 12:20:00'),
			(N'Jason Byrne', '2020-03-13 07:20:00', '2020-03-13 13:45:00'),
			(N'Jason Byrne', '2020-03-15 06:30:00', '2020-03-15 12:20:00'),
			(N'Jason Byrne', '2020-03-19 12:30:00', '2020-03-19 16:15:00'),
			(N'Jason Byrne', '2020-03-30 06:20:00', '2020-03-30 12:45:00'),

			(N'Megan Fox', '2020-03-06 06:00:00', '2020-03-06 10:50:00'),
			(N'Megan Fox', '2020-03-08 08:20:00', '2020-03-08 14:50:00'),
			(N'Megan Fox', '2020-03-15 08:30:00', '2020-03-15 14:30:00'),
			(N'Megan Fox', '2020-03-20 09:30:00', '2020-03-20 14:45:00'),
			(N'Megan Fox', '2020-03-23 06:30:00', '2020-03-23 11:30:00'),
			(N'Megan Fox', '2020-03-30 08:20:00', '2020-03-30 12:50:00'),


			(N'Leonardo DiCaprio', '2020-03-01 09:50:00', '2020-03-01 14:40:00'),
			(N'Leonardo DiCaprio', '2020-03-09 08:20:00', '2020-03-09 14:50:00'),
			(N'Leonardo DiCaprio', '2020-03-10 06:30:00', '2020-03-10 16:20:00'),
			(N'Leonardo DiCaprio', '2020-03-20 09:30:00', '2020-03-20 14:45:00'),
			(N'Leonardo DiCaprio', '2020-03-28 11:30:00', '2020-03-28 16:45:00'),


			(N'Denzel Washington', '2020-03-01 08:20:00', '2020-03-01 16:20:00'),
			(N'Denzel Washington', '2020-03-17 06:20:00', '2020-03-17 10:30:00'),
			(N'Denzel Washington', '2020-03-31 08:20:00', '2020-03-31 17:50:00'),


			(N'Derrick Rose', '2020-03-01 06:20:00', '2020-03-01 12:40:00'),
			(N'Derrick Rose', '2020-03-02 08:20:00', '2020-03-02 16:40:00'),
			(N'Derrick Rose', '2020-03-03 10:20:00', '2020-03-03 18:30:00'),
			(N'Derrick Rose', '2020-03-04 06:20:00', '2020-03-04 14:40:00'),
			(N'Derrick Rose', '2020-03-05 12:20:00', '2020-03-05 18:40:00'),
			(N'Derrick Rose', '2020-03-08 06:30:00', '2020-03-08 18:45:00'),
			(N'Derrick Rose', '2020-03-09 15:20:00', '2020-03-09 20:40:00'),
			(N'Derrick Rose', '2020-03-10 06:45:00', '2020-03-10 15:40:00'),
			(N'Derrick Rose', '2020-03-12 12:50:00', '2020-03-12 18:10:00'),
			(N'Derrick Rose', '2020-03-13 06:20:00', '2020-03-13 12:50:00'),
			(N'Derrick Rose', '2020-03-14 06:20:00', '2020-03-14 12:40:00'),
			(N'Derrick Rose', '2020-03-15 06:15:00', '2020-03-15 12:40:00'),
			(N'Derrick Rose', '2020-03-23 06:25:00', '2020-03-23 12:20:00'),
			(N'Derrick Rose', '2020-03-24 06:20:00', '2020-03-24 12:50:00'),
			(N'Derrick Rose', '2020-03-27 10:45:00', '2020-03-27 16:10:00'),
			(N'Derrick Rose', '2020-03-30 06:55:00', '2020-03-30 16:40:00'),


			(N'Drew Brees', '2020-03-01 06:00:00', '2020-03-01 13:50:00'),
			(N'Drew Brees', '2020-03-05 06:50:00', '2020-03-05 14:45:00'),
			(N'Drew Brees', '2020-03-11 12:00:00', '2020-03-11 18:50:00'),
			(N'Drew Brees', '2020-03-23 11:45:00', '2020-03-23 16:30:00'),
			(N'Drew Brees', '2020-03-30 06:00:00', '2020-03-30 12:15:00'),

			(N'Jason Byrne', '2020-04-01 10:30:00', '2020-04-01 17:50:00'),
			(N'Jason Byrne', '2020-04-03 08:30:00', '2020-04-03 08:30:00'),
			(N'Jason Byrne', '2020-04-10 09:30:00', '2020-04-10 16:30:00'),
			(N'Jason Byrne', '2020-04-20 07:20:00', '2020-04-20 15:45:00'),

			(N'Megan Fox', '2020-04-01 08:30:00', '2020-04-01 15:20:00'),
			(N'Megan Fox', '2020-04-06 06:00:00', '2020-04-06 10:50:00'),
			(N'Megan Fox', '2020-04-10 06:30:00', '2020-04-10 16:20:00'),
			(N'Megan Fox', '2020-04-20 09:30:00', '2020-04-20 14:45:00'),
			(N'Megan Fox', '2020-04-27 11:30:00', '2020-04-27 16:45:00'),


			(N'Leonardo DiCaprio', '2020-04-01 09:50:00', '2020-04-01 14:40:00'),
			(N'Leonardo DiCaprio', '2020-04-05 06:30:00', '2020-04-05 10:20:00'),
			(N'Leonardo DiCaprio', '2020-04-07 06:00:00', '2020-04-07 10:50:00'),


			(N'Denzel Washington', '2020-04-30 06:00:00', '2020-04-30 22:50:00'),

			(N'Derrick Rose', '2020-04-05 06:20:00', '2020-04-05 12:40:00'),
			(N'Derrick Rose', '2020-04-10 08:20:00', '2020-04-10 16:40:00'),
			(N'Derrick Rose', '2020-04-15 10:20:00', '2020-04-15 18:30:00'),
			(N'Derrick Rose', '2020-04-22 06:20:00', '2020-04-22 14:40:00'),
			(N'Derrick Rose', '2020-04-25 12:20:00', '2020-04-25 18:40:00'),

			(N'Drew Brees', '2020-04-13 06:00:00', '2020-04-13 13:50:00'),
			(N'Drew Brees', '2020-04-25 06:50:00', '2020-04-25 14:45:00')
			
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