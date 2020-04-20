--3Q: I want to see all of a workers in a position in the Store
CREATE OR ALTER PROCEDURE Stores.ListofPositionsInStore
   @PositionName NVARCHAR(32)
AS
SELECT WP.PositionName, E.EmployeeName, D.DepartmentName
FROM Stores.Store S 
	INNER JOIN Stores.Department D ON D.StoreID = S.StoreID
	INNER JOIN Stores.Employee E ON E.DepartmentID = D.DepartmentID
	INNER JOIN Stores.WorkPosition WP ON WP.WorkPositionID = E.WorkPositionID
WHERE WP.PositionName = @PositionName
ORDER BY E.EmployeeName ASC;