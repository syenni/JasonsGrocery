--8Q: I want to see what a transaction looks like
SELECT TD.StoreID, TD.ProductID, P.ProductName, TD.ItemQuantity, TD.UnitPrice
FROM Stores.Store S
	INNER JOIN Stores.Department D ON D.StoreID = S.StoreID
	INNER JOIN Stores.Product P ON P.DepartmentID = D.DepartmentID
	INNER JOIN Stores.TransactionDetails TD ON TD.ProductID = P.ProductID
	INNER JOIN Stores.[Transaction] T ON T.StoreID = TD.StoreID;