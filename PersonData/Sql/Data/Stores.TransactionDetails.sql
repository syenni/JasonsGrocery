SELECT *
FROM Stores.TransactionDetails
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
	INNER JOIN Stores.[Transaction] T ON T.StoreID = P.StoreID AND T.TransactionID = 1;

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
SELECT T.TransactionID, P.ProductID, P.StoreID, TD1.UnitPrice, TD1.ItemQuantity
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
	) TD1(ProductName, UnitPrice, ItemQuantity)
	INNER JOIN Stores.Product P ON P.ProductName = TD1.ProductName
	INNER JOIN Stores.[Transaction] T ON T.StoreID = P.StoreID
			AND T.TransactionID = 2;

--update after transaction 2
UPDATE P 
SET	
	StockQuantity -= TD1.ItemQuantity
FROM Stores.Product P
	RIGHT JOIN Stores.TransactionDetails TD1 ON TD1.ProductID = P.ProductID
	INNER JOIN Stores.[Transaction] T ON T.TransactionID = TD1.TransactionID
WHERE T.TransactionID = 2;


--Tranaction 3
INSERT Stores.TransactionDetails(TransactionID, ProductID, StoreID, UnitPrice, ItemQuantity)
SELECT T.TransactionID, P.ProductID, P.StoreID, TD3.UnitPrice, TD3.ItemQuantity
FROM 
	(
		VALUES
			(N'Turkey', 3, 1),
			(N'Chicken', 4*10, 10)
	) TD3(ProductName, UnitPrice, ItemQuantity)
	INNER JOIN Stores.Product P ON P.ProductName = TD3.ProductName
	INNER JOIN Stores.[Transaction] T ON T.StoreID = P.StoreID AND T.TransactionID = 3;

--update after transaction 3
UPDATE P 
SET	
	StockQuantity -= TD3.ItemQuantity
FROM Stores.Product P
	RIGHT JOIN Stores.TransactionDetails TD3 ON TD3.ProductID = P.ProductID
	INNER JOIN Stores.[Transaction] T ON T.TransactionID = TD3.TransactionID
WHERE T.TransactionID = 3;

--Tranaction 4
INSERT Stores.TransactionDetails(TransactionID, ProductID, StoreID, UnitPrice, ItemQuantity)
SELECT T.TransactionID, P.ProductID, P.StoreID, TD4.UnitPrice, TD4.ItemQuantity
FROM 
	(
		VALUES
			(N'Double Chocolate Chip Cookies', 3.50*10, 10),
			(N'Corn', 2.25*2, 2),
			(N'Celery', 1, 1)
	) TD4(ProductName, UnitPrice, ItemQuantity)
	INNER JOIN Stores.Product P ON P.ProductName = TD4.ProductName
	INNER JOIN Stores.[Transaction] T ON T.StoreID = P.StoreID AND T.TransactionID = 4;

--update after transaction 4
UPDATE P 
SET	
	StockQuantity -= TD4.ItemQuantity
FROM Stores.Product P
	RIGHT JOIN Stores.TransactionDetails TD4 ON TD4.ProductID = P.ProductID
	INNER JOIN Stores.[Transaction] T ON T.TransactionID = TD4.TransactionID
WHERE T.TransactionID = 4;

--Tranaction 5
INSERT Stores.TransactionDetails(TransactionID, ProductID, StoreID, UnitPrice, ItemQuantity)
SELECT T.TransactionID, P.ProductID, P.StoreID, TD5.UnitPrice, TD5.ItemQuantity
FROM 
	(
		VALUES
			(N'PepperJack Cheese', 3*2, 2),
			(N'Swiss Cheese', 2*2, 2),
			(N'Provolone Cheese', 2*2, 2),
			(N'Wheat Bread',3.50*4 , 4),
			(N'Beef', 4*6 , 6),
			(N'Raisin Cookies', 1*4, 4),
			(N'Cucumbers', 1.75*1, 1),
			(N'Peppers',1*2 , 2)
	) TD5(ProductName, UnitPrice, ItemQuantity)
	INNER JOIN Stores.Product P ON P.ProductName = TD5.ProductName
	INNER JOIN Stores.[Transaction] T ON T.StoreID = P.StoreID AND T.TransactionID = 5;

--update after transaction 5
UPDATE P 
SET	
	StockQuantity -= TD5.ItemQuantity
FROM Stores.Product P
	RIGHT JOIN Stores.TransactionDetails TD5 ON TD5.ProductID = P.ProductID
	INNER JOIN Stores.[Transaction] T ON T.TransactionID = TD5.TransactionID
WHERE T.TransactionID = 5;

--Tranaction 6
INSERT Stores.TransactionDetails(TransactionID, ProductID, StoreID, UnitPrice, ItemQuantity)
SELECT T.TransactionID, P.ProductID, P.StoreID, TD6.UnitPrice, TD6.ItemQuantity
FROM 
	(
		VALUES
			(N'Milk', 2*2, 2),
			(N'Rocky Road Ice Cream', 3.25*1, 1)
	) TD6(ProductName, UnitPrice, ItemQuantity)
	INNER JOIN Stores.Product P ON P.ProductName = TD6.ProductName
	INNER JOIN Stores.[Transaction] T ON T.StoreID = P.StoreID AND T.TransactionID = 6;

--update after transaction 6
UPDATE P 
SET	
	StockQuantity -= TD6.ItemQuantity
FROM Stores.Product P
	RIGHT JOIN Stores.TransactionDetails TD6 ON TD6.ProductID = P.ProductID
	INNER JOIN Stores.[Transaction] T ON T.TransactionID = TD6.TransactionID
WHERE T.TransactionID = 6;