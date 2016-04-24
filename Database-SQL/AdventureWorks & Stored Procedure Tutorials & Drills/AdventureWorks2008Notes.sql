SELECT *
FROM Person.[Address]

CREATE PROCEDURE uspGetAddress
AS
SELECT * FROM Person.Address
GO

EXEC uspGetAddress

CREATE PROCEDURE uspGetAddress @City nvarchar(30)
AS
SELECT*
FROM Person.Address
WHERE City LIKE @City + '%'
GO

EXEC uspGetAddress @City = 'N%'

CREATE PROCEDURE uspGetAddress @City nvarchar(30) = NULL
AS
SELECT*
FROM Person.Address
WHERE City = @City
GO

CREATE PROCEDURE uspGetAddress @City nvarchar(30) = NULL, @AddressLine1 nvarchar(60) = NULL
AS
SELECT *
FROM Person.Address
WHERE City = ISNULL(@City,City)
AND AddressLine1 LIKE '%' + ISNULL(@AddressLine1,AddressLine1) + '%'
GO

EXEC uspGetAddress @City = 'Calgary', @AddressLine1 = 'A'

CREATE PROCEDURE uspGetAddressCount @City nvarchar(30), @AddressCount int OUTPUT
AS
SELECT @AddressCount = COUNT(*)
FROM Person.Address
WHERE City = @City

DECLARE @AddressCount int
EXEC uspGetAddressCount @City = 'Calgary', @AddressCount = @AddressCount OUTPUT
SELECT @AddressCount

--OR another option where stored procedure names are not passed.

DECLARE @AddressCount int
EXEC uspGetAddressCount 'Calgary', @AddressCount OUTPUT
SELECT @AddressCount

CREATE PROCEDURE uspTryCatchTest
AS
BEGIN TRY
	SELECT 1/0
END TRY
BEGIN CATCH
	SELECT ERROR_NUMBER() AS ErrorNumber
		,ERROR_SEVERITY() AS ErrorSeverity
		,ERROR_STATE() AS ErrorState
		,ERROR_PROCEDURE() AS ErrorProcedure
		,ERROR_LINE() AS ErrorLine --Example of a line comment within a proc.
		,ERROR_MESSAGE() AS ErrorMessage;
END CATCH

--Examples of comments (line comment)
--a second line of comment, two -- will do it.

/*
-this procedure gets a list of addresses based
on the city value that is passed
-this procedure is used by the HR system
-(This section is an example of a block comment),
everything within the /* and the */ will be a comment
Also see above for an example of a line comment within a stored procedure.
*/

--Good idea to use a naming convention for your stored procedures.
--Do NOT use sp_ as a prefix.
--Some good options:  usp_, sp, usp, etc.

--Also a good idea to base the name on what the stored proc
--is doing, like Insert, Delete, Update, Select, Get, Validate, etc.

--Object name and action should be included and then keep it consistent.
--For example uspPersonInsert, uspPersonDelete, etc.

--If schema are being used, examples:
--HR.uspGetPerson, HR.uspInsertPerson, UTIL.uspGet, etc.

--CREATE SCHEMA to create a new schema

--Stored procedure naming convention considerations:
--Schema, Prefix, Action, Object

--If you don't want to get the count of rows affected and all that jibberish, use
AS
SET NOCOUNT ON
--within the stored procedure, it can be turned back on easily using SET NOCOUNT OFF.
--Also, PRINT @@ROWCOUNT will return the number of rows impacted by the previous statement.

--Stored procedures can also be deleted one at a time or multiple using DROP PROCEDURE
--or DROP PROC and then naming the procedure(s) you want dropped, commas except the last
--one if you have multiple.

--Use ALTER PROCEDURE to modify existing procedures.