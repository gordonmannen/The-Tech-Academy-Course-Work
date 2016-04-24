CREATE PROCEDURE uspGetDeptStProvByEmployeeTerr @FirstName varchar(30), @LastName varchar(50), @TerritoryID int
AS
	SELECT PP.FirstName, PP.MiddleName, PP.LastName, HRD.DepartmentID, HRD.Name, HRD.GroupName, PSP.Name, PSP.CountryRegionCode, PSP.TerritoryID
	FROM Person.Person AS PP
	CROSS JOIN HumanResources.Department AS HRD
	CROSS JOIN Person.StateProvince AS PSP
	WHERE PP.FirstName = @FirstName
	AND PP.LastName = @LastName
	AND PSP.TerritoryID = @TerritoryID
	GO

EXEC uspGetDeptStProvByEmployeeTerr @FirstName = 'Dylan', @LastName = 'Miller', @TerritoryID = 1