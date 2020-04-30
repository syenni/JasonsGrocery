

/***************************** Modify values here *****************************/

--insert an Employee, Jason Byrne into the meat department
INSERT Stores.Employee(DepartmentID, WorkPositionID, HourlyPay, EmployeeName)
SELECT D.DepartmentID, WP.WorkPositionID, Emp.HourlyPay, Emp.EmployeeName
FROM 
	(
		VALUES	
			(N'Manager', N'Deli', 17.50 ,N'Jason Byrne'),
			(N'Assistant Manager',  N'Dairy', 14.25, N'Ben Hartman'),
			(N'Janitor', N'Produce', 10.05, N'Seth Yenni')
	)Emp(PositionName, DepartmentName, HourlyPay, EmployeeName)
	INNER JOIN Stores.Department D ON D.DepartmentName = Emp.DepartmentName
	INNER JOIN Stores.WorkPosition WP ON WP.PositionName = Emp.PositionName;

/******************************************************************************/
INSERT Stores.Employee(DepartmentID, WorkPositionID, HourlyPay, EmployeeName)
SELECT D.DepartmentID, WP.WorkPositionID, Emp.HourlyPay, Emp.EmployeeName
FROM 
	(
		VALUES	
			(N'Janitor', N'Deli', 9.50, N'Leonardo DiCaprio'),
			(N'Janitor', N'Dairy', 9.75, N'Robert Downey Jr'),
			(N'Janitor', N'Bakery', 12, N'Ariana Grande'),
			(N'Clerk', N'Deli', 11, N'Denzel Washington'),
			(N'Clerk', N'Dairy', 10.50, N'Dave Chappelle'),
			(N'Clerk', N'Dairy', 11.50, N'Kevin Hart'),
			(N'Clerk', N'Produce', 10.75, N'Post Malone'),
			(N'Clerk', N'Produce', 9, N'Paul Rudd'),
			(N'Clerk', N'Bakery', 10, N'Ben Stiller'),
			(N'Clerk', N'Bakery', 8.25, N'Slenderman'),
			(N'Clerk', N'Deli', 10, N'Derrick Rose'),
			(N'Assistant Manager', N'Produce', 13.75, N'Percy Jackson'),
			(N'Assistant Manager', N'Deli', 14.05, N'Drew Brees'),
			(N'Assistant Manager', N'Bakery', 13.05, N'Aunt Jemima'),
			(N'Manager', N'Dairy', 20, N'David Hasselhoff'),
			(N'Manager', N'Bakery', 18, N'Pillsbury Dough Boy'),
			(N'Manager', N'Produce', 15, N'Kate Upton'),
			(N'Director', N'Dairy', 24, N'Drake'),
			(N'Director', N'Bakery', 23.50, N'Bradley Cooper'),
			(N'Director', N'Produce', 25.00, N'Chris Pratt'),
			(N'Director', N'Deli', 30, N'Megan Fox')
	)Emp(PositionName, DepartmentName, HourlyPay, EmployeeName)
	INNER JOIN Stores.Department D ON D.DepartmentName = Emp.DepartmentName
	INNER JOIN Stores.WorkPosition WP ON WP.PositionName = Emp.PositionName;
