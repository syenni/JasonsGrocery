SELECT *
FROM Stores.Product

/***************************** Modify values here *****************************/

--insert workposition position names
INSERT Stores.WorkPosition(PositionName)
	VALUES
		(N'Manager'),
		(N'Assistant Manager'),
		(N'Janitor');

/******************************************************************************/
--insert workposition position names
INSERT Stores.WorkPosition(PositionName)
	VALUES
		(N'Director'),
		(N'Clerk'),
		(N'Cashier');