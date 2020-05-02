

/***************************** Modify values here *****************************/

INSERT Stores.[Transaction](StoreID, PurchasedOn)
SELECT S.StoreID, T.PurchasedOn
FROM 
	(
		VALUES	
			(N'Jason''s Grocery Store', '2020-04-01 08:30:00'),
			(N'Jason''s Grocery Store', '2020-04-01 13:40:00'),
			(N'Jason''s Grocery Store', '2020-03-01 16:00:00'),

			(N'Jason''s Grocery Store', '2020-03-02 6:30:00'),
			(N'Jason''s Grocery Store', '2020-03-02 16:30:00'),

			(N'Jason''s Grocery Store', '2020-03-03 8:50:00'),
			(N'Jason''s Grocery Store', '2020-03-03 12:20:00'),
			(N'Jason''s Grocery Store', '2020-03-03 17:45:00'),

			(N'Jason''s Grocery Store', '2020-03-04 9:45:00'),

			(N'Jason''s Grocery Store', '2020-03-05 8:15:00'),
			(N'Jason''s Grocery Store', '2020-03-05 12:25:00'),
			(N'Jason''s Grocery Store', '2020-03-05 14:40:00'),
			(N'Jason''s Grocery Store', '2020-04-05 17:10:00'),

			(N'Jason''s Grocery Store', '2020-04-06 6:15:00'),
			(N'Jason''s Grocery Store', '2020-04-06 11:10:00'),
			(N'Jason''s Grocery Store', '2020-04-06 16:55:00'),

			(N'Jason''s Grocery Store', '2020-04-07 12:10:00'),
			(N'Jason''s Grocery Store', '2020-04-07 18:10:00'),

			(N'Jason''s Grocery Store', '2020-04-08 6:10:00'),
			(N'Jason''s Grocery Store', '2020-04-08 11:35:00'),

			(N'Jason''s Grocery Store', '2020-04-09 16:25:00'),

			(N'Jason''s Grocery Store', '2020-04-10 9:45:00'),
			(N'Jason''s Grocery Store', '2020-04-10 14:25:00'),

			(N'Jason''s Grocery Store', '2020-04-11 9:15:00'),
			(N'Jason''s Grocery Store', '2020-04-11 10:50:00'),
			(N'Jason''s Grocery Store', '2020-04-11 16:10:00'),

			(N'Jason''s Grocery Store', '2020-04-12 8:30:00'),
			(N'Jason''s Grocery Store', '2020-04-12 13:50:00'),

			(N'Jason''s Grocery Store', '2020-04-13 7:20:00'),
			(N'Jason''s Grocery Store', '2020-04-13 10:25:00'),
			(N'Jason''s Grocery Store', '2020-04-13 14:05:00'),
			(N'Jason''s Grocery Store', '2020-04-13 17:55:00'),

			(N'Jason''s Grocery Store', '2020-04-14 12:30:00'),
			(N'Jason''s Grocery Store', '2020-04-14 15:45:00'),

			(N'Jason''s Grocery Store', '2020-04-15 11:40:00'),

			(N'Jason''s Grocery Store', '2020-04-16 9:10:00'),
			(N'Jason''s Grocery Store', '2020-04-16 12:00:00'),

			(N'Jason''s Grocery Store', '2020-04-17 13:25:00'),

			(N'Jason''s Grocery Store', '2020-04-19 17:05:00'),

			(N'Jason''s Grocery Store', '2020-04-21 12:00:00'),

			(N'Jason''s Grocery Store', '2020-04-22 8:55:00'),
			(N'Jason''s Grocery Store', '2020-04-22 11:10:00'),

			(N'Jason''s Grocery Store', '2020-04-23 7:30:00'),

			(N'Jason''s Grocery Store', '2020-04-25 9:00:00'),
			(N'Jason''s Grocery Store', '2020-04-25 13:35:00'),

			(N'Jason''s Grocery Store', '2020-04-26 9:10:00'),
			(N'Jason''s Grocery Store', '2020-04-26 11:35:00'),
			(N'Jason''s Grocery Store', '2020-04-26 18:35:00'),

			(N'Jason''s Grocery Store', '2020-04-27 12:50:00'),

			(N'Jason''s Grocery Store', '2020-04-29 6:40:00'),

			(N'Jason''s Grocery Store', '2020-04-30 9:00:00'),
			(N'Jason''s Grocery Store', '2020-04-30 14:15:00')
	)T(StoreName, PurchasedOn)
	INNER JOIN Stores.Store S ON S.StoreName = T.StoreName;
SELECT*
FROM Stores.[Transaction] T;

/******************************************************************************/