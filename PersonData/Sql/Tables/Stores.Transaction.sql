IF OBJECT_ID(N'Stores.[Transaction]') IS NULL
BEGIN
   CREATE TABLE Stores.[Transaction]
	(
	TransactionID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	StoreID INT NOT NULL,
	PurchasedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),

	UNIQUE(TransactionID, StoreID),

	CONSTRAINT [FK_Stores_Transaction_StoreID] FOREIGN KEY(StoreID) REFERENCES Stores.Store(StoreID)
	);

END;

/****************************
 * Unique Constraints
 ****************************/
/*
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
END;*/