--3R: daily sales
DECLARE @SelectedDate DATE = SYSDATETIMEOFFSET();
WITH DailySales(ProductName, ItemQuantity, UnitPrice) AS
	(
		SELECT P.ProductName, TD.ItemQuantity, TD.UnitPrice
		FROM Stores.Product P
			RIGHT JOIN Stores.TransactionDetails TD ON TD.ProductID = P.ProductID
			INNER JOIN Stores.[Transaction] T ON T.TransactionID = TD.TransactionID
		WHERE DAY(T.PurchasedOn) = DAY(@SelectedDate)
			AND MONTH(T.PurchasedOn) = MONTH(@SelectedDate)
			AND YEAR(T.PurchasedOn) = YEAR(@SelectedDate)
	)
SELECT DISTINCT DS.ProductName,
	SUM(DS.ItemQuantity) AS AmountOfProductsSold,
	DS.UnitPrice,
	SUM(DS.ItemQuantity*DS.UnitPrice) AS TotalSales
FROM DailySales DS
GROUP BY DS.ProductName, DS.UnitPrice
ORDER BY TotalSales DESC;
