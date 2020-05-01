

/***************************** Modify values here *****************************/

INSERT Stores.[Transaction](StoreID, PurchasedOn)
SELECT S.StoreID, T.PurchasedOn
FROM 
	(
		VALUES	
			(N'Jason''s Grocery Store', '2020-03-15 08:30:00')
	)T(StoreName, PurchasedOn)
	INNER JOIN Stores.Store S ON S.StoreName = T.StoreName;
SELECT*
FROM Stores.[Transaction] T;

/******************************************************************************/
--transaction 2 
INSERT Stores.[Transaction](StoreID, PurchasedOn)
SELECT S.StoreID, T.PurchasedOn
FROM 
	(
		VALUES	
			(N'Jason''s Grocery Store', '2020-03-15 13:40:00')
	)T(StoreName, PurchasedOn)
	INNER JOIN Stores.Store S ON S.StoreName = T.StoreName;
SELECT*
FROM Stores.[Transaction] T;

--transaction 3
INSERT Stores.[Transaction](StoreID, PurchasedOn)
SELECT S.StoreID, T.PurchasedOn
FROM 
	(
		VALUES	
			(N'Jason''s Grocery Store', '2020-03-15 16:00:00')
	)T(StoreName, PurchasedOn)
	INNER JOIN Stores.Store S ON S.StoreName = T.StoreName;
SELECT*
FROM Stores.[Transaction] T;


--transaction 4
INSERT Stores.[Transaction](StoreID, PurchasedOn)
SELECT S.StoreID, T.PurchasedOn
FROM 
	(
		VALUES	
			(N'Jason''s Grocery Store', '2020-03-26 6:30:00')
	)T(StoreName, PurchasedOn)
	INNER JOIN Stores.Store S ON S.StoreName = T.StoreName;
SELECT*
FROM Stores.[Transaction] T;

--transaction 5
INSERT Stores.[Transaction](StoreID, PurchasedOn)
SELECT S.StoreID, T.PurchasedOn
FROM 
	(
		VALUES	
			(N'Jason''s Grocery Store', '2020-03-26 08:30:00')
	)T(StoreName, PurchasedOn)
	INNER JOIN Stores.Store S ON S.StoreName = T.StoreName;
SELECT*
FROM Stores.[Transaction] T;

--transaction 6
INSERT Stores.[Transaction](StoreID, PurchasedOn)
SELECT S.StoreID, T.PurchasedOn
FROM 
	(
		VALUES	
			(N'Jason''s Grocery Store', '2020-03-26 12:20:00')
	)T(StoreName, PurchasedOn)
	INNER JOIN Stores.Store S ON S.StoreName = T.StoreName;
SELECT*
FROM Stores.[Transaction] T;

--transaction 7
INSERT Stores.[Transaction](StoreID, PurchasedOn)
SELECT S.StoreID, T.PurchasedOn
FROM 
	(
		VALUES	
			(N'Jason''s Grocery Store', '2020-03-26 15:20:00')
	)T(StoreName, PurchasedOn)
	INNER JOIN Stores.Store S ON S.StoreName = T.StoreName;
SELECT*
FROM Stores.[Transaction] T;

--transaction 8
INSERT Stores.[Transaction](StoreID, PurchasedOn)
SELECT S.StoreID, T.PurchasedOn
FROM 
	(
		VALUES	
			(N'Jason''s Grocery Store', '2020-03-31 8:20:00')
	)T(StoreName, PurchasedOn)
	INNER JOIN Stores.Store S ON S.StoreName = T.StoreName;
SELECT*
FROM Stores.[Transaction] T;

--transaction 9
INSERT Stores.[Transaction](StoreID, PurchasedOn)
SELECT S.StoreID, T.PurchasedOn
FROM 
	(
		VALUES	
			(N'Jason''s Grocery Store', '2020-03-31 14:20:00')
	)T(StoreName, PurchasedOn)
	INNER JOIN Stores.Store S ON S.StoreName = T.StoreName;
SELECT*
FROM Stores.[Transaction] T;

--transaction 10
INSERT Stores.[Transaction](StoreID, PurchasedOn)
SELECT S.StoreID, T.PurchasedOn
FROM 
	(
		VALUES	
			(N'Jason''s Grocery Store', '2020-03-31 15:30:00')
	)T(StoreName, PurchasedOn)
	INNER JOIN Stores.Store S ON S.StoreName = T.StoreName;
SELECT*
FROM Stores.[Transaction] T;

--transaction 11
INSERT Stores.[Transaction](StoreID, PurchasedOn)
SELECT S.StoreID, T.PurchasedOn
FROM 
	(
		VALUES	
			(N'Jason''s Grocery Store', '2020-03-31 16:20:00')
	)T(StoreName, PurchasedOn)
	INNER JOIN Stores.Store S ON S.StoreName = T.StoreName;
SELECT*
FROM Stores.[Transaction] T;

--transaction 12
INSERT Stores.[Transaction](StoreID, PurchasedOn)
SELECT S.StoreID, T.PurchasedOn
FROM 
	(
		VALUES	
			(N'Jason''s Grocery Store', '2020-03-31 16:20:00')
	)T(StoreName, PurchasedOn)
	INNER JOIN Stores.Store S ON S.StoreName = T.StoreName;
SELECT*
FROM Stores.[Transaction] T;

--transaction 13
INSERT Stores.[Transaction](StoreID, PurchasedOn)
SELECT S.StoreID, T.PurchasedOn
FROM 
	(
		VALUES	
			(N'Jason''s Grocery Store', '2020-04-04 10:20:00')
	)T(StoreName, PurchasedOn)
	INNER JOIN Stores.Store S ON S.StoreName = T.StoreName;
SELECT*
FROM Stores.[Transaction] T;

--transaction 14
INSERT Stores.[Transaction](StoreID, PurchasedOn)
SELECT S.StoreID, T.PurchasedOn
FROM 
	(
		VALUES	
			(N'Jason''s Grocery Store', '2020-04-04 14:45:00')
	)T(StoreName, PurchasedOn)
	INNER JOIN Stores.Store S ON S.StoreName = T.StoreName;
SELECT*
FROM Stores.[Transaction] T;

--transaction 15
INSERT Stores.[Transaction](StoreID, PurchasedOn)
SELECT S.StoreID, T.PurchasedOn
FROM 
	(
		VALUES	
			(N'Jason''s Grocery Store', '2020-04-04 16:10:00')
	)T(StoreName, PurchasedOn)
	INNER JOIN Stores.Store S ON S.StoreName = T.StoreName;
SELECT*
FROM Stores.[Transaction] T;

--transaction 16
INSERT Stores.[Transaction](StoreID, PurchasedOn)
SELECT S.StoreID, T.PurchasedOn
FROM 
	(
		VALUES	
			(N'Jason''s Grocery Store', '2020-04-04 17:20:00')
	)T(StoreName, PurchasedOn)
	INNER JOIN Stores.Store S ON S.StoreName = T.StoreName;
SELECT*
FROM Stores.[Transaction] T;

--transaction 17
INSERT Stores.[Transaction](StoreID, PurchasedOn)
SELECT S.StoreID, T.PurchasedOn
FROM 
	(
		VALUES	
			(N'Jason''s Grocery Store', '2020-04-04 16:10:00')
	)T(StoreName, PurchasedOn)
	INNER JOIN Stores.Store S ON S.StoreName = T.StoreName;
SELECT*
FROM Stores.[Transaction] T;

--transaction 18
INSERT Stores.[Transaction](StoreID, PurchasedOn)
SELECT S.StoreID, T.PurchasedOn
FROM 
	(
		VALUES	
			(N'Jason''s Grocery Store', '2020-04-04 17:20:00')
	)T(StoreName, PurchasedOn)
	INNER JOIN Stores.Store S ON S.StoreName = T.StoreName;
SELECT*
FROM Stores.[Transaction] T;

--transaction 19
INSERT Stores.[Transaction](StoreID, PurchasedOn)
SELECT S.StoreID, T.PurchasedOn
FROM 
	(
		VALUES	
			(N'Jason''s Grocery Store', '2020-04-30 6:10:00')
	)T(StoreName, PurchasedOn)
	INNER JOIN Stores.Store S ON S.StoreName = T.StoreName;
SELECT*
FROM Stores.[Transaction] T;

--transaction 20
INSERT Stores.[Transaction](StoreID, PurchasedOn)
SELECT S.StoreID, T.PurchasedOn
FROM 
	(
		VALUES	
			(N'Jason''s Grocery Store', '2020-04-30 12:20:00')
	)T(StoreName, PurchasedOn)
	INNER JOIN Stores.Store S ON S.StoreName = T.StoreName;
SELECT*
FROM Stores.[Transaction] T;