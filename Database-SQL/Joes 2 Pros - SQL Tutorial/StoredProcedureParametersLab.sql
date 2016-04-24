CREATE PROC GetProductListByCategory @Category varchar(50)
AS
	SELECT ProductID, ProductName, RetailPrice
	FROM CurrentProducts
	WHERE Category = @Category
	
EXEC GetProductListByCategory 'No-Stay'

CREATE PROC GetGrantsByEmployee @LastName varchar(50)
AS
	SELECT g.GrantName, g.Amount, emp.EmpID, emp.FirstName, emp.LastName
	FROM Employee AS emp
	INNER JOIN [Grant] AS g
	ON emp.EmpID = g.EmpID
	WHERE emp.lastname = @LastName
	
EXEC GetGrantsByEmployee 'Lonning'