--7Q: I want to see most expensive items in the store
SELECT D.DepartmentName, P.ProductName, P.UnitPrice
FROM Stores.Department D 
	INNER JOIN Stores.Product P ON P.DepartmentID = D.DepartmentID
ORDER BY P.UnitPrice DESC;