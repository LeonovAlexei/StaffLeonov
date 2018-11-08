SELECT Employee.IdEmployee, Employee.LastName, Employee.FirstName, Employee.Patronymic, Address.Address,Address.idAddressType
FROM Employee,Address
WHERE Address.IdEmployee=Employee.IdEmployee --AND Address.idAddressType=1