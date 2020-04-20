IF OBJECT_ID(N'Stores.TimeEntry') IS NULL
BEGIN
   CREATE TABLE Stores.TimeEntry
	(
		TimeEntryID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
		EmployeeID INT NOT NULL,
		ClockIn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
		ClockOut DATETIMEOFFSET DEFAULT(SYSDATETIMEOFFSET()),

		CONSTRAINT [FK_Stores_TimeEntry_EmployeeID] FOREIGN KEY(EmployeeID) REFERENCES Stores.Employee(EmployeeID),

		UNIQUE(EmployeeID, ClockIn)
	);
END

/****************************
 * Unique Constraints
 ****************************/

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
END;

/****************************
 * Foreign Keys Constraints
 ****************************/

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
END;
