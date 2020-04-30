--7Q: I want to see most expensive items in the store
CREATE OR ALTER PROCEDURE Stores.ExpensiveItems
   @DepartmentID INT
AS
SELECT D.DepartmentName, P.ProductName, P.UnitPrice
FROM Stores.Department D 
	INNER JOIN Stores.Product P ON P.DepartmentID = D.DepartmentID
WHERE D.DepartmentID = @DepartmentID
ORDER BY P.UnitPrice DESC;