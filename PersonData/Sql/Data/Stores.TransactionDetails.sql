

/***************************** Modify values here *****************************/

--insert the transaction details for that specific transaction using a scope indentity for the transactionId
INSERT Stores.TransactionDetails(TransactionID, ProductID, StoreID, UnitPrice, ItemQuantity)
SELECT T.TransactionID, P.ProductID, P.StoreID, TD.UnitPrice, TD.ItemQuantity
FROM 
	(
		VALUES
			(N'Apples', 9 , 3),
			(N'Broccoli', 20, 10),
			(N'California Roll', 2.50, 1),
			(N'French Bread', 5 , 2),
			(N'Ham',12 , 4),
			(N'Milk', 2 , 1),
			(N'Provolone Cheese',8 , 4),
			(N'Sugar Cookies',4.50 , 3)
	) TD(ProductName, UnitPrice, ItemQuantity)
	INNER JOIN Stores.Product P ON P.ProductName = TD.ProductName
	INNER JOIN Stores.[Transaction] T ON T.StoreID = P.StoreID;

--update after transaction 1
UPDATE P 
SET	
	StockQuantity -= TD.ItemQuantity
FROM Stores.Product P
	RIGHT JOIN Stores.TransactionDetails TD ON TD.ProductID = P.ProductID
	INNER JOIN Stores.[Transaction] T ON T.TransactionID = TD.TransactionID
WHERE T.TransactionID = 1;
/******************************************************************************/
--insert the transaction details for transaction 2 using a scope indentity for the transactionId
INSERT Stores.TransactionDetails(TransactionID, ProductID, StoreID, UnitPrice, ItemQuantity)
SELECT T.TransactionID, P.ProductID, P.StoreID, TD.UnitPrice, TD.ItemQuantity
FROM 
	(
		VALUES
			(N'French Bread', 20*2.50 , 20),
			(N'Sour Cream', 15, 5),
			(N'Swiss Cheese', 2, 1),
			(N'Kiwis', 1.15*3 , 3),
			(N'Orange Sherbet', 1.75*2 , 2),
			(N'Raisin Cookies', 5 , 5),
			(N'Onions', 1.15*5 , 5)
	) TD(ProductName, UnitPrice, ItemQuantity)
	INNER JOIN Stores.Product P ON P.ProductName = TD.ProductName
	INNER JOIN Stores.[Transaction] T ON T.StoreID = P.StoreID
		AND T.TransactionID = 2;

--update after transaction 2
UPDATE P 
SET	
	StockQuantity -= TD.ItemQuantity
FROM Stores.Product P
	RIGHT JOIN Stores.TransactionDetails TD ON TD.ProductID = P.ProductID
	INNER JOIN Stores.[Transaction] T ON T.TransactionID = TD.TransactionID
WHERE T.TransactionID = 2;