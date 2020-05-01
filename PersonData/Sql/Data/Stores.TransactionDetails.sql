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

--Tranaction 7
INSERT Stores.TransactionDetails(TransactionID, ProductID, StoreID, UnitPrice, ItemQuantity)
SELECT T.TransactionID, P.ProductID, P.StoreID, TD7.UnitPrice, TD7.ItemQuantity
FROM 
	(
		VALUES
			(N'Ham', 3*2, 2),
			(N'Turkey', 3.25*1, 1)
	) TD7(ProductName, UnitPrice, ItemQuantity)
	INNER JOIN Stores.Product P ON P.ProductName = TD7.ProductName
	INNER JOIN Stores.[Transaction] T ON T.StoreID = P.StoreID AND T.TransactionID = 7;

--update after transaction 7
UPDATE P 
SET	
	StockQuantity -= TD7.ItemQuantity
FROM Stores.Product P
	RIGHT JOIN Stores.TransactionDetails TD7 ON TD7.ProductID = P.ProductID
	INNER JOIN Stores.[Transaction] T ON T.TransactionID = TD7.TransactionID
WHERE T.TransactionID = 7;

--Tranaction 8
INSERT Stores.TransactionDetails(TransactionID, ProductID, StoreID, UnitPrice, ItemQuantity)
SELECT T.TransactionID, P.ProductID, P.StoreID, TD8.UnitPrice, TD8.ItemQuantity
FROM 
	(
		VALUES
			(N'California Roll', 2.50*2, 2),
			(N'Apples', 3*10, 10)
	) TD8(ProductName, UnitPrice, ItemQuantity)
	INNER JOIN Stores.Product P ON P.ProductName = TD8.ProductName
	INNER JOIN Stores.[Transaction] T ON T.StoreID = P.StoreID AND T.TransactionID = 8;

--update after transaction 8
UPDATE P 
SET	
	StockQuantity -= TD8.ItemQuantity
FROM Stores.Product P
	RIGHT JOIN Stores.TransactionDetails TD8 ON TD8.ProductID = P.ProductID
	INNER JOIN Stores.[Transaction] T ON T.TransactionID = TD8.TransactionID
WHERE T.TransactionID = 8;

--Tranaction 9
INSERT Stores.TransactionDetails(TransactionID, ProductID, StoreID, UnitPrice, ItemQuantity)
SELECT T.TransactionID, P.ProductID, P.StoreID, TD9.UnitPrice, TD9.ItemQuantity
FROM 
	(
		VALUES
			(N'California Roll', 2.50*5, 5),
			(N'Dynamite Roll', 4.50*11, 11),
			(N'Milk', 2*1, 1)
	) TD9(ProductName, UnitPrice, ItemQuantity)
	INNER JOIN Stores.Product P ON P.ProductName = TD9.ProductName
	INNER JOIN Stores.[Transaction] T ON T.StoreID = P.StoreID AND T.TransactionID = 9;

--update after transaction 9
UPDATE P 
SET	
	StockQuantity -= TD9.ItemQuantity
FROM Stores.Product P
	RIGHT JOIN Stores.TransactionDetails TD9 ON TD9.ProductID = P.ProductID
	INNER JOIN Stores.[Transaction] T ON T.TransactionID = TD9.TransactionID
WHERE T.TransactionID = 9;

--Tranaction 10
INSERT Stores.TransactionDetails(TransactionID, ProductID, StoreID, UnitPrice, ItemQuantity)
SELECT T.TransactionID, P.ProductID, P.StoreID, TD10.UnitPrice, TD10.ItemQuantity
FROM 
	(
		VALUES
			(N'Kiwis', 1.15*15, 15),
			(N'Strawberry Ice Cream', 1.25*1, 1),
			(N'Corn', 2.25*6, 5),
			(N'Butter', 4*12, 12)
	) TD10(ProductName, UnitPrice, ItemQuantity)
	INNER JOIN Stores.Product P ON P.ProductName = TD10.ProductName
	INNER JOIN Stores.[Transaction] T ON T.StoreID = P.StoreID AND T.TransactionID = 10;

--update after transaction 10
UPDATE P 
SET	
	StockQuantity -= TD10.ItemQuantity
FROM Stores.Product P
	RIGHT JOIN Stores.TransactionDetails TD10 ON TD10.ProductID = P.ProductID
	INNER JOIN Stores.[Transaction] T ON T.TransactionID = TD10.TransactionID
WHERE T.TransactionID = 10;

--Tranaction 11
INSERT Stores.TransactionDetails(TransactionID, ProductID, StoreID, UnitPrice, ItemQuantity)
SELECT T.TransactionID, P.ProductID, P.StoreID, TD11.UnitPrice, TD11.ItemQuantity
FROM 
	(
		VALUES
			(N'Celery', 1*20, 20)
	) TD11(ProductName, UnitPrice, ItemQuantity)
	INNER JOIN Stores.Product P ON P.ProductName = TD11.ProductName
	INNER JOIN Stores.[Transaction] T ON T.StoreID = P.StoreID AND T.TransactionID = 11;

--update after transaction 11
UPDATE P 
SET	
	StockQuantity -= TD11.ItemQuantity
FROM Stores.Product P
	RIGHT JOIN Stores.TransactionDetails TD11 ON TD11.ProductID = P.ProductID
	INNER JOIN Stores.[Transaction] T ON T.TransactionID = TD11.TransactionID
WHERE T.TransactionID = 11;

--Tranaction 12
INSERT Stores.TransactionDetails(TransactionID, ProductID, StoreID, UnitPrice, ItemQuantity)
SELECT T.TransactionID, P.ProductID, P.StoreID, TD12.UnitPrice, TD12.ItemQuantity
FROM 
	(
		VALUES
			(N'Orange Sherbet', 1.75*20, 20),
			(N'Cottage Cheese', 2.50*20, 20)
	) TD12(ProductName, UnitPrice, ItemQuantity)
	INNER JOIN Stores.Product P ON P.ProductName = TD12.ProductName
	INNER JOIN Stores.[Transaction] T ON T.StoreID = P.StoreID AND T.TransactionID = 12;

--update after transaction 12
UPDATE P 
SET	
	StockQuantity -= TD12.ItemQuantity
FROM Stores.Product P
	RIGHT JOIN Stores.TransactionDetails TD12 ON TD12.ProductID = P.ProductID
	INNER JOIN Stores.[Transaction] T ON T.TransactionID = TD12.TransactionID
WHERE T.TransactionID = 12;

--Tranaction 13
INSERT Stores.TransactionDetails(TransactionID, ProductID, StoreID, UnitPrice, ItemQuantity)
SELECT T.TransactionID, P.ProductID, P.StoreID, TD13.UnitPrice, TD13.ItemQuantity
FROM 
	(
		VALUES
			(N'Onions', 1.15*8, 8),
			(N'Oranges', 2.25*14, 14)
	) TD13(ProductName, UnitPrice, ItemQuantity)
	INNER JOIN Stores.Product P ON P.ProductName = TD13.ProductName
	INNER JOIN Stores.[Transaction] T ON T.StoreID = P.StoreID AND T.TransactionID = 13;

--update after transaction 13
UPDATE P 
SET	
	StockQuantity -= TD13.ItemQuantity
FROM Stores.Product P
	RIGHT JOIN Stores.TransactionDetails TD13 ON TD13.ProductID = P.ProductID
	INNER JOIN Stores.[Transaction] T ON T.TransactionID = TD13.TransactionID
WHERE T.TransactionID = 13;

--Tranaction 14
INSERT Stores.TransactionDetails(TransactionID, ProductID, StoreID, UnitPrice, ItemQuantity)
SELECT T.TransactionID, P.ProductID, P.StoreID, TD14.UnitPrice, TD14.ItemQuantity
FROM 
	(
		VALUES
			(N'Broccoli', 2*20, 20),
			(N'Chobani Yogurt', 2.50*10, 10)
	) TD14(ProductName, UnitPrice, ItemQuantity)
	INNER JOIN Stores.Product P ON P.ProductName = TD14.ProductName
	INNER JOIN Stores.[Transaction] T ON T.StoreID = P.StoreID AND T.TransactionID = 14;

--update after transaction 14
UPDATE P 
SET	
	StockQuantity -= TD14.ItemQuantity
FROM Stores.Product P
	RIGHT JOIN Stores.TransactionDetails TD14 ON TD14.ProductID = P.ProductID
	INNER JOIN Stores.[Transaction] T ON T.TransactionID = TD14.TransactionID
WHERE T.TransactionID = 14;

--Tranaction 15
INSERT Stores.TransactionDetails(TransactionID, ProductID, StoreID, UnitPrice, ItemQuantity)
SELECT T.TransactionID, P.ProductID, P.StoreID, TD15.UnitPrice, TD15.ItemQuantity
FROM 
	(
		VALUES
			(N'Ham', 3*5, 5),
			(N'Banana Nut Muffins', 2.00*1, 1),
			(N'Chocolate Chip Muffins', 1.75*1, 1),
			(N'Blueberry Muffins', 1.50*1, 1)
	) TD15(ProductName, UnitPrice, ItemQuantity)
	INNER JOIN Stores.Product P ON P.ProductName = TD15.ProductName
	INNER JOIN Stores.[Transaction] T ON T.StoreID = P.StoreID AND T.TransactionID = 15;

--update after transaction 15
UPDATE P 
SET	
	StockQuantity -= TD15.ItemQuantity
FROM Stores.Product P
	RIGHT JOIN Stores.TransactionDetails TD15 ON TD15.ProductID = P.ProductID
	INNER JOIN Stores.[Transaction] T ON T.TransactionID = TD15.TransactionID
WHERE T.TransactionID = 15;

--Tranaction 16
INSERT Stores.TransactionDetails(TransactionID, ProductID, StoreID, UnitPrice, ItemQuantity)
SELECT T.TransactionID, P.ProductID, P.StoreID, TD16.UnitPrice, TD16.ItemQuantity
FROM 
	(
		VALUES
			(N'Sugar Cookies', 1.50*13, 13),
			(N'Raisin Cookies', 1.00*1, 1),
			(N'Orange Sherbet', 1.75*2, 2)
	) TD16(ProductName, UnitPrice, ItemQuantity)
	INNER JOIN Stores.Product P ON P.ProductName = TD16.ProductName
	INNER JOIN Stores.[Transaction] T ON T.StoreID = P.StoreID AND T.TransactionID = 16;

--update after transaction 16
UPDATE P 
SET	
	StockQuantity -= TD16.ItemQuantity
FROM Stores.Product P
	RIGHT JOIN Stores.TransactionDetails TD16 ON TD16.ProductID = P.ProductID
	INNER JOIN Stores.[Transaction] T ON T.TransactionID = TD16.TransactionID
WHERE T.TransactionID = 16;

--Tranaction 17
INSERT Stores.TransactionDetails(TransactionID, ProductID, StoreID, UnitPrice, ItemQuantity)
SELECT T.TransactionID, P.ProductID, P.StoreID, TD17.UnitPrice, TD17.ItemQuantity
FROM 
	(
		VALUES
			(N'Potatoes', 2.25*30, 30)
	) TD17(ProductName, UnitPrice, ItemQuantity)
	INNER JOIN Stores.Product P ON P.ProductName = TD17.ProductName
	INNER JOIN Stores.[Transaction] T ON T.StoreID = P.StoreID AND T.TransactionID = 17;

--update after transaction 17
UPDATE P 
SET	
	StockQuantity -= TD17.ItemQuantity
FROM Stores.Product P
	RIGHT JOIN Stores.TransactionDetails TD17 ON TD17.ProductID = P.ProductID
	INNER JOIN Stores.[Transaction] T ON T.TransactionID = TD17.TransactionID
WHERE T.TransactionID = 17;

--Tranaction 18
INSERT Stores.TransactionDetails(TransactionID, ProductID, StoreID, UnitPrice, ItemQuantity)
SELECT T.TransactionID, P.ProductID, P.StoreID, TD18.UnitPrice, TD18.ItemQuantity
FROM 
	(
		VALUES
			(N'Sour Cream', 3*30, 30),
			(N'White Bread', 2*10, 10)
	) TD18(ProductName, UnitPrice, ItemQuantity)
	INNER JOIN Stores.Product P ON P.ProductName = TD18.ProductName
	INNER JOIN Stores.[Transaction] T ON T.StoreID = P.StoreID AND T.TransactionID = 18;

--update after transaction 18
UPDATE P 
SET	
	StockQuantity -= TD18.ItemQuantity
FROM Stores.Product P
	RIGHT JOIN Stores.TransactionDetails TD18 ON TD18.ProductID = P.ProductID
	INNER JOIN Stores.[Transaction] T ON T.TransactionID = TD18.TransactionID
WHERE T.TransactionID = 18;

--Tranaction 19
INSERT Stores.TransactionDetails(TransactionID, ProductID, StoreID, UnitPrice, ItemQuantity)
SELECT T.TransactionID, P.ProductID, P.StoreID, TD19.UnitPrice, TD19.ItemQuantity
FROM 
	(
		VALUES
			(N'Strawberries', 2*10, 10),
			(N'Tomatoes', 1.50*10, 10),
			(N'Yogurt', 3*10, 10)
	) TD19(ProductName, UnitPrice, ItemQuantity)
	INNER JOIN Stores.Product P ON P.ProductName = TD19.ProductName
	INNER JOIN Stores.[Transaction] T ON T.StoreID = P.StoreID AND T.TransactionID = 19;

--update after transaction 19
UPDATE P 
SET	
	StockQuantity -= TD19.ItemQuantity
FROM Stores.Product P
	RIGHT JOIN Stores.TransactionDetails TD19 ON TD18.ProductID = P.ProductID
	INNER JOIN Stores.[Transaction] T ON T.TransactionID = TD19.TransactionID
WHERE T.TransactionID = 19;

--Tranaction 20
INSERT Stores.TransactionDetails(TransactionID, ProductID, StoreID, UnitPrice, ItemQuantity)
SELECT T.TransactionID, P.ProductID, P.StoreID, TD20.UnitPrice, TD20.ItemQuantity
FROM 
	(
		VALUES
			(N'Celery', 1*15, 15)
	) TD20(ProductName, UnitPrice, ItemQuantity)
	INNER JOIN Stores.Product P ON P.ProductName = TD20.ProductName
	INNER JOIN Stores.[Transaction] T ON T.StoreID = P.StoreID AND T.TransactionID = 20;

--update after transaction 20
UPDATE P 
SET	
	StockQuantity -= TD20.ItemQuantity
FROM Stores.Product P
	RIGHT JOIN Stores.TransactionDetails TD20 ON TD18.ProductID = P.ProductID
	INNER JOIN Stores.[Transaction] T ON T.TransactionID = TD20.TransactionID
WHERE T.TransactionID = 20;