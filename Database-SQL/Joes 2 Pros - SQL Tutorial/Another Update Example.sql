SELECT E.FirstName, E.LastName, E.LocationID, G.GrantName, G.Amount
FROM [Grant] G INNER JOIN Employee E
ON G.EmpID = E.EmpID
WHERE LocationID = 2

UPDATE [Grant]
SET Amount = 20000
FROM [Grant] G INNER JOIN Employee E
ON G.EmpID = E.EmpID
WHERE LocationID = 2