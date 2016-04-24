CREATE PROC GetEmployeesFromSeattle
AS
	SELECT Emp.firstname, emp.lastname, Loc.city, Loc.[state]
	FROM Employee AS emp
	INNER JOIN Location as Loc
	ON emp.LocationID = Loc.LocationID
	WHERE Loc.city = 'Seattle'
	
CREATE PROC GetEmployeesFromBoston
AS
	SELECT Emp.firstname, emp.lastname, Loc.city, Loc.[state]
	FROM Employee AS emp
	INNER JOIN Location as Loc
	ON emp.LocationID = Loc.LocationID
	WHERE Loc.city = 'Boston'
	
CREATE PROC GetEmployeesByCity @City Varchar(50)
AS
	SELECT Emp.firstname, emp.lastname, Loc.city, Loc.[state]
	FROM Employee AS emp
	INNER JOIN Location as Loc
	ON emp.LocationID = Loc.LocationID
	WHERE Loc.city = @City
	
--This one below adds a default value if you leave paremter blank = Seattle.
	
ALTER PROC GetEmployeesByCity @City Varchar(50) = 'Seattle'
AS
	SELECT Emp.firstname, emp.lastname, Loc.city, Loc.[state]
	FROM Employee AS emp
	INNER JOIN Location as Loc
	ON emp.LocationID = Loc.LocationID
	WHERE Loc.city = @City
