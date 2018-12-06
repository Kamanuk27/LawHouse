SELECT p.*, e.FirstName AS eFName, e.LastName AS eLName	  
FROM ProvidedService p 
JOIN Employee e ON  p.Employee_ID = e.ID 
JOIN [Case] c ON p.Case_ID = c.ID