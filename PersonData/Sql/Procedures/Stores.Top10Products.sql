--2R: top 10 products
CREATE OR ALTER PROCEDURE Stores.Top10Products
   @DepartmentName NVARCHAR(32)
AS
WITH TopProdCTE(ProductID, ProductName, ItemQuantity) AS
	(
		SELECT P.ProductID, P.ProductName, TD.ItemQuantity
		FROM Stores.Department D
			RIGHT JOIN Stores.Product P ON P.DepartmentID = D.DepartmentID
			RIGHT JOIN Stores.TransactionDetails TD ON TD.ProductID = P.ProductID
		WHERE D.DepartmentName = @DepartmentName
	)
SELECT TOP 10 TP.ProductName, 
	SUM(TP.ItemQuantity) OVER(
		PARTITION BY TP.ProductID
	) AS QuantitySold
FROM TopProdCTE TP
ORDER BY ItemQuantity DESC, ProductName ASC;