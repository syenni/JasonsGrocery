--2R: top 10 products
WITH TopProdCTE(ProductID, ProductName, ItemQuantity) AS
	(
		SELECT P.ProductID, P.ProductName, TD.ItemQuantity
		FROM Stores.Product P
			RIGHT JOIN Stores.TransactionDetails TD ON TD.ProductID = P.ProductID
	)
SELECT TOP 10 TP.ProductName, 
	SUM(TP.ItemQuantity) OVER(
		PARTITION BY TP.ProductID
	) AS QuantitySold
FROM TopProdCTE TP
ORDER BY ItemQuantity DESC, ProductName ASC;