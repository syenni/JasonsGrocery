IF NOT EXISTS
   (
      SELECT *
      FROM sys.schemas s
      WHERE s.[name] = N'Stores'
   )
BEGIN
   EXEC(N'CREATE SCHEMA [Stores] AUTHORIZATION [dbo]');
END;
