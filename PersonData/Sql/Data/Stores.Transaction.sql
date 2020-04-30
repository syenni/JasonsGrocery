

/***************************** Modify values here *****************************/

INSERT Stores.[Transaction](StoreID, PurchasedOn)
SELECT S.StoreID, T.PurchasedOn
FROM 
	(
		VALUES	
			(N'Jason''s Grocery Store', '2020-04-28 05:30:00')
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
			(N'Jason''s Grocery Store', '2020-04-28 13:40:00')
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
			(N'Jason''s Grocery Store', '2020-04-29 12:00:00')
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
			(N'Jason''s Grocery Store', '2020-04-29 16:30:00')
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
			(N'Jason''s Grocery Store', '2020-04-30 08:30:00')
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
			(N'Jason''s Grocery Store', '2020-04-27 16:20:00')
	)T(StoreName, PurchasedOn)
	INNER JOIN Stores.Store S ON S.StoreName = T.StoreName;
SELECT*
FROM Stores.[Transaction] T;