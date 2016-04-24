BEGIN TRAN

UPDATE SavAccount SET Balance = Balance - 500
WHERE CustomerID = 18568

IF( (SELECT Balance FROM SavAccount WHERE CustomerID = 18568 < 0)
ROLLBACK TRAN
	
UPDATE CkAccount SET Balance = Balance + 500
WHERE CustomerID = 18568
	
COMMIT TRAN