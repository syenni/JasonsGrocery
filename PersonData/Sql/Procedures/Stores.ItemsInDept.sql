--2Q: I want to see all of the items in a certain Dept
CREATE OR ALTER PROCEDURE Stores.ItemsInDept
   @DepartmentID INT
AS
SELECT P.ProductName, P.StockQuantity
FROM Stores.Department D
	INNER JOIN Stores.Product P ON P.DepartmentID = D.DepartmentID
WHERE D.DepartmentID = @DepartmentID
ORDER BY P.ProductName ASC;