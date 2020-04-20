IF OBJECT_ID(N'Stores.WorkPosition') IS NULL
BEGIN
   CREATE TABLE Stores.WorkPosition
	(
		WorkPositionID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
		HourlyPay FLOAT NOT NULL,
		PositionName NVARCHAR(32) NOT NULL UNIQUE
	);
END;

/****************************
 * Unique Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.key_constraints kc
      WHERE kc.parent_object_id = OBJECT_ID(N'Person.Person')
         AND kc.[name] = N'UK_Person_Person_Email'
   )
BEGIN
   ALTER TABLE Person.Person
   ADD CONSTRAINT [UK_Person_Person_Email] UNIQUE NONCLUSTERED
   (
      Email ASC
   )
END;

/****************************
 * Check Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.check_constraints cc
      WHERE cc.parent_object_id = OBJECT_ID(N'Person.Person')
         AND cc.[name] = N'CK_Person_Person_LastName_FirstName'
   )
BEGIN
   ALTER TABLE Person.Person
   ADD CONSTRAINT [CK_Person_Person_LastName_FirstName] CHECK
   (
      FirstName > N'' OR LastName > N''
   )
END;
