SELECT E.Name AS EmployeeName, COUNT(AE.AnimalEmployeeId) AS AnimalAssignments
FROM Employee E
LEFT JOIN AnimalEmployee AE ON E.EmployeeId = AE.EmployeeId
GROUP BY Name
ORDER BY AnimalAssignments ASC;

/* This query retrieves the names of employees along with the 
count of animal assignments for each employee.
 It starts by selecting the employee name from 
 the Employee table and counting the number of animal assignments 
 from the AnimalEmployee table.
The LEFT JOIN ensures that all employees are included in the result, even if they have no animal assignments.
The result is grouped by employee name, and the count of animal assignments is sorted in ascending order.
