SELECT A.Name, E.Name AS EmployeeName
FROM Animal A
INNER JOIN Employee E ON A.EmployeeId = E.EmployeeId;

/* This query gathers the Name of the Animal and the Name of it's 
Employee. Then the query joins both the Name of the Animal and 
it's Employee together to display. */