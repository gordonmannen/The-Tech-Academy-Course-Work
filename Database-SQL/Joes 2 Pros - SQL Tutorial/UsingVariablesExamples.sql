DECLARE @FirstName Varchar(20)
DECLARE @LastName Varchar(30)

SET @FirstName = 'John'
SET @LastName = 'Smith'

SELECT @FirstName, @LastName

DECLARE @MaxPrice INT
SET @MaxPrice = 1000

--SELECT @MaxPrice

SELECT *
FROM CurrentProducts
WHERE RetailPrice > 500

