SELECT EL.NAME AS Employee 
FROM   Employee EL 
INNER JOIN employee ER 
   ON EL.managerid = ER.id 
WHERE  EL.salary > ER.salary 