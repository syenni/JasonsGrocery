

/***************************** Modify values here *****************************/

--insert a transaction at the store...receipt 1
INSERT Stores.[Transaction](StoreID)
SELECT S.StoreID
FROM 
	(
		VALUES	
			(N'Jason''s Grocery Store')
	)T(StoreName)
	INNER JOIN Stores.Store S ON S.StoreName = T.StoreName;

/******************************************************************************/
--transaction 2 
INSERT Stores.[Transaction](StoreID)
SELECT S.StoreID
FROM 
	(
		VALUES	
			(N'Jason''s Grocery Store')
	)T(StoreName)
	INNER JOIN Stores.Store S ON S.StoreName = T.StoreName;
SELECT*
FROM Stores.[Transaction];

--transaction 3
INSERT Stores.[Transaction](StoreID)
SELECT S.StoreID
FROM 
	(
		VALUES	
			(N'Jason''s Grocery Store')
	)T(StoreName)
	INNER JOIN Stores.Store S ON S.StoreName = T.StoreName;
SELECT*
FROM Stores.[Transaction];


--transaction 4
INSERT Stores.[Transaction](StoreID)
SELECT S.StoreID
FROM 
	(
		VALUES	
			(N'Jason''s Grocery Store')
	)T(StoreName)
	INNER JOIN Stores.Store S ON S.StoreName = T.StoreName;
SELECT*
FROM Stores.[Transaction];