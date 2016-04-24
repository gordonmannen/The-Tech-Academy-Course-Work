SELECT *
FROM Employee as E INNER JOIN PayRates AS PR
ON E.EmpID = PR.EmpID
WHERE ManagerID = 11
AND YearlySalary IS NOT NULL

UPDATE PR SET YearlySalary = YearlySalary + 10000
FROM Employee as E INNER JOIN PayRates AS PR
ON E.EmpID = PR.EmpID
WHERE ManagerID = 11
AND YearlySalary IS NOT NULL