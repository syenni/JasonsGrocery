--2Q: I want to see all of the items in a certain Dept
CREATE OR ALTER PROCEDURE Stores.ItemsInDept
   @DepartmentName NVARCHAR(32)
AS
SELECT D.DepartmentName, P.ProductName
FROM Stores.Department D
	INNER JOIN Stores.Product P ON P.DepartmentID = D.DepartmentID
WHERE D.DepartmentName = @DepartmentName
ORDER BY P.ProductName ASC;