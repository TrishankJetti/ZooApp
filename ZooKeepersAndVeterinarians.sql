SELECT * FROM Employee
WHERE Role = 0 OR Role = 1;

/* This query displays Employees who are either 
Zoo Keepers or Veterinians. The Employee table has a RoleType Enum
which at postion Index , 0 , the value is Zoo Keeper while at postion 1 
the value is Veterinarian. */