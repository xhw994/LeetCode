SELECT email 
FROM   person 
GROUP  BY email 
HAVING Count(*) > 1 