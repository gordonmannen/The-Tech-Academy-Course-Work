DECLARE @MinGrant INT
SET @MinGrant = 20000
DECLARE @MaxGrant INT
SET @MaxGrant = 40000

SELECT *
FROM [Grant]
WHERE Amount BETWEEN @MinGrant AND @MaxGrant