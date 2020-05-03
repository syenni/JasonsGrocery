SELECT *
FROM Stores.TransactionDetails
/***************************** Modify values here *****************************/

--insert the transaction details for that each using a scope indentity for the transactionId
INSERT Stores.TransactionDetails(TransactionID, ProductID, StoreID, UnitPrice, ItemQuantity)
SELECT TD.TransactionID, P.ProductID, P.StoreID, P.UnitPrice, TD.ItemQuantity
FROM 
	(
		VALUES
			(1, N'Apples', 3),
			(1, N'Broccoli', 10),
			(1, N'California Roll', 1),
			(1, N'French Bread', 2),
			(1, N'Ham', 4),
			(1, N'Milk', 1),
			(1, N'Provolone Cheese', 4),
			(1, N'Sugar Cookies', 3),

			(2, N'French Bread', 20),
			(2, N'Sour Cream', 5),
			(2, N'Swiss Cheese', 1),
			(2, N'Kiwis', 3),
			(2, N'Orange Sherbet', 2),
			(2, N'Raisin Cookies', 5),
			(2, N'Onions', 5),

			(3, N'Turkey', 1),
			(3, N'Chicken', 10),

			(4, N'Double Chocolate Chip Cookies', 10),
			(4, N'Corn', 2),
			(4, 'Celery', 1),

			(5, N'PepperJack Cheese', 2),
			(5, N'Swiss Cheese', 2),
			(5, N'Provolone Cheese', 2),
			(5, N'Wheat Bread', 4),
			(5, N'Beef', 6),
			(5, N'Raisin Cookies', 4),
			(5, N'Cucumbers', 1),
			(5, N'Peppers', 2),

			(6, N'Milk', 2),
			(6, N'Rocky Road Ice Cream', 1),

			(7, N'Ham', 2),
			(7, N'Turkey',  1),

			(8, N'California Roll', 2),
			(8, N'Apples', 10),

			(9, N'California Roll', 5),
			(9, N'Dynamite Roll', 11),
			(9, N'Milk', 1),

			(10, N'Kiwis', 15),
			(10, N'Strawberry Ice Cream', 1),
			(10, N'Corn', 5),
			(10, N'Butter', 12),

			(11, N'Celery', 20),

			(12, N'Orange Sherbet', 20),
			(12, N'Cottage Cheese', 20),

			(13, N'Onions', 8),
			(13, N'Oranges', 14),

			(14, N'Broccoli', 20),
			(14, N'Chobani Yogurt', 10),

			(15, N'Ham', 5),
			(15, N'Banana Nut Muffins', 1),
			(15, N'Chocolate Chip Muffins', 1),
			(15, N'Blueberry Muffins', 1),

			(16, N'Sugar Cookies', 13),
			(16, N'Raisin Cookies', 1),
			(16, N'Orange Sherbet', 2),

			(17, N'Potatoes', 10),

			(18, N'Sour Cream', 30),
			(18, N'White Bread', 10),

			(19, N'Strawberries', 10),
			(19, N'Tomatoes', 10),
			(19, N'Yogurt', 10),

			(20, N'Celery', 15),

			(21, N'Beef', 2),
			(21, N'Butter', 1),
			(21, N'Vanilla Ice Cream', 3),
			(21, N'Strawberries',  2),

			(22, N'Blueberry Muffins', 2),
			(22, N'Peppers', 3),
			(22, N'Oranges', 1),

			(23, N'Kiwis', 4),
			(23, N'Strawberry Ice Cream', 1),
			(23, N'California Roll', 2),

			(24, N'Chocolate Chip Muffins', 5),
			(24, N'Sugar Cookies', 10),

			(25, N'Colby Jack Cheese', 2),
			(25, N'Swiss Cheese', 2),
			(25, N'Beef', 5),
			(25, N'Turkey', 2),
			(25, N'Wheat Bread', 6),

			(26, N'Cottage Cheese', 6),

			(27, N'Rocky Road Ice Cream', 3),
			(27, N'Vanilla Ice Cream', 3),

			(28, N'Turkey', 3),
			(28, N'Chicken', 1),

			(29, N'Milk', 2),
			(29, N'Bananas', 4),
			(29, N'Yogurt', 10),

			(30, N'Chobani Yogurt', 3),
			(30, N'Corn', 2),
			(30, N'Cucumbers', 4),
			(30, N'Onions', 3),
			(30, N'Potatoes', 2),

			(31, N'Sour Cream', 15),

			(32, N'Strawberries', 5),
			(32, N'Oranges', 5),
			(32, N'Kiwis', 5),
			(32, N'Milk', 2),

			(33, N'Dynamite Roll', 2),
			(33, N'California Roll', 2),

			(34, N'Chocolate Chip Cookie Dough Ice Cream', 3),

			(35, N'Tomatoes', 3),
			(35, N'Celery', 2),

			(36, N'Provolone Cheese', 6),

			(37, N'Milk', 1),
			(37, N'Bananas', 5),
			(37, N'Yogurt', 3),

			(38, N'Butter', 2),

			(39, N'Chicken', 2),
			(39, N'Ham', 2),
			(39, N'Turkey', 2),
			(39, N'Beef', 2),
			(39, N'Colby Jack Cheese', 2),
			(39, N'Swiss Cheese', 2),
			(39, N'PepperJack Cheese', 2),
			(39, N'Provolone Cheese', 2),
			(39, N'White Bread', 2),
			(39, N'Wheat Bread', 2),
			(39, N'French Bread', 2),

			(40, N'Raisin Cookies', 2),

			(41, N'Orange Sherbet', 1),
			(41, N'Rocky Road Ice Cream', 1),

			(42, N'Chocolate Ice Cream', 3),
			(42, N'Double Chocolate Chip Cookies', 5),

			(43, N'Milk', 1),
			(43, N'Apples', 5),

			(44, N'Chocolate Chip Muffins', 1),
			(44, N'Blueberry Muffins', 1),
			(44, N'Banana Nut Muffins', 1),

			(45, N'Yogurt', 4),
			(45, N'Apples', 2),

			(46, N'Turkey', 5),

			(47, N'Celery', 10),

			(48, N'Peppers', 5),
			(48, N'Sour Cream', 3),

			(49,  N'California Roll', 5),
			(49, N'Dynamite Roll', 5),

			(50, N'Vanilla Ice Cream', 2),

			(51, N'Butter', 1),

			(52, N'Milk', 1),

			(53, N'Double Chocolate Chip Cookies', 10),
			(53, N'Corn', 2),
			(53, 'Celery', 1),

			(54, N'Onions', 8),
			(54, N'Oranges', 14),

			(55, N'Sour Cream', 30),
			(55, N'White Bread', 10),

			(56, N'California Roll', 2),
			(56, N'Apples', 10),

			(57, N'Turkey', 3),
			(57, N'Chicken', 1),

			(58, N'Turkey', 1),
			(58, N'Chicken', 10),

			(59, N'Milk', 2),
			(59, N'Bananas', 4),
			(59, N'Yogurt', 10),

			(60, N'Kiwis', 15),
			(60, N'Strawberry Ice Cream', 1),
			(60, N'Corn', 5),
			(60, N'Butter', 12),

			(61, N'Celery', 20),

			(62, N'PepperJack Cheese', 2),
			(62, N'Swiss Cheese', 2),
			(62, N'Provolone Cheese', 2),
			(62, N'Wheat Bread', 4),
			(62, N'Beef', 6),
			(62, N'Raisin Cookies', 4),
			(62, N'Cucumbers', 1),
			(62, N'Peppers', 2),

			(63, N'Blueberry Muffins', 2),
			(63, N'Peppers', 3),
			(63, N'Oranges', 1),

			(64, N'Broccoli', 20),
			(64, N'Chobani Yogurt', 10),

			(65, N'French Bread', 20),
			(65, N'Sour Cream', 5),
			(65, N'Swiss Cheese', 1),
			(65, N'Kiwis', 3),
			(65, N'Orange Sherbet', 2),
			(65, N'Raisin Cookies', 5),
			(65, N'Onions', 5),

			(66, N'Ham', 5),
			(66, N'Banana Nut Muffins', 1),
			(66, N'Chocolate Chip Muffins', 1),
			(66, N'Blueberry Muffins', 1),

			(67, N'Sugar Cookies', 13),
			(67, N'Raisin Cookies', 1),
			(67, N'Orange Sherbet', 2),

			(68, N'Turkey', 5),

			(69, N'Milk', 2),
			(69, N'Rocky Road Ice Cream', 1),

			(70, N'Butter', 1),

			(71, N'Strawberries', 10),
			(71, N'Tomatoes', 10),
			(71, N'Yogurt', 10),

			(72, N'Celery', 15),

			(73, N'Peppers', 5),
			(73, N'Sour Cream', 3),

			(74, N'Kiwis', 4),
			(74, N'Strawberry Ice Cream', 1),
			(74, N'California Roll', 2),

			(75, N'Orange Sherbet', 20),
			(75, N'Cottage Cheese', 20),

			(76, N'California Roll', 5),
			(76, N'Dynamite Roll', 11),
			(76, N'Milk', 1),

			(77, N'Raisin Cookies', 2),
			
			(78, N'Colby Jack Cheese', 2),
			(78, N'Swiss Cheese', 2),
			(78, N'Beef', 5),
			(78, N'Turkey', 2),
			(78, N'Wheat Bread', 6),
			
			(79, N'Potatoes', 10),
			
			(80, N'Apples', 3),
			(80, N'Broccoli', 10),
			(80, N'California Roll', 1),
			(80, N'French Bread', 2),
			(80, N'Ham', 4),
			(80, N'Milk', 1),
			(80, N'Provolone Cheese', 4),
			(80, N'Sugar Cookies', 3),

			(81, N'Cottage Cheese', 6),

			(82, N'Chobani Yogurt', 3),
			(82, N'Corn', 2),
			(82, N'Cucumbers', 4),
			(82, N'Onions', 3),
			(82, N'Potatoes', 2),

			(83, N'Sour Cream', 15),

			(84, N'Strawberries', 5),
			(84, N'Oranges', 5),
			(84, N'Kiwis', 5),
			(84, N'Milk', 2),

			(85, N'Dynamite Roll', 2),
			(85, N'California Roll', 2),

			(86, N'Chocolate Chip Cookie Dough Ice Cream', 3),

			(87,  N'California Roll', 5),
			(87, N'Dynamite Roll', 5),

			(88, N'Tomatoes', 3),
			(88, N'Celery', 2),

			(89, N'Vanilla Ice Cream', 2),

			(90, N'Chocolate Chip Muffins', 1),
			(90, N'Blueberry Muffins', 1),
			(90, N'Banana Nut Muffins', 1),

			(91, N'Milk', 1),
			(91, N'Bananas', 5),
			(91, N'Yogurt', 3),

			(92, N'Butter', 2),

			(93, N'Milk', 1),

			(94, N'Milk', 1),
			(94, N'Apples', 5),

			(95, N'Chicken', 2),
			(95, N'Ham', 2),
			(95, N'Turkey', 2),
			(95, N'Beef', 2),
			(95, N'Colby Jack Cheese', 2),
			(95, N'Swiss Cheese', 2),
			(95, N'PepperJack Cheese', 2),
			(95, N'Provolone Cheese', 2),
			(95, N'White Bread', 2),
			(95, N'Wheat Bread', 2),
			(95, N'French Bread', 2),

			(96, N'Beef', 2),
			(96, N'Butter', 1),
			(96, N'Vanilla Ice Cream', 3),
			(96, N'Strawberries',  2),

			(97, N'Orange Sherbet', 1),
			(97, N'Rocky Road Ice Cream', 1),

			(98, N'Rocky Road Ice Cream', 3),
			(98, N'Vanilla Ice Cream', 3),

			(99, N'Provolone Cheese', 6),

			(100, N'Chocolate Chip Muffins', 5),
			(100, N'Sugar Cookies', 10),

			(101, N'Yogurt', 4),
			(101, N'Apples', 2),

			(102, N'Chocolate Ice Cream', 3),
			(102, N'Double Chocolate Chip Cookies', 5),

			(103, N'Ham', 2),
			(103, N'Turkey',  1),

			(104, N'Celery', 10)

	) TD(TransactionID, ProductName, ItemQuantity)
	INNER JOIN Stores.Product P ON P.ProductName = TD.ProductName
	--INNER JOIN Stores.[Transaction] T ON T.StoreID = TD.StoreID
--GROUP BY T.TransactionID, P.ProductID, P.StoreID, TD.ItemQuantity;

--update products for each transaction
UPDATE P
SET	
	StockQuantity -= 
		(
			SELECT IIF(SUM(TD2.ItemQuantity) IS NULL, 0, SUM(TD2.ItemQuantity))
			FROM Stores.TransactionDetails TD2
			WHERE P.ProductID = TD2.ProductID
		)
FROM Stores.Product P;
/******************************************************************************/