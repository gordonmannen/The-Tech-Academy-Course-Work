DECLARE @MinPrice INT
SET @MinPrice = 500
DECLARE @MaxPrice INT
SET @MaxPrice = 550

SELECT *
FROM CurrentProducts
WHERE RetailPrice BETWEEN @MinPrice AND @MaxPrice

