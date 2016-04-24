SELECT * FROM Location

UPDATE Location SET street = '456 Zags St'
WHERE LocationID = 4

SELECT * FROM Location

--You want to Transfer 500 from Savings to Checking

--Take 500 out of Savings
UPDATE SavAccount SET Balance = Balance - 500
WHERE CustomerID = 18568

--What if you had a full system shutdown here and
--the upcoming transaction never happens?

--Put 500 into checking
UPDATE CkAccount SET Balance = Balance + 500
WHERE CustomerID = 18568

--You really need both to run together = Explicit Transaction

--To do this see below (Explicit Transaction)

BEGIN TRAN

	--Take 500 out of Savings
	UPDATE SavAccount SET Balance = Balance - 500
	WHERE CustomerID = 18568
	
	--Put 500 into checking
	UPDATE CkAccount SET Balance = Balance + 500
	WHERE CustomerID = 18568
	
COMMIT TRAN