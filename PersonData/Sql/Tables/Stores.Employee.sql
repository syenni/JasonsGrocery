IF OBJECT_ID(N'Stores.Employee') IS NULL
BEGIN
   CREATE TABLE Stores.Employee
		(
		EmployeeID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
		DepartmentID INT NOT NULL,
		WorkPositionID INT NOT NULL,
		HourlyPay FLOAT NOT NULL,
		EmployeeName NVARCHAR(128) NOT NULL,
		StartDate DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),

		CONSTRAINT [FK_Stores_Employee_DepartmentID] FOREIGN KEY(DepartmentID) 
			REFERENCES Stores.Department(DepartmentID),
		CONSTRAINT [FK_Stores_Employee_WorkPositionID] FOREIGN KEY(WorkPositionID)
			REFERENCES Stores.WorkPosition(WorkPositionID)
	);
END

/****************************
 * Unique Constraints
 ****************************/
/*
IF NOT EXISTS
   (
      SELECT *
      FROM sys.key_constraints kc
      WHERE kc.parent_object_id = OBJECT_ID(N'Person.PersonAddress')
         AND kc.[name] = N'UK_Person_PersonAddress_PersonId_AddressTypeId'
   )
BEGIN
   ALTER TABLE Person.PersonAddress
   ADD CONSTRAINT [UK_Person_PersonAddress_PersonId_AddressTypeId] UNIQUE NONCLUSTERED
   (
      PersonId,
      AddressTypeId
   )
END;*/

/****************************
 * Foreign Keys Constraints
 ****************************/
/*
IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'Person.PersonAddress')
         AND fk.referenced_object_id = OBJECT_ID(N'Person.Person')
         AND fk.[name] = N'FK_Person_PersonAddress_Person_Person'
   )
BEGIN
   ALTER TABLE Person.PersonAddress
   ADD CONSTRAINT [FK_Person_PersonAddress_Person_Person] FOREIGN KEY
   (
      PersonId
   )
   REFERENCES Person.Person
   (
      PersonId
   );
END;

IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'Person.PersonAddress')
         AND fk.referenced_object_id = OBJECT_ID(N'Person.AddressType')
         AND fk.[name] = N'FK_Person_PersonAddress_Person_AddressType'
   )
BEGIN
   ALTER TABLE Person.PersonAddress
   ADD CONSTRAINT [FK_Person_PersonAddress_Person_AddressType] FOREIGN KEY
   (
      AddressTypeId
   )
   REFERENCES Person.AddressType
   (
      AddressTypeId
   );
END;*/
