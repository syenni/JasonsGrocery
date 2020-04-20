

/***************************** Modify values here *****************************/

--insert an Employee, Jason Byrne into the meat department
INSERT Stores.Employee(DepartmentID, WorkPositionID, HourlyPay, EmployeeName)
SELECT D.DepartmentID, WP.WorkPositionID, WP.HourlyPay, Emp.EmployeeName
FROM 
	(
		VALUES	
			(N'Manager', N'Deli', N'Jason Byrne'),
			(N'Assistant Manager', N'Dairy', N'Ben Hartman'),
			(N'Janitor', N'Produce', N'Seth Yenni')
	)Emp(PositionName, DepartmentName, EmployeeName)
	INNER JOIN Stores.Department D ON D.DepartmentName = Emp.DepartmentName
	INNER JOIN Stores.WorkPosition WP ON WP.PositionName = Emp.PositionName;

/******************************************************************************/
INSERT Stores.Employee(DepartmentID, WorkPositionID, HourlyPay, EmployeeName)
SELECT D.DepartmentID, WP.WorkPositionID, WP.HourlyPay, Emp.EmployeeName
FROM 
	(
		VALUES	
			(N'Manager', N'Bakery', N'Pillsbury Dough Boy'),
			(N'Clerk', N'Deli', N'Denzel Washington'),
			(N'Clerk', N'Dairy', N'Dave Chappelle'),
			(N'Clerk', N'Produce', N'Post Malone'),
			(N'Clerk', N'Produce', N'Paul Rudd'),
			(N'Assistant Manager', N'Produce', N'Percy Jackson'),
			(N'Assistant Manager', N'Deli', N'Drew Brees'),
			(N'Clerk', N'Deli', N'Derrick Rose'),
			(N'Manager', N'Dairy', N'David Hasselhoff'),
			(N'Director', N'Dairy', N'Drake'),
			(N'Director', N'Bakery', N'Bradley Cooper'),
			(N'Clerk', N'Bakery', N'Ben Stiller')
	)Emp(PositionName, DepartmentName, EmployeeName)
	INNER JOIN Stores.Department D ON D.DepartmentName = Emp.DepartmentName
	INNER JOIN Stores.WorkPosition WP ON WP.PositionName = Emp.PositionName;
