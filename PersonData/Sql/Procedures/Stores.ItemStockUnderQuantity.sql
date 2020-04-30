--5Q: I want to see which items have a stock quantity of less than quantity number
CREATE OR ALTER PROCEDURE Stores.ItemStockUnderQuantity
   @Quantity INT
   @DepartmentID INT
AS
SELECT D.DepartmentName, P.ProductName, P.StockQuantity
FROM Stores.Department D
	INNER JOIN Stores.Product P ON P.DepartmentID = D.DepartmentID
WHERE P.StockQuantity <= @Quantity AND D.DepartmentID = @DepartmentID
ORDER BY P.StockQuantity ASC;