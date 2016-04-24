CREATE PROC GetOvernightProducts	
AS	
	SELECT *
	FROM CurrentProducts
	WHERE Category = 'Overnight-Stay'
	
EXEC GetOvernightProducts

CREATE PROC GetMediumProducts	
AS	
	SELECT *
	FROM CurrentProducts
	WHERE Category = 'Medium-Stay'
	
EXEC GetMediumProducts

CREATE PROC GetLongTermProducts	
AS	
	SELECT *
	FROM CurrentProducts
	WHERE Category = 'LongTerm-Stay'
	
EXEC GetLongTermProducts