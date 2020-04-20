--4Q: I want to see all of the items under two dollars
CREATE OR ALTER PROCEDURE Stores.ItemsUnderCertainPrice
   @Price FLOAT
AS
SELECT D.DepartmentName, P.ProductName, P.UnitPrice
FROM Stores.Department D 
	INNER JOIN Stores.Product P ON P.DepartmentID = D.DepartmentID
WHERE P.UnitPrice <= @Price
ORDER BY P.UnitPrice DESC;