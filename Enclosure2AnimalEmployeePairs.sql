INSERT INTO AnimalEmployee (AnimalId, EmployeeId)
SELECT AnimalId, EmployeeId
FROM Animal
WHERE EnclosureId = 2;

/* This SQL query inserts data into the AnimalEmployee table, 
linking animals to employees. It selects AnimalId and EmployeeId 
pairs from the Animal table where the animals belong to 
enclosure number 2, then inserts these pairs into the 
AnimalEmployee table. */





