IF OBJECT_ID(N'Stores.TransactionDetails') IS NULL
BEGIN
   CREATE TABLE Stores.TransactionDetails
	(
		TransactionID INT NOT NULL,
		ProductID INT NOT NULL,
		StoreID INT NOT NULL,
		UnitPrice FLOAT NOT NULL,
		ItemQuantity INT NOT NULL,

		CONSTRAINT [PK_Store_TransactionDetails_TransactionID_ProductID] PRIMARY KEY(TransactionID, ProductID),

		CONSTRAINT [FK_Stores_TransactionDetails_TransactionID] FOREIGN KEY(TransactionID) REFERENCES Stores.[Transaction](TransactionID),
		CONSTRAINT [FK_Stores_TransactionDetails_ProductID] FOREIGN KEY(ProductID) REFERENCES Stores.Product(ProductID),
		CONSTRAINT [FK_Stores_TransactionDetails_StoreID] FOREIGN KEY(StoreID) REFERENCES Stores.Store(StoreID)
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
