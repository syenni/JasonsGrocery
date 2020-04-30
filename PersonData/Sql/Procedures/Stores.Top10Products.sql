--2R: top 10 products
CREATE OR ALTER PROCEDURE Stores.Top10Products
   @DepartmentID INT
AS
WITH TopProdCTE(ProductID, ProductName, QuantitySold) AS
	(
		SELECT DISTINCT P.ProductID, P.ProductName, 
			SUM(TD.ItemQuantity) OVER(
				PARTITION BY P.ProductID
				) AS QuantitySold
		FROM Stores.Department D
			INNER JOIN Stores.Product P ON P.DepartmentID = D.DepartmentID
			INNER JOIN Stores.TransactionDetails TD ON TD.ProductID = P.ProductID
		WHERE D.DepartmentID = @DepartmentID
		GROUP BY P.ProductID, P.ProductName, TD.ItemQuantity
	)
SELECT TOP 10 TP.ProductName, TP.QuantitySold
FROM TopProdCTE TP
ORDER BY QuantitySold DESC, ProductName ASC;