

/***************************** Modify values here *****************************/

--inserting different departments into Jason's store
INSERT Stores.Department(StoreID, DepartmentName)
SELECT S.StoreID, Dep.DepartmentName
FROM 
	(
		VALUES
			(N'Jason''s Grocery Store', N'Produce'),
			(N'Jason''s Grocery Store', N'Deli'),
			(N'Jason''s Grocery Store', N'Dairy'),
			(N'Jason''s Grocery Store', N'Bakery')
	) Dep(Store, DepartmentName)
	INNER JOIN Stores.Store S ON S.StoreName = Dep.Store;

/******************************************************************************/